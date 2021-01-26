using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FluentValidation;

namespace Jaezer_POS_and_Inventory.Model
{
    public class CompanyProfileModel:DBConnection
    {
        public bool updateVat(decimal vat)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_vat set vat = {vat}",con))
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
        public decimal getVal()
        {
            decimal vat = 0;
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select * from tbl_vat", con))
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                vat = reader.GetDecimal("vat");
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
        public Supplier getBusinessProfile()
        {
            var obj = new Supplier();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select * from tbl_profile", con))
                    {
                        con.Open();
                        using (MySqlDataReader  reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                obj.BusinessName = reader.GetString("businessName").ToUpper();
                                obj.StreetAddress = reader.GetString("streetAddress").ToUpper();
                                obj.brgy.BrgyDesc = reader.GetString("barangay").ToUpper();
                                obj.citymun.CityMunDesc = reader.GetString("citymun").ToUpper();
                                obj.ContactNo = reader.GetString("contact");
                                obj.logo = (byte[])reader["img"];
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

        public bool update(Supplier obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = "update tbl_profile set businessName = @BusinessName, streetAddress = @StreetAddress, barangay = @Barangay, citymun = @CityMun, province = @Province, contact = @Contact, img = @Logo";
                        cmd.Parameters.AddWithValue("@BusinessName", obj.BusinessName);
                        cmd.Parameters.AddWithValue("@StreetAddress", obj.StreetAddress);
                        cmd.Parameters.AddWithValue("@Barangay", obj.brgy.BrgyDesc);
                        cmd.Parameters.AddWithValue("@CityMun", obj.citymun.CityMunDesc);
                        cmd.Parameters.AddWithValue("@Province", obj.prov.ProvDesc);
                        cmd.Parameters.AddWithValue("@Contact", obj.ContactNo);
                        cmd.Parameters.AddWithValue("@Logo", obj.logo);
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
    }


    public class CompanyProfileValidator:AbstractValidator<Supplier>
    {
        public CompanyProfileValidator()
        {
            RuleFor(business => business.BusinessName)
                .NotEmpty();
            RuleFor(vat => vat.Vat)
                .NotEmpty();
        }
    }
}
