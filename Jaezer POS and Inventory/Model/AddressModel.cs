using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Jaezer_POS_and_Inventory.Model
{
    class AddressModel:DBConnection
    {
        public IList<Province> GetProvince(string search)
        {
            var list = new List<Province>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("SELECT provCode, provDesc FROM refprovince WHERE provDesc LIKE @Province ORDER BY provDesc ASC", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@province", $"%{search}%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                var obj = new Province();
                                obj.ProvCode = reader.GetString("provCode");
                                obj.ProvDesc = reader.GetString("ProvDesc");
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

        public IList<CityMunicipality> GetCityMun(string provCode,string search)
        {
            var list = new List<CityMunicipality>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("SELECT citymunCode, citymunDesc FROM refcitymun WHERE provCode = @ProvCode  and citymunDesc LIKE @CityMun ORDER BY citymunDesc ASC", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@ProvCode", provCode);
                        cmd.Parameters.AddWithValue("@CityMun", $"%{search}%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var obj = new CityMunicipality();
                                obj.CityMunCode
                                    
                                    = reader.GetString("citymunCode");
                                obj.CityMunDesc = reader.GetString("citymunDesc");
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

        public IList<Barangay> GetBrgy(string citymunCode, string search)
        {
            var list = new List<Barangay>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("SELECT brgyCode, brgyDesc FROM refbrgy WHERE citymunCode = @CityMunCode AND brgyDesc LIKE @BrgyCode ORDER BY brgyDesc ASC", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@CityMunCode", citymunCode);
                        cmd.Parameters.AddWithValue("@BrgyCode", $"%{search}%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                var obj = new Barangay();
                                obj.BrgyCode = reader.GetString("brgyCode");
                                obj.BrgyDesc = reader.GetString("brgyDesc");
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


     class ProvinceValidator:AbstractValidator<Province>
    {
        public ProvinceValidator()
        {
            RuleFor(prov => prov.ProvDesc)
                .NotEmpty().WithMessage("Province field is required.");
        }
    }

    class CityMunValidator : AbstractValidator<CityMunicipality>
    {
        public CityMunValidator()
        {
            RuleFor(citymun => citymun.CityMunDesc)
                .NotEmpty().WithMessage("City/Municipality is required")
                .When(prov => !prov.hasProvince).WithMessage("Select Province First");
        }
    }

    class BarangayValidator:AbstractValidator<Barangay>
    {
        public BarangayValidator()
        {
            RuleFor(brgy => brgy.BrgyDesc)
                .NotEmpty().WithMessage("Barangay field is required")
                .When(citymun => !citymun.hasCityMunicipality).WithMessage("Select Province and City/Municipality First");

        }
    }
    public class Province
    {
        public string ProvCode { get; set; }
        public string ProvDesc { get; set; }
    }

    public class CityMunicipality
    {
        public string CityMunCode { get; set; }
        public string CityMunDesc { get; set; }
        public bool hasProvince { get; set; }
    }

    public class Barangay
    {
        public string BrgyCode { get; set; }
        public string BrgyDesc { get; set; }
        public bool hasCityMunicipality { get; set; }
    }
}
