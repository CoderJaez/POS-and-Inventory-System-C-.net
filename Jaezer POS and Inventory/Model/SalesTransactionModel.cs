using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FluentValidation;
using System.Data;

namespace Jaezer_POS_and_Inventory.Model
{
    class SalesTransactionModel : DBConnection
    {
        struct ProdDetails
        {
            public int qty;
            public int id;
            public decimal price;
        }
        public List<ProductCart> GetTopSellingItems(string dFrom, string dTo, string order_by)
        {
            var list = new List<ProductCart>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"SELECT productName,SUM(bQtyItem) AS totalQty, SUM(total) AS totalSales,pUnit FROM sold_items where sdate between '{dFrom}' and '{dTo}' GROUP BY productName ORDER BY {order_by} DESC ", con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                list.Add(new ProductCart()
                                {
                                    ProductName = rd.GetString("productName"),
                                    Qty = rd.GetInt32("totalQty"),
                                    UnitCode = rd.GetString("pUnit"),
                                    Total = rd.GetDecimal("totalSales")
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

        private ProdDetails getStockQty(int prcID, bool hasExpiry, MySqlConnection _con)
        {
            ProdDetails prd = new ProdDetails();
            try
            {
                using (cmd = new MySqlCommand("", _con))
                {
                    if (hasExpiry)
                        query = $"select s.onhand,s.prodID,s.purchasePrice from tbl_stockin as s inner join tbl_pricing as pr on pr.prodID = s.prodID where pr.id = {prcID} and s.onhand > 0 order by s.dateExpiry asc,s.id asc limit 1";
                    else
                        query = $"select s.onhand,s.prodID,s.purchasePrice from tbl_stockin as s inner join tbl_pricing as pr on pr.prodID = s.prodID where pr.id = {prcID} and s.onhand > 0 order by s.dateStockin asc, s.id asc limit 1";
                    cmd.CommandText = query;
                    using (MySqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            prd.qty = rd.GetInt32("onhand");
                            prd.id = rd.GetInt32("prodID");
                            prd.price = rd.GetDecimal("purchasePrice");
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n getStockQty");
            }
            return prd;
        }
        

        public bool insert(ProductCart item)
        {
            ProdDetails prd = new ProdDetails();
            int QtyOnhand = 0;
            decimal balance = 0;
            int qtyDeducted = 0;
            long LastInsertedID;
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        MySqlTransaction tran = con.BeginTransaction();
                        cmd.CommandText = $"insert into tbl_cart (invoice, prID, price, qty, unit,disc, total, sdate, isSale,userID) values ('{item.Invoice}', {item.PriceID}, {item.Price}, {item.Qty},'{item.UnitCode}',{item.Discount}, {item.Total}, '{item.SDate}', {item.IsSale},'{item.UserID}')";
                        cmd.ExecuteNonQuery();
                        LastInsertedID = cmd.LastInsertedId;

                        //Insert Goods Sold with Selling Price
                        cmd.CommandText = $"insert into tbl_inventory_journal(prodID, invoice, transaction,disc, qtySold, unitSold, sellPrice,qtyOnhand,balance, sdate, userID) values ({item.ProductID},{item.Invoice},'sold',{item.Discount}, {item.Qty},'{item.UnitCode}',{item.Price}, {QtyOnhand},{balance},'{item.SDate}', {item.UserID})";
                        cmd.ExecuteNonQuery();

                        if (item.HasExpiry)
                        {
                            

                            //item.prqQty == 100;
                            while (item.PrQty > 0)
                            {
                                qtyDeducted = 0;
                                prd = getStockQty(item.PriceID, item.HasExpiry, con);
                                //Checks if qty onhand is greater than qty purchase
                                if (prd.qty >= item.PrQty || prd.qty <= 0) //95 > 100
                                    qtyDeducted = item.PrQty;
                                else //50 > 100
                                    qtyDeducted = prd.qty; //100 - 95 = 5
                                if (prd.qty <= 0)
                                    cmd.CommandText = $"update tbl_stockin  AS s  SET s.onhand = s.onhand - {qtyDeducted} WHERE s.prodID  = {item.ProductID} ORDER BY s.dateExpiry DESC, s.id ASC LIMIT 1";
                                //Negative Quantity
                                else
                                    cmd.CommandText = $"update tbl_stockin  AS s  SET s.onhand = s.onhand - {qtyDeducted} WHERE s.prodID  = {item.ProductID} and s.onhand > 0 ORDER BY s.dateExpiry ASC, s.id ASC LIMIT 1";
                                cmd.ExecuteNonQuery();

                                //Get the current balance, onhand 
                                cmd.CommandText = $"SELECT onhand, balance from inventory where prodID = {item.ProductID}";
                                using (MySqlDataReader rd = cmd.ExecuteReader())
                                {
                                    if (rd.HasRows)
                                        if (rd.Read())
                                        {
                                            QtyOnhand = rd.GetInt32("onhand");
                                            balance = rd.GetDecimal("balance");

                                        }
                                }

                                //Insert Cost of Goods Sold
                                cmd.CommandText = $"insert into tbl_inventory_journal(prodID, invoice, transaction, costPrice, bQtySold,qtyOnhand,balance, sdate, userID) values ({prd.id},{item.Invoice},'sold_detail',{prd.price}, {qtyDeducted},{QtyOnhand},{balance},'{item.SDate}', {item.UserID})";
                                cmd.ExecuteNonQuery();

                                item.PrQty -= qtyDeducted; //100 - 50 = 50 prQty
                            } //End While Loop

                            
                        }
                        else
                        {
                            while (item.PrQty > 0)
                            {
                                qtyDeducted = 0;
                                prd = getStockQty(item.PriceID, item.HasExpiry, con);

                                if (prd.qty >= item.PrQty || prd.qty <= 0) //95 > 100
                                    qtyDeducted = item.PrQty;
                                else//12 > 44
                                    qtyDeducted = prd.qty;
                                //update the quantity onhand of the product
                                if (prd.qty <= 0)
                                    cmd.CommandText = $"update tbl_stockin  AS s  SET s.onhand = s.onhand - {qtyDeducted} WHERE s.prodID  = {item.ProductID}  ORDER BY s.dateStockin DESC, s.id ASC LIMIT 1";
                                //update the quantity onhand of the product with negative quantity
                                else
                                    cmd.CommandText = $"update tbl_stockin  AS s  SET s.onhand = s.onhand - {qtyDeducted} WHERE s.prodID  = {item.ProductID} and s.onhand > 0 ORDER BY s.dateStockin ASC, s.id ASC LIMIT 1";
                                cmd.ExecuteNonQuery();

                                 QtyOnhand = 0;
                                 balance = 0;
                                //Get the current balance, onhand 
                                cmd.CommandText = $"SELECT onhand, balance from inventory where prodID = {item.ProductID}";
                                using (MySqlDataReader rd = cmd.ExecuteReader())
                                {
                                    if (rd.HasRows)
                                        if (rd.Read())
                                        {
                                            QtyOnhand = rd.GetInt32("onhand");
                                            balance = rd.GetDecimal("balance");

                                        }
                                }

                                //Insert Cost of Goods Sold
                                cmd.CommandText = $"insert into tbl_inventory_journal(prodID, invoice, transaction, costPrice, bQtySold,qtyOnhand,balance, sdate, userID) values ({prd.id},{item.Invoice},'sold_detail',{prd.price}, {qtyDeducted},{QtyOnhand},{balance},'{item.SDate}', {item.UserID})";
                                cmd.ExecuteNonQuery();

                                item.PrQty -= qtyDeducted; //100 - 50 = 50 prQty
                            }//End while
                          
                        }
                        tran.Commit();
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
        public bool CancelTransaction(string TransactionNo)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"delete from tbl_payments where invoice = {TransactionNo}", con))
                    {
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
        public string NewTransaction()
        {
            string TransactionNo = DateTime.Now.ToString("yyyyMMddhhmm");
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select invoice from tbl_cart order by id desc limit 1", con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                if (rd.Read())
                                    TransactionNo += (Convert.ToInt32(rd.GetString("invoice").Substring(12, rd.GetString("invoice").Length - 12)) + 1).ToString("D3");
                            }
                            else
                                TransactionNo += "001";

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return TransactionNo;
        }

        public decimal vat()
        {
            decimal vat = 0;
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select vat from tbl_vat", con))
                    {
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                if (rd.Read())
                                    vat = rd.GetDecimal("vat");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return vat;
        }

        public bool insertCancelOrder(CancelOrder corder, ProductCart cart)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        MySqlTransaction tr = con.BeginTransaction();

                        if (corder.IsAddToInventory)
                        {
                            if (cart.HasExpiry)
                            {
                                cmd.CommandText = $"update tbl_stockin  AS s INNER JOIN tbl_pricing AS pr ON pr.prodID = s.prodID SET s.onhand = s.onhand + {corder.PrQty} WHERE pr.id  = {cart.PriceID} and s.onhand > 0 ORDER BY s.dateExpiry ASC, s.id ASC LIMIT 1";
                            }
                            else
                            {
                                cmd.CommandText = $"update tbl_stockin  AS s INNER JOIN tbl_pricing AS pr ON pr.prodID = s.prodID SET s.onhand = s.onhand + {corder.PrQty} WHERE pr.id  = {cart.PriceID} and s.onhand > 0 ORDER BY s.dateStockin ASC, s.id ASC LIMIT 1";
                            }
                            cmd.ExecuteNonQuery();

                        } else
                        {
                            if(cart.HasExpiry)
                            {
                                cmd.CommandText = $"update tbl_stockin  AS s INNER JOIN tbl_pricing AS pr ON {corder.PrQty} WHERE pr.id  = {cart.PriceID} and s.onhand > 0 ORDER BY s.dateExpiry ASC, s.id ASC LIMIT 1";
                            }
                            else
                            {
                                cmd.CommandText = $"update tbl_stockin  AS s INNER JOIN tbl_pricing AS pr ON pr.prodID = s.prodID SET s.qtyDmg = s.qtyDmg + {corder.PrQty} WHERE pr.id  = {cart.PriceID} and s.onhand > 0 ORDER BY s.dateStockin ASC, s.id ASC LIMIT 1";
                            }
                            cmd.ExecuteNonQuery();
                        }

                        if (corder.Qty == cart.Qty)
                            cmd.CommandText = $"delete from tbl_cart where id = {cart.CartID}";
                        else
                            cmd.CommandText = $"update tbl_cart set qty = qty - {corder.Qty}, total = total - {corder.Total} where id = {cart.CartID}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "insert into tbl_cancelled_order (invoice, prID, price, qty, total, unit, sdate, userID, remarks) values (@Invoice, @PriceID, @Price, @Qty,@Total, @Unit, @Sdate, @UserID, @Remarks)";
                        cmd.Parameters.AddWithValue("@Invoice", cart.Invoice);
                        cmd.Parameters.AddWithValue("@PriceID", cart.PriceID);
                        cmd.Parameters.AddWithValue("@Price", cart.Price);
                        cmd.Parameters.AddWithValue("@Qty", corder.Qty);
                        cmd.Parameters.AddWithValue("@Total", corder.Total);
                        cmd.Parameters.AddWithValue("@Sdate", corder.SDate);
                        cmd.Parameters.AddWithValue("@UserID", corder.UserID);
                        cmd.Parameters.AddWithValue("@Unit", cart.UnitCode);
                        cmd.Parameters.AddWithValue("@Remarks", corder.Remarks);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();



                        int QtyOnhand = 0;
                        decimal balance = 0;
                        decimal CostPrice = 0;
                        string journal_transaction = string.Empty;
                        //Get the current balance, onhand 
                        cmd.CommandText = $"SELECT onhand, balance from inventory where prodID = {cart.ProductID}";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                                if (rd.Read())
                                {
                                    QtyOnhand = rd.GetInt32("onhand");
                                    balance = rd.GetDecimal("balance");

                                }
                        }


                        if (corder.IsAddToInventory)
                            journal_transaction = "returned";
                        else
                            journal_transaction = "damaged";

                        //Get the Cost Price from table stockin to be inserted in the table inventory journal
                        if (cart.HasExpiry)
                            cmd.CommandText = $"SELECT purchasePrice from tbl_stockin where prodID = {cart.ProductID} and onhand > 0 ORDER BY dateExpiry ASC, id ASC LIMIT 1";
                        else
                            cmd.CommandText = $"SELECT purchasePrice from tbl_stockin where prodID = {cart.ProductID} and onhand > 0 ORDER BY dateStockin ASC, id ASC LIMIT 1";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                CostPrice = rd.GetDecimal("purchasePrice");
                        }
                        //Insert Remove Item Transaction To Journal
                        cmd.CommandText = "insert into tbl_inventory_journal (prodID, transaction,invoice, costPrice,sellPrice, qtyOnhand,qtyAdj,unitSold, balance, sdate, userID) values (@ProductID, @Transaction, @ReferenceNo, @CostPrice, @SellPrice, @QtyOnhand,@QtyAdjust,@UnitCode, @Balance, @SDate, @UserID)";
                        cmd.Parameters.AddWithValue("@ProductID", cart.ProductID);
                        cmd.Parameters.AddWithValue("@Transaction", journal_transaction);
                        cmd.Parameters.AddWithValue("@ReferenceNo", cart.Invoice);
                        cmd.Parameters.AddWithValue("@CostPrice", CostPrice);
                        cmd.Parameters.AddWithValue("@SellPrice", cart.Price);
                        cmd.Parameters.AddWithValue("@SDate", corder.SDate);
                        cmd.Parameters.AddWithValue("@UserID", corder.UserID);
                        cmd.Parameters.AddWithValue("@QtyAdjust", corder.Qty);
                        cmd.Parameters.AddWithValue("@UnitCode", cart.UnitCode);
                        cmd.Parameters.AddWithValue("@QtyOnhand", QtyOnhand);
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        tr.Commit();
                        return true;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + cmd.CommandText);
                return false;
            }
        }

        public ProductCart GetSoldItems(int CartID)
        {
            var obj = new ProductCart();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = $"SELECT c.id,pr.prodID, pr.barcode, pr.hasExpiry, pr.prcID, c.invoice, pr.productName, c.price, c.qty, c.unit, pr.prQty, c.total, c.disc FROM tbl_cart AS c inner join productpricelist as pr on pr.prcID = c.prID where c.id = {CartID}";
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                obj.CartID = rd.GetInt32("id");
                                obj.ProductID = rd.GetInt32("prodID");
                                obj.PriceID = rd.GetInt32("prcID");
                                obj.Barcode = rd.GetString("barcode");
                                obj.HasExpiry = rd.GetBoolean("hasExpiry");
                                obj.Invoice = rd.GetString("invoice");
                                obj.ProductName = $"{rd.GetString("productName")} ({rd.GetString("unit")})";
                                obj.Price = rd.GetDecimal("price");
                                obj.Qty = rd.GetInt32("qty");
                                obj.PrQty = rd.GetInt32("prQty");
                                obj.Total = rd.GetDecimal("total");
                                obj.Discount = rd.GetDecimal("disc");
                                obj.UnitCode = rd.GetString("unit");
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

        public bool deleteDiscSale(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_pricing set isSale = false, sprice = 0.00, dateFrm = '0000-00-00', dateTo = '0000-00-00' where id = {id}",con))
                    {
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
        public bool EndSaleEvent()
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("UPDATE tbl_pricing SET isSale = FALSE, sprice = 0.00, dateFrm = '0000-00-00', dateTo = '0000-00-00' WHERE isSale = TRUE and dateTo < date_format(now(), '%Y-%m-%d')",con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddItemDiscSale(List<ProductPrice> list)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    string isSale = "isSale = CASE", sprice = "sprice = CASE", dFrom = "dateFrm = CASE", dTo = "dateTo = CASE";
                    List<int> prID = new List<int>();
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        query = "update tbl_pricing set ";
                        foreach (var item in list)
                        {
                            isSale += $" when id = {item.PriceID} then {item.IsSale}";
                            sprice += $" when id = {item.PriceID} then {item.SPrice}";
                            dFrom += $" when id = {item.PriceID} then '{item.SDateFrm}'";
                            dTo += $" when id = {item.PriceID} then '{item.SDateTo}'";
                            prID.Add(item.PriceID);
                        }

                        isSale += " END,";
                        sprice += " END,";
                        dTo += " END,";
                        dFrom += " END";
                        query += $"{isSale} {sprice} {dTo} {dFrom} where id in ({string.Join(",", prID)})";
                        cmd.CommandText = query;
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
        private int totalRows;

        public int TotalRows
        {
            get { return totalRows; }
            set { totalRows = value; }
        }

        public List<IProductCart> SoldItems(string dFrom, string dTo, string userID, string search, int start = 0, int limit = 50, bool isReport = true)
        {
            var list = new List<IProductCart>();
            string _limit = $"LIMIT {start}, {limit}";
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    con.Open();
                    MySqlTransaction tr = con.BeginTransaction();
                    using (cmd = new MySqlCommand($"select sold_items.*,  ( i.totalAmntPurchase / i.totalQtyPurchase) AS costPrice from sold_items inner join inventory as  i on i.prodID = sold_items.prodID where sold_items.sdate between '{dFrom}' and '{dTo}' and sold_items.userID like '%{userID}%'  and ( sold_items.invoice like @Invoice or sold_items.productName like @Product ) order by sold_items.catID DESC {(isReport ? "": _limit)} ", con))
                        cmd.Parameters.AddWithValue("@Invoice", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Product", $"%{search}%");
                    {
                     
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                var obj = new ProductCart();
                                obj.CartID = rd.GetInt32("catID");
                                obj.Invoice = rd.GetString("invoice");
                                obj.ProductName = rd.GetString("productName");
                                obj.SPrice = rd.GetDecimal("price");
                                obj.Price = Math.Round(rd.GetDecimal("costPrice"),2);
                                obj.Qty = rd.GetInt32("qty");
                                obj.UnitCode = rd.GetString("unit");
                                obj.IsSale = rd.GetBoolean("isSale");
                                obj.Total = rd.GetDecimal("total");
                                obj.Discount = rd.GetDecimal("disc");
                                obj.SDate = rd.GetDateTime("sdate").ToString("MM-dd-yyyy");
                                obj.User = rd.GetString("fullname");
                                list.Add(obj);

                            }
                        }
                    }

                    using (cmd = new MySqlCommand($"SELECT COUNT(*) AS totalRows from sold_items inner join inventory as  i on i.prodID = sold_items.prodID where sold_items.sdate between '{dFrom}' and '{dTo}' and sold_items.userID like '%{userID}%'  and ( sold_items.invoice like @Invoice or sold_items.productName like @Product )", con))
                    {
                        cmd.Parameters.AddWithValue("@Invoice", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Product", $"%{search}%");

                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                totalRows = rd.GetInt32("totalRows");
                        }
                    }

                    tr.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
    }
    public class CancelOrderValidator:AbstractValidator<CancelOrder>
    {
        public CancelOrderValidator(int cQty)
        {
            RuleFor(qty => qty.Qty)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .LessThanOrEqualTo(cQty);
            RuleFor(rmrk => rmrk.Remarks)
                .NotEmpty();
            RuleFor(x => x.HasATIcheck)
                .NotEqual(false).WithMessage("Select wether to return the item to Inventory or Not.");
        }
    }
    public class CancelOrder : ProductCart
    {
        public string Remarks { get; set; }
        public string UserName { get; set; }
        public bool IsAddToInventory { get; set; }
        public bool HasATIcheck { get; set; }
        public int RemarksVal { get; set; }
    }

    public class PaymentTransaction : IPaymentTransaction
    {
        public decimal AmountDue { get; set; }
    

        public decimal Discount { get; set; }
      

        public string InvoiceNo { get; set; }
       

        public int PaymentID { get; set; }
     

        public string SDate { get; set; }
     

        public decimal SubTotal { get; set; }
      
        public int UserID { get; set; }
       

        public decimal Vat { get; set; }
       

        public decimal CashTendered { get; set; }
        public decimal Change { get; set; }
        public decimal Total { get; set; }
    }
}
