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
    class ProductModel:DBConnection
    {

        private int totalRows;

        public int TotalRows
        {
            get { return totalRows; }
            set { totalRows = value; }
        }

        private int filterRows;

        public int FilteredRows
        {
            get { return filterRows; }
            set { filterRows = value; }
        }

        public long insert(Product obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = "insert into tbl_product (productName, brandID, catID,ugID, reorder, hasExpiry, dayBExpiry) values (@ProductName, @BrandID, @CatID,@UnitID, @ReOrder, @HasExpiry, @DayBExpiry)";
                        cmd.Parameters.AddWithValue("@ProductName",obj.ProductName);
                        cmd.Parameters.AddWithValue("@BrandID", obj.BrandID);
                        cmd.Parameters.AddWithValue("@HasExpiry", obj.HasExpiry);
                        cmd.Parameters.AddWithValue("@UnitID", obj.UnitID);
                        cmd.Parameters.AddWithValue("@CatID", obj.CatID);
                        cmd.Parameters.AddWithValue("@ReOrder", obj.ReOrderLevel);
                        cmd.Parameters.AddWithValue("@DayBExpiry", obj.DayBeforeExpiry);
                        cmd.ExecuteNonQuery();
                        return cmd.LastInsertedId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public bool update(Product obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("update tbl_product set productName = @ProductName, brandID = @BrandID, catID = @CatID, reorder = @ReOrder, hasExpiry = @HasExpiry, ugID = @UnitID, dayBExpiry = @DayBEpiry where id = @ID", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@ProductName", obj.ProductName);
                        cmd.Parameters.AddWithValue("@BrandID", obj.BrandID);
                        cmd.Parameters.AddWithValue("@CatID", obj.CatID);
                        cmd.Parameters.AddWithValue("@ReOrder", obj.ReOrderLevel);
                        cmd.Parameters.AddWithValue("@HasExpiry", obj.HasExpiry);
                        cmd.Parameters.AddWithValue("@UnitID", obj.UnitID);
                        cmd.Parameters.AddWithValue("@ID",obj.ProductID);
                        cmd.Parameters.AddWithValue("@DayBEpiry", obj.DayBeforeExpiry);
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

        public bool delete(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"UPDATE tbl_product SET deleted = true where id = {id}", con))
                    {
                        con.Open();
                        tr = con.BeginTransaction();
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = $"UPDATE tbl_unit_grp set deleted = true where prodID = {id}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = $"UPDATE tbl_pricing set deleted = true  where  prodID = {id}";
                        cmd.ExecuteNonQuery();
                        tr.Commit();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                tr.Rollback();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool delete(List<int> ids)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using(cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        query = "update tbl_product set";
                        foreach (var id in ids)
                            query += $" deleted = CASE WHEN id = {id} THEN true else deleted END,";

                        query = query.Remove(query.Length - 1, 1);
                        query += $" where id in ({string.Join(",",ids)})";
                        cmd.CommandText = query;
                        tr = con.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        foreach(int id in ids)
                        {
                            cmd.CommandText = $"UPDATE tbl_unit_grp set deleted = true where prodID = {id}";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = $"UPDATE tbl_pricing set prodID = {id}";
                            cmd.ExecuteNonQuery();
                        }
                        tr.Commit();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                tr.Rollback();
                MessageBox.Show(ex.Message + $"\n{cmd.CommandText}");
                return false;
            }
        }


        public List<Product> getProduct(string search, int start = 0, int limit = 50)
        {
            List<Product> list = new List<Product>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    con.Open();
                    MySqlTransaction tr = con.BeginTransaction();
                    using (cmd = new MySqlCommand("", con))
                    {
                        cmd.CommandText = "select p.id, p.productName, b.brand, c.category, p.reorder, p.hasExpiry, units.unitCode, units.qty from tbl_product as p inner join tbl_brand as b on b.id = p.brandID inner join tbl_category as c on c.id = p.catID inner join units on units.id = p.ugID where p.deleted = false and (p.productName LIKE @ProductName  or b.brand LIKE @BrandName or c.category LIKE @Category or p.catID LIKE  @CatID) order by p.productName ASC LIMIT @Start, @Limit";
                        cmd.Parameters.AddWithValue("@CatID", $"%{search}%");
                        cmd.Parameters.AddWithValue("@ProductName", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Category", $"%{search}%");
                        cmd.Parameters.AddWithValue("@BrandName", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Start", start);
                        cmd.Parameters.AddWithValue("@Limit", limit);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                           while(reader.Read())
                            {
                                var obj = new Product();
                                obj.ProductID = reader.GetInt32("id");
                                obj.ProductName = reader.GetString("productName").ToUpper();
                                obj.Brand= reader.GetString("brand").ToUpper();
                                obj.Category = reader.GetString("category").ToUpper();
                                obj.ReOrderLevel = reader.GetDouble("reorder");
                                obj.UnitCode = reader.GetString("unitCode");
                                obj.Qty = reader.GetInt32("qty");
                                obj.HasExpiry = reader.GetBoolean("hasExpiry");
                                list.Add(obj);
                            }
                        }
                    }

                    //Get total rows
                    using (cmd = new MySqlCommand("SELECT COUNT(*) AS totalRows from tbl_product as p inner join tbl_brand as b on b.id = p.brandID inner join tbl_category as c on c.id = p.catID inner join units on units.id = p.ugID where p.deleted = false",con))
                    {
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                totalRows = rd.GetInt32("totalRows");
                        }
                    }

                    //Get Filtered Rows
                    using (cmd = new MySqlCommand("", con))
                    {
                        cmd.CommandText = "select count(*) as filteredRows from tbl_product as p inner join tbl_brand as b on b.id = p.brandID inner join tbl_category as c on c.id = p.catID inner join units on units.id = p.ugID where p.deleted = false and (p.productName LIKE @ProductName  or b.brand LIKE @BrandName or c.category LIKE @Category or p.catID LIKE  @CatID) order by p.productName ASC";
                        cmd.Parameters.AddWithValue("@CatID", $"%{search}%");
                        cmd.Parameters.AddWithValue("@ProductName", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Category", $"%{search}%");
                        cmd.Parameters.AddWithValue("@BrandName", $"%{search}%");

                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                filterRows = rd.GetInt32("filteredRows");
                        }
                    }
                }//Con

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }

        public Product getProduct(int id)
        {
            Product obj = new Product();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        MySqlTransaction transact = con.BeginTransaction();
                        cmd.CommandText = $"select * from tbl_product where id = {id}";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                obj.ProductID = reader.GetInt32("id");
                                obj.ProductName = reader.GetString("productName");
                                obj.ReOrderLevel = reader.GetDouble("reorder");
                                obj.HasExpiry = reader.GetBoolean("hasExpiry");
                                obj.DayBeforeExpiry = reader.GetInt32("dayBExpiry");
                                obj.BrandID = reader.GetInt32("brandID");
                                obj.UnitID = reader.GetInt32("ugID");
                                obj.CatID = reader.GetInt32("catID");
                            }
                        }

                        cmd.CommandText = $"select * from units where prodID = {obj.ProductID} ";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var unit = new UnitMeasurement();
                                unit.ugID = reader.GetInt32("id");
                                unit.id = reader.GetInt32("unitID");
                                unit.UnitCode = reader.GetString("unitCode");
                                unit.Qty = reader.GetDouble("qty");
                                unit.DefaultUnit = reader.GetBoolean("defaultUnit");
                                obj.UnitList.Add(unit);
                                if (unit.DefaultUnit)
                                    obj.UnitCode = unit.UnitCode;
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

        public bool hasDuplicate(int id, string ProductName)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("SELECT productName from tbl_product where productName = @ProductName and id != @Id", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@ProductName", ProductName);
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            
        }
    }

    class ProductValidator:AbstractValidator<Product>
    {
        ProductModel model = new ProductModel();
        public ProductValidator()
        {
            RuleFor(prod => prod.ProductName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("({PropertyName}) Field is Required.")
                .Must(hasDuplicate).WithMessage("({PropertyValue}) is already registered.");

            RuleFor(dbex => dbex.DayBeforeExpiry)
                .NotEmpty().When(hExp => hExp.HasExpiry);

            RuleFor(brand => brand.Brand)
                .NotEmpty();

            RuleFor(cat => cat.Category)
                .NotEmpty();

            //RuleFor(unit => unit.Unit.UnitCode)
            //    .NotEmpty().WithMessage("(Base Unit of Measurement) Field is Reqiured.");

            RuleFor(reorder => reorder.ReOrderLevel)
                .NotEmpty().WithMessage("({PropertyName}) Field is Required.");

        }


        protected bool hasDuplicate(Product obj, string ProductName)
        {
            return model.hasDuplicate(obj.ProductID, ProductName) ? false : true;
        }
    }

    public class Product:Supplier,IUnitMeasurement,ICategory,IBrand
    {
        public int ProductID { get; set; }
        public int BrandID { get; set; }
        public int CatID { get; set; }
        public string ProductName { get; set; }
        public bool HasExpiry { get; set; }
        public int DayBeforeExpiry { get; set; }
        public double ReOrderLevel { get; set; }

        public int UnitID { get; set; }
        public string UnitCode { get; set; }
        public string Description { get; set; }
       
        public int Qty { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public bool DefaultUnit { get; set; }

        public UnitMeasurement Unit = new UnitMeasurement();
        public List<UnitMeasurement> UnitList = new List<UnitMeasurement>();
    }

    
}
