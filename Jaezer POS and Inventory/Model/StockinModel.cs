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
   public class StockinModel:DBConnection
    {

        public StockIn StockAdjHistory(string dateFrom, string dateTo)
        {
            var obj = new StockIn();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"select * from stock_adjustment where datelogs between '{dateFrom}' and '{dateTo}' order by datelogs asc",con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                obj.ProductList.Add(new StockIn() {
                                    ReferenceNo = rd.GetString("referenceNo"),
                                    ProductName = rd.GetString("productName"),
                                    Qty = rd.GetInt32("qty"),
                                    DateStockin = rd.GetDateTime("datelogs").ToString("MM-dd-yyyy"),
                                    Action = rd.GetString("action"),
                                    Remarks = rd.GetString("remarks"),
                                    UserName = rd.GetString("fullname")
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

            return obj;
        }
        public string GenerateRefNo()
        {
            string refNo = $"R{DateTime.Now.ToString("yyyyMMdd")}";
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select referenceNo from tbl_stockin order by id desc limit 1",con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                if (rd.Read())//R202010180001
                                    refNo += (Convert.ToInt32(rd.GetString("referenceNo").Substring(9, rd.GetString("referenceNo").Length - 9)) + 1).ToString("D4");
                            }
                            else
                                refNo += "0001";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return refNo;
        }

        public StockIn GetStockInHistory(List<int> StockIDs)
        {
            var list = new StockIn();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"SELECT * FROM stockin where stockID IN ({string.Join(",",StockIDs)}) ",con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while(rd.Read())
                            {
                                list.ProductList.Add(new StockIn()
                                {
                                    StockID = rd.GetInt32("stockID"),
                                    ReferenceNo = rd.GetString("referenceNo"),
                                    Price = rd.GetDecimal("purchasePrice"),
                                    ProductName = rd.GetString("productName"),
                                    DateArrival = rd.GetDateTime("dateArrival").ToString("MM-dd-yyyy"),
                                    DateExpiry = rd.GetString("ExpiryDate"),
                                    SupplierName = rd.GetString("supplier"),

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
        public StockIn GetStockInHistory(string dateFrom, string dateTo, string where)
        {
            var list = new StockIn();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = $"SELECT * from stockin where dateStockin between '{dateFrom}' and '{dateTo}' {where} order by dateStockin asc";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                list.ProductList.Add(new StockIn() {
                                    StockID = rd.GetInt32("stockID"),
                                    ReferenceNo = rd.GetString("referenceNo"),
                                    Price = rd.GetDecimal("purchasePrice"),
                                    ProductName = rd.GetString("productName"),
                                    DateArrival = rd.GetDateTime("dateArrival").ToString("MM-dd-yyyy"),
                                    DateExpiry = rd.GetString("ExpiryDate"),
                                    TotalPurchase = rd.GetDecimal("purchasePrice") * rd.GetInt32("qty"),
                                    Qty = rd.GetInt32("qty"),
                                    UnitCode = rd.GetString("unitCode"),
                                    SupplierName = rd.GetString("supplier"),
                                    UserName = rd.GetString("stock_by")

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

        public bool UpdateStockCostPrice(StockIn obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("",con))
                    {
                        cmd.CommandText = $"update tbl_stockin set purchasePrice = {obj.Price} where id = {obj.StockID} ";
                        con.Open();
                        cmd.ExecuteNonQuery();
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
        public StockIn getStockinList(string value)
        {
            var list = new StockIn();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = "select s.id, s.prodID, s.purchasePrice, s.referenceNo,s.qty, s.onhand, s.dateStockin, s.dateExpiry, p.productName, p.hasExpiry,p.dayBExpiry from tbl_stockin as s inner join tbl_product as p on p.id = s.prodID where s.onhand > 0 and  (s.prodID = @Id or p.productName LIKE @ProductName or s.referenceNo = @ReferenceNo) order by s.dateStockin desc";
                        cmd.Parameters.AddWithValue("@Id", value);
                        cmd.Parameters.AddWithValue("@ReferenceNo", value);
                        cmd.Parameters.AddWithValue("ProductName", $"%{value}%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                var obj = new StockIn();
                                obj.StockID = reader.GetInt32("id");
                                obj.ProductID = reader.GetInt32("prodID");
                                obj.ReferenceNo = reader.GetString("referenceNo");
                                obj.Qty = reader.GetInt32("qty");
                                obj.Onhand = reader.GetInt32("onhand");
                                obj.HasExpiry = reader.GetBoolean("hasExpiry");
                                obj.DateStockin = reader.GetDateTime("dateStockin").ToString("MM-dd-yyyy");
                                obj.DateExpiry = reader.GetBoolean("hasExpiry") ? reader.GetDateTime("dateExpiry").ToString("MM-dd-yyyy") : "No Expiry Date";
                                obj.ProductName = reader.GetString("productName");
                                obj.DayBeforeExpiry = reader.GetInt32("dayBExpiry");
                                obj.Price = reader.GetDecimal("purchasePrice");
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

        public bool insert(StockIn list)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        //Insert new stocks to table stockin
                        query = "insert into tbl_stockin (prodID, supplierID, referenceNo, qty, onhand, dateArrival, dateExpiry, dateStockin,userID, purchasePrice) values (@ProdID, @SupplierID, @ReferenceNo, @Qty, @Onhand, @DateArrival, @DateExpiry, @DateStockin, @StockBy,@CostPrice)";
                        cmd.Parameters.AddWithValue($"@ProdID", list.ProductID);
                        cmd.Parameters.AddWithValue($"@SupplierID", list.SupplierID);
                        cmd.Parameters.AddWithValue($"@ReferenceNo", list.ReferenceNo);
                        cmd.Parameters.AddWithValue($"@Qty", list.Qty);
                        cmd.Parameters.AddWithValue($"@Onhand", list.Qty);
                        cmd.Parameters.AddWithValue($"@DateArrival", list.DateArrival);
                        cmd.Parameters.AddWithValue($"@DateExpiry", list.DateExpiry);
                        cmd.Parameters.AddWithValue($"@DateStockin", list.DateStockin);
                        cmd.Parameters.AddWithValue($"@StockBy", list.UserID);
                        cmd.Parameters.AddWithValue("@CostPrice", list.Price);
                        con.Open();
                        MySqlTransaction tr = con.BeginTransaction();
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        int QtyOnhand = 0;
                        decimal balance = 0;

                        //Get the current balance, onhand 
                        cmd.CommandText = $"SELECT onhand, balance from inventory where prodID = {list.ProductID}";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                {
                                    QtyOnhand = rd.GetInt32("onhand");
                                    balance = rd.GetDecimal("balance");

                                }
                        }

                        //Insert Purchase Transaction To Journal
                        QtyOnhand = QtyOnhand > 0 ? QtyOnhand  : list.Qty;
                        balance = QtyOnhand > 0 ? balance: (list.Qty * list.Price);
                        cmd.CommandText = "insert into tbl_inventory_journal (prodID, transaction, costPrice, qtyPurchase,qtyOnhand, balance, sdate, userID) values (@ProductID, @Transaction, @CostPrice, @QtyPurchase,@QtyOnhand, @Balance, @SDate, @UserID)";
                        cmd.Parameters.AddWithValue("@ProductID", list.ProductID);
                        cmd.Parameters.AddWithValue("@Transaction", "purchased");
                        cmd.Parameters.AddWithValue("@CostPrice", list.Price);
                        cmd.Parameters.AddWithValue("@QtyPurchase", list.Qty);
                        cmd.Parameters.AddWithValue("@SDate", list.DateArrival);
                        cmd.Parameters.AddWithValue("@UserID", list.UserID);
                        cmd.Parameters.AddWithValue("@QtyOnhand", QtyOnhand);
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        long LastInsertID = cmd.LastInsertedId;
                       
                      

                        tr.Commit();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\n{cmd.CommandText}");
                return false;
            }
        }

    }

    public class StockInPriceValidator : AbstractValidator<StockIn>
    {
        public StockInPriceValidator()
        {
            RuleForEach(prodList => prodList.ProductList)
               .ChildRules(product =>
               {
                   product.RuleFor(price => price.Price).NotEmpty().WithName(p => p.ProductName).WithMessage("{PropertyName} Price must be empty");
               });
        }
    }
    public class StockInValidator : AbstractValidator<StockIn>
    {

        public StockInValidator()
        {
            RuleForEach(prodList => prodList.ProductList)
                .ChildRules(product =>
                {
                    product.RuleFor(prod => prod.Qty).NotEmpty().When(hasExpiry => hasExpiry.HasExpiry).WithName(p => p.ProductName).WithMessage("{PropertyName} Qty must be empty");
                    product.RuleFor(expire => expire.DateExpiry).NotEmpty().When(hasExpiry => hasExpiry.HasExpiry).WithName(p => p.ProductName).WithMessage("{PropertyName} Expiry Date must be empty");
                    product.RuleFor(price => price.Price).NotEmpty().WithName(p => p.ProductName).WithMessage("{PropertyName} Price must be empty");
                });

            RuleFor(sup => sup.SupplierName)
                .NotEmpty();

            RuleFor(refno => refno.ReferenceNo)
                .NotEmpty();

            RuleFor(incharge => incharge.InCharge)
                .NotEmpty();
        }

    }

    

    public class StockIn : Product
    {
        public int StockID { get; set; }
        public string ReferenceNo { get; set; }
        public string InCharge { get; set; }
        public int UserID { get; set; }
        public int Onhand { get; set; }
        public int remarksVal { get; set; }
        public Decimal Price { get; set; }
        public string DateArrival { get; set; }
        public string DateExpiry { get; set; }
        public string DateStockin { get; set; }
        public string UserName { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
        public decimal TotalPurchase { get; set; }
        public List<StockIn> ProductList = new List<StockIn>();
    }
}
