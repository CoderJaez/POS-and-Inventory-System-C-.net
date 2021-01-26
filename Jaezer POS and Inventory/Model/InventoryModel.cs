using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using MySql.Data.MySqlClient;
namespace Jaezer_POS_and_Inventory.Model
{
    public class InventoryModel : StockinModel
    {
        public List<CancelOrder> GetCancelledOrders(string dateFrom, string dateTo)
        {
            var list = new List<CancelOrder>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"select * from cancelled_orders where sdate between '{dateFrom}' and '{dateTo}' order by sdate asc",con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                list.Add(new CancelOrder()
                                {
                                    Invoice = rd.GetString("invoice"),
                                    ProductName = $"{rd.GetString("productName")} ({rd.GetString("unit").ToUpper()})",
                                    Price = rd.GetDecimal("price"),
                                    Qty = rd.GetInt32("qty"),
                                    Total = rd.GetDecimal("total"),
                                    SDate = rd.GetDateTime("sdate").ToString("MM-dd-yyyy"),
                                    UserName = rd.GetString("fullname"),
                                    Remarks = rd.GetString("remarks")
                                });
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public List<StockIn> GetCriticalItems(string search)
        {
            var list = new List<StockIn>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("",con))
                    {
                        cmd.CommandText = $@"SELECT prodID, productName,hasExpiry, onhand, reorder
                                            from inventory where onhand <= reorder and productName like @productName";
                        cmd.Parameters.AddWithValue("@productName", $"%{search}%");
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while(rd.Read())
                            {
                                list.Add(new StockIn
                                {
                                    ProductID = rd.GetInt32("prodID"),
                                    ProductName = rd.GetString("productName"),
                                    Onhand = rd.GetInt32("onhand"),
                                    ReOrderLevel = rd.GetInt32("reorder"),
                                    HasExpiry = rd.GetBoolean("hasExpiry")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
        public ProductIventorySummary GetProductInventorySummary()
        {
            var summ = new ProductIventorySummary();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        cmd.CommandText = "SELECT prodID, productName, SUM(qty) as totalQty, SUM(totalAmntPurchase) AS totalPurchased, unitCode, SUM(qtySold) as totalQtySold, SUM(totalAmntSold) as totalAmntsold, SUM(onhand) as Onhand, SUM(totalbalance) as balance  FROM stockin group by prodID order by productName asc ";
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                summ.list.Add(new ProductIventorySummary()
                                {
                                    ProductID = rd.GetInt32("prodID"),
                                    ProductDescription = rd.GetString("productName").ToUpper(),
                                    QtyPurchased = rd.GetInt32("totalQty"),
                                    TotalPurchased = rd.GetDecimal("totalPurchased"),
                                    Unit = rd.GetString("unitCode"),
                                    QtySold = rd.GetInt32("totalQtySold"),
                                    TotalAmntSold = rd.GetDecimal("totalAmntSold"),
                                    CostPrice = Math.Round(rd.GetDecimal("totalPurchased") / rd.GetInt32("totalQty"),2),
                                    QtyOnhand = rd.GetInt32("Onhand"),
                                    Balance = rd.GetDecimal("balance")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return summ;
        }
        public StockIn GetProductInventory(string search)
        {
            var list = new StockIn();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = "select * from inventory where productName LIKE @ProductName or category LIKE @Category or brand LIKE @Brand";
                        cmd.Parameters.AddWithValue("@ProductName", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Category", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Brand", $"%{search}%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var obj = new StockIn();
                                obj.ProductID = reader.GetInt32("prodID");
                                obj.ProductName = reader.GetString("productName");
                                obj.Brand = reader.GetString("brand");
                                obj.Category = reader.GetString("category");
                                obj.Onhand = reader.GetInt32("onhand");
                                obj.UnitCode = reader.GetString("baseUnit");
                                obj.ReOrderLevel = reader.GetDouble("reorder");
                                list.ProductList.Add(obj);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public bool StockQtyAdjustment(StockIn obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        string journal_transaction = string.Empty;
                        con.Open();
                        MySqlTransaction trans = con.BeginTransaction();

                       

                        cmd.CommandText = "insert into tbl_stockinlogs (stockinID, qty, action, remarks, datelogs, userID) values (@StockID, @Qty, @Action, @Remarks, @Datelogs, @Incharge)";
                        cmd.Parameters.AddWithValue("@StockID", obj.StockID);
                        cmd.Parameters.AddWithValue("@Qty", obj.Qty);
                        cmd.Parameters.AddWithValue("@Action", obj.Action);
                        cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                        cmd.Parameters.AddWithValue("@Datelogs", obj.DateStockin);
                        cmd.Parameters.AddWithValue("@Incharge", obj.UserID);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        int QtyOnhand = 0;
                        decimal balance = 0;
                        //Get the current balance, onhand 
                        cmd.CommandText = $"SELECT onhand, balance from inventory where prodID = {obj.ProductID}";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                {
                                    QtyOnhand = rd.GetInt32("onhand");
                                    balance = rd.GetDecimal("balance");

                                }
                        }


                        if (obj.Action == "Add To Stock")
                        {
                            //Checks if the Action taken would be added the quantity to inventory
                            journal_transaction = "added";
                            QtyOnhand = QtyOnhand > 0 ? QtyOnhand + obj.Qty : obj.Qty;
                            balance = QtyOnhand > 0 ? balance + (obj.Qty * obj.Price) : (obj.Qty * obj.Price);
                        } else
                        {
                            if (obj.remarksVal == 1)
                            {
                                journal_transaction = "removed";
                                //Checks remarks if item is erroneous entry
                               
                            }
                            else if (obj.remarksVal == 2)
                            {
                                journal_transaction = "damaged";
                            }
                            else
                            {
                                //Checks renarks if item is damaged 
                                journal_transaction = "expired";
                                
                            }
                            QtyOnhand = QtyOnhand > 0 ? QtyOnhand - obj.Qty : obj.Qty;
                            balance = QtyOnhand > 0 ? balance - (obj.Qty * obj.Price) : (obj.Qty * obj.Price);
                        }
                            

                        //Insert Remove Item Transaction To Journal
                        cmd.CommandText = "insert into tbl_inventory_journal (prodID, transaction,invoice, costPrice, qtyOnhand,qtyAdj, balance, sdate, userID) values (@ProductID, @Transaction, @ReferenceNo, @CostPrice, @QtyOnhand,@QtyAdjust, @Balance, @SDate, @UserID)";
                        cmd.Parameters.AddWithValue("@ProductID", obj.ProductID);
                        cmd.Parameters.AddWithValue("@Transaction", journal_transaction);
                        cmd.Parameters.AddWithValue("@ReferenceNo", obj.ReferenceNo);
                        cmd.Parameters.AddWithValue("@CostPrice", obj.Price);
                        cmd.Parameters.AddWithValue("@SDate", obj.DateStockin);
                        cmd.Parameters.AddWithValue("@UserID", obj.UserID);
                        cmd.Parameters.AddWithValue("@QtyAdjust", obj.Qty);
                        cmd.Parameters.AddWithValue("@QtyOnhand", QtyOnhand);
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        cmd.ExecuteNonQuery();


                        //Updating Stocks From tbl_stockin; 
                        if (obj.Action == "Add To Stock")
                            cmd.CommandText = "update tbl_stockin set onhand = onhand + @Qty, qty = qty + @Qty where id = @StockID";
                        else if (obj.Action == "Remove From Stock" && obj.remarksVal == 1)
                            cmd.CommandText = "update tbl_stockin set onhand = onhand -  @Qty, qty = qty - @Qty where id = @StockID";
                        else
                            cmd.CommandText = "update tbl_stockin set onhand = onhand -  @Qty, qtyDmg = qtyDmg + @Qty where id = @StockID";
                        cmd.Parameters.AddWithValue("@Qty", obj.Qty);
                        cmd.Parameters.AddWithValue("@StockID", obj.StockID);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        trans.Commit();
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public ProductCart getProduct(string barcode)
        {
            var obj = new ProductCart();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = "select prcID,prodID, onhand, variant, price, productName, onhand, reorder, hasExpiry, prQty, prUnit, pUnit from productpricelist where barcode = @Barcode and onhand > 0";
                        cmd.Parameters.AddWithValue("@Barcode", barcode);
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                obj.PriceID = rd.GetInt32("prcID");
                                obj.ProductID = rd.GetInt32("prodID");
                                obj.Onhand = rd.GetInt32("onhand");
                                obj.Variant = rd.GetString("variant");
                                obj.ProductName = $"{rd.GetString("productName")} ({rd.GetString("prUnit")})";
                                obj.HasExpiry = rd.GetBoolean("hasExpiry");
                                obj.Price = rd.GetDecimal("price");
                                obj.PrQty = rd.GetInt32("prQty");
                                obj.UnitCode = rd.GetString("prUnit");
                                obj.Qty = 1;
                                obj.Total = obj.Price;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return obj;
        }

        public StockIn ExpiryItems()
        {
            var list = new StockIn();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select * from expiry_products",con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                list.ProductList.Add(new StockIn() {
                                    ProductID = rd.GetInt32("prodID"),
                                    StockID = rd.GetInt32("id"),
                                    ReferenceNo = rd.GetString("referenceNo"),
                                    ProductName = rd.GetString("productName"),
                                    DateArrival = rd.GetDateTime("dateArrival").ToString("MM-dd-yyyy"),
                                    DateExpiry = rd.GetDateTime("dateExpiry").ToString("MM-dd-yyyy"),
                                    Onhand = rd.GetInt32("onhand"),
                                    UnitCode = rd.GetString("unitCode"),
                                    DayBeforeExpiry = rd.GetInt32("nDaysBExp")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public List<string> YearList()
        {
            var list = new List<string>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select yr from year_sales",con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while(rd.Read())
                            {
                                list.Add(rd.GetString("yr"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        #region IncomeStatement
        public IncomeStatement GetIncomeStatement(string year)
        {
            var income = new IncomeStatement();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        MySqlTransaction tr = con.BeginTransaction();
                        //This is will get the Net Sales of the selected year
                        cmd.CommandText = $"select sum(qty * price) as sales, sum(total) as netSales, sum(disc) as discounts from sold_items where date_format(sdate, '%Y') = '{year}' ";

                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if(rd.Read())
                            {
                                income.Sales = rd.GetDecimal("sales");
                                income.Discounts = rd.GetDecimal("discounts");
                                income.NetSales = rd.GetDecimal("netSales");
                            }
                        }

                        //This is will get Beginning Inventory which is the previous year balance 
                        cmd.CommandText = $"select sum(totalBalance) as begInvty from stockin where date_format(dateArrival,'%Y') <= '{int.Parse(year) - 1}'";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                if (!rd.IsDBNull(0))
                                    income.BegInvty = rd.GetDecimal("begInvty");
                        }

                        //This is will get the total item purchases, ending inventory, cost of sales 
                        cmd.CommandText = $"select sum(totalAmntPurchase) as Purchases,sum(totalAmntSold) as totalSold, sum(totalBalance) as EndInvty  from stockin where date_format(dateArrival,'%Y') = '{year}'";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                income.Purchases = rd.GetDecimal("Purchases");
                                income.EndInvty = rd.GetDecimal("EndInvty") + income.BegInvty;
                                income.CostOfGoodsSold = rd.GetDecimal("totalSold");

                            }
                        }
                        //This is will get the total Damaged items
                        cmd.CommandText = $"select sum(s.qtyDmg * pr.price) as damages from tbl_stockin as s inner join productpricelist as pr on pr.prodID = s.prodID where pr.prQty = 1 and  date_format(s.dateArrival,'%Y') = '{year}'";

                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                income.Damages = rd.GetDecimal("damages");
                        }


                        //This get the List of Expenses
                        cmd.CommandText = $"select description, sum(amount) as amount from expenses where deleted = false and date_format(edate,'%Y') = {year} group by description";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                income.Expenses.Add(new Expenses {
                                    Description = rd.GetString("description"),
                                    Amount = rd.GetDecimal("amount")
                                });
                                income.TotalExpenses += rd.GetDecimal("amount");
                            }
                        }
                        //Compute the Gross Profit
                        income.GrossProfit = income.NetSales - income.CostOfGoodsSold;
                        //Adding Sales to Damages
                        income.Sales += income.Damages;
                        tr.Commit();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return income;
        }
#endregion
        public List<ProductPrice> ProductInquiryList(string search)
        {
            var list = new List<ProductPrice>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = "select prodID, prcID, variant, price, productName, onhand, reorder,isSale, sprice, dateFrm, dateTo,  hasExpiry, prQty, prUnit, pUnit from productpricelist where onhand > 0 and (barcode like @Barcode or variant like @Variant or productName like @ProductName)";
                        cmd.Parameters.AddWithValue("@Barcode", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Variant", $"%{search}%");
                        cmd.Parameters.AddWithValue("@ProductName", $"%{search}%");
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while(rd.Read())
                            {
                                var obj = new ProductPrice();
                                obj.ProductID = rd.GetInt32("prodID");
                                obj.PriceID = rd.GetInt32("prcID");
                                obj.Variant = rd.GetString("variant");
                                obj.ProductName = rd.GetString("productName");
                                obj.Onhand = rd.GetInt32("onhand");
                                obj.HasExpiry = rd.GetBoolean("hasExpiry");
                                obj.Price = rd.GetDecimal("price");
                                obj.PriceQty = rd.GetInt32("prQty");
                                obj.PriceUnit = rd.GetString("prUnit");
                                obj.ProdUnit = rd.GetString("pUnit");
                                obj.ReOrder = rd.GetInt32("reorder");
                                obj.IsSale = rd.GetBoolean("isSale");
                                obj.SPrice = rd.GetDecimal("sprice");
                                obj.SDateFrm = rd.GetDateTime("dateFrm").ToString("MM-dd-yyyy");
                                obj.SDateTo = rd.GetDateTime("dateTo").ToString("MM-dd-yyyy");
                                list.Add(obj);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }

       

    }


    public class StockAdjustmentValidator:AbstractValidator<StockIn>
    {
        public StockAdjustmentValidator()
        {
            RuleFor(prod => prod.ProductName)
                .NotEmpty();
            RuleFor(qty => qty.Qty)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Must(IsValidQty).WithMessage("{PropertyName} must less than to Onhand qty");
            RuleFor(remark => remark.Remarks)
                .NotEmpty();
            RuleFor(action => action.Action)
                .NotEmpty();
            RuleFor(incharge => incharge.InCharge)
                .NotEmpty();
        }

        private bool IsValidQty(StockIn obj, int qty)
        {
            return obj.Action == "Add To Stock" ? true: obj.Onhand - qty < 0 ? false : true;
        }
    }

    public class IncomeStatement
    {
        public decimal BegInvty { get; set; }
        public decimal CostOfGoodsSold { get; set; }
        public decimal Damages { get; set; }
        public decimal Discounts { get; set; }
        public decimal EndInvty { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal NetSales { get; set; }
        public decimal Sales { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal Purchases { get; set; }
        public decimal Profit { get; set; }
        public List<Expenses> Expenses = new List<Expenses>();
    }
    public class ProductIventorySummary 
    {
        public int ProductID { get; set; }
        public string ProductDescription { get; set; }
        public decimal CostPrice { get; set; }
        public string Unit { get; set; }
        public int QtyPurchased { get; set; }
        public decimal TotalPurchased { get; set; }
        public decimal TotalAmntSold { get; set; }
        public int QtySold { get; set; }
        public int QtyOnhand { get; set; }
        public decimal Balance { get; set; }
        public List<ProductIventorySummary> list = new List<ProductIventorySummary>(); 
    }
    public class ProductPrice : IProduct, IProductPrice
    {
        public int ProductID { get; set; }
        public string Barcode { get; set; }
        public int dayExpiry { get; set; }
        public int datExpiry { get; set; }
        public string ProdUnit { get; set; }
        public string PriceUnit { get; set; }
        public int PriceID { get; set; }
        public int PriceQty { get; set; }
        public bool HasExpiry { get; set; }
        public int Onhand { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public int ReOrder { get; set; }
        public string Variant { get; set; }
        public int PrQty { get; set; }
        public decimal SPrice { get; set; }
        public bool IsSale { get; set; }
        public string SDateFrm { get; set; }
        public string SDateTo { get; set; }
       
    }
    public class ProductCart : IProductCart
    {
        public int ProductID { get; set; }
        public int PriceID { get; set; }
        public int CartID { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public bool HasExpiry  {  get;  set; }
        public int dayExpiry { get; set; }
        public string Invoice { get; set; }
        public int Onhand { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public int ReOrder { get; set; }
        public string SDate { get; set; }
        public decimal Total { get; set; }
        public string UnitCode { get; set; }
        public int UserID { get; set; }
        public string User { get; set; }
        public string Variant { get; set; }
        public int PrQty { get; set; }
        public decimal Profit { get; set; }
        public int UnitID { get; set; }
        public bool DefaultUnit { get; set; }
        public decimal Discount { get; set; }
        public decimal SPrice { get; set; }
        public bool IsSale { get; set; }
        public string SDateFrm { get; set; }
        public string SDateTo { get; set; }
       
    }
}
