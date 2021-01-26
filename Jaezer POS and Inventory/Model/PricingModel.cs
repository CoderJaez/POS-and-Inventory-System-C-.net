using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FluentValidation;
using System.Windows.Forms;

namespace Jaezer_POS_and_Inventory.Model
{
    class PricingModel:ProductModel
    {
        private PriceItemCollection PriceCollection = new PriceItemCollection();

        public new bool delete(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_pricing set deleted = true where id = {id} ", con))
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
        public bool insert(PriceItem obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        query = "INSERT INTO tbl_pricing (barcode, variant, prodID, ugID, price) VALUES  (@Barcode, @Variant, @ProdID, @UnitID, @Price)";
                        cmd.Parameters.AddWithValue($"@Barcode", obj.Barcode);
                        cmd.Parameters.AddWithValue($"@Variant", obj.Variant);
                        cmd.Parameters.AddWithValue($"@ProdID", obj.ProductID);
                        cmd.Parameters.AddWithValue($"@UnitID", obj.UnitID);
                        cmd.Parameters.AddWithValue($"@Price", obj.Price);
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

        public PriceItem GetPriceItem(int id)
        {
            var obj = new PriceItem();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"select * from tbl_pricing where id = {id} ", con))
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                obj.priceID = reader.GetInt32("id");
                                obj.Barcode = reader.GetString("barcode");
                                obj.Variant = reader.GetString("variant");
                                obj.Price = reader.GetDouble("price");
                                obj.UnitID = reader.GetInt32("ugID"); 

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

        public bool update(PriceItem obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("update tbl_pricing set barcode = @Barcode, variant = @Variant, prodID = @ProdID, ugID = @UnitID, price = @Price where id = @Id", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Barcode", obj.Barcode);
                        cmd.Parameters.AddWithValue("@Variant", obj.Variant);
                        cmd.Parameters.AddWithValue("@ProdID", obj.ProductID);
                        cmd.Parameters.AddWithValue("@UnitID", obj.UnitID);
                        cmd.Parameters.AddWithValue("@Id", obj.priceID);
                        cmd.Parameters.AddWithValue("@Price", obj.Price);
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
        public PriceItemCollection GetPriceList(int prodID)
        {
            var list = new PriceItemCollection();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"select tbl_pricing.*, units.unitCode from tbl_pricing inner join units on units.id = tbl_pricing.ugID where tbl_pricing.deleted = false and tbl_pricing.prodID = {prodID}", con))
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                var obj = new PriceItem();
                                obj.priceID = reader.GetInt32("id");
                                obj.Barcode = reader.GetString("barcode").ToUpper();
                                obj.Variant = reader.GetString("variant").ToUpper();
                                obj.UnitID= reader.GetInt32("id");
                                obj.UnitCode = reader.GetString("unitCode");
                                obj.Price = reader.GetDouble("price");
                                list.PriceList.Add(obj);
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

        public bool HasDuplicate(int id, string variant)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select variant from tbl_pricing where (variant = @Variant OR Barcode = @Barcode) and id != @ID", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Variant", variant);
                        cmd.Parameters.AddWithValue("@Barcode", variant);
                        cmd.Parameters.AddWithValue("@ID", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "sadas");
                return false;
            }
        }
    }

    public class PriceItemValidator:AbstractValidator<PriceItem>
    {
        PricingModel model = new PricingModel();
        public PriceItemValidator()
        {
            RuleFor(variant => variant.Variant)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("({PropertyName}) Field is Required")
                .Must(HasDuplicate).WithMessage("The {PropertyName} with value of ({PropertyValue}) is already registered");
            RuleFor(barcode => barcode.Barcode)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("({PropertyName}) Field is Required")
                .Must(HasDuplicate).WithMessage(" The {PropertyName} with value of ({PropertyValue}) is already registered");

            RuleFor(price => price.Price)
                .NotEmpty().WithMessage("({PropertyName}) Field is Required");
            RuleFor(unit => unit.UnitCode)
                .NotEmpty().WithMessage("({PropertyName}) Field is Required");
           
        }

        protected bool HasDuplicate(PriceItem obj, string variant)
        {
            return model.HasDuplicate(obj.priceID, variant) ? false : true;
        }
    }

    public class PriceItemCollValidator:AbstractValidator<PriceItemCollection>
    {
        public PriceItemCollValidator()
        {
            RuleForEach(items => items.PriceList)
                .SetValidator(new PriceItemValidator());
        }
    }

    public class PriceItemCollection
    {
        public List<PriceItem> PriceList = new List<PriceItem>();
    }

    public class PriceItem:Product
    {

       public int priceID { get; set; }
        public string Barcode { get; set; }
        public string Variant { get; set; }
        public double Price { get; set; }

    }

   
}
