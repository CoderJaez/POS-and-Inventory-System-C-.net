using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using FluentValidation;
namespace Jaezer_POS_and_Inventory.Model
{
    class SupplierModel:DBConnection
    {

        public IList<Supplier> GetSupplier(string _search)
        {
            var list = new List<Supplier>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("",con))
                    {
                        con.Open();
                        cmd.CommandText = "SELECT tbl_supplier.id, tbl_supplier.businessName, tbl_supplier.supplierName, tbl_supplier.contact, tbl_supplier.address, refbrgy.brgyDesc, refcitymun.citymunDesc, refprovince.provDesc FROM tbl_supplier INNER JOIN refbrgy ON refbrgy.`brgyCode` = tbl_supplier.`brgyCode` INNER JOIN refcitymun ON refcitymun.`citymunCode` = tbl_supplier.`citymunCode` INNER JOIN refprovince ON refprovince.`provCode` = tbl_supplier.`provCode` where tbl_supplier.deleted = false AND (tbl_supplier.businessName LIKE @BusinessName OR tbl_supplier.supplierName LIKE @SupplierName) ORDER BY businessName ASC";
                        cmd.Parameters.AddWithValue("@BusinessName", $"%{_search}%");
                        cmd.Parameters.AddWithValue("@SupplierName", $"%{_search}%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var obj = new Supplier();
                                obj.SupplierID = reader.GetInt32("id");
                                obj.BusinessName = reader.GetString("businessName");
                                obj.SupplierName = reader.GetString("supplierName");
                                obj.ContactNo = reader.GetString("contact");
                                obj.StreetAddress = reader.GetString("address");
                                obj.brgy.BrgyDesc = reader.GetString("brgyDesc");
                                obj.citymun.CityMunDesc = reader.GetString("citymunDesc");
                                obj.prov.ProvDesc = reader.GetString("provDesc");
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

        public bool delete(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"UPDATE tbl_supplier SET deleted = true where id = {id}", con))
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

        public bool delete(List<int> _ids)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        query = "UPDATE tbl_supplier SET ";
                        foreach (var id in _ids)
                        {
                            query += $"deleted = CASE WHEN id = {id} THEN true ELSE deleted END,";
                        }
                        query = query.Remove(query.Length - 1, 1);
                        query += $" WHERE id IN({string.Join(",", _ids)})";
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }
        public Supplier LoadSupplierInfo(int id)
        {
            var obj = new Supplier();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"SELECT tbl_supplier.*, b.brgyDesc, c.citymunDesc, p.provDesc FROM tbl_supplier INNER JOIN refprovince AS p ON p.provCode = tbl_supplier.provCode INNER JOIN refcitymun AS c ON c.citymunCode = tbl_supplier.citymunCode INNER JOIN refbrgy AS b ON b.brgyCode = tbl_supplier.brgyCode where tbl_supplier.id = {id} ", con))
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while ( reader.Read())
                            {
                                obj.SupplierID = reader.GetInt32("id");
                                obj.BusinessName = reader.GetString("businessName");
                                obj.SupplierName = reader.GetString("supplierName");
                                obj.ContactNo = reader.GetString("contact");
                                obj.StreetAddress = reader.GetString("address");
                                obj.brgy.BrgyCode = reader.GetString("brgyCode");
                                obj.brgy.hasCityMunicipality = true;
                                obj.brgy.BrgyDesc = reader.GetString("brgyDesc");
                                obj.citymun.CityMunCode = reader.GetString("citymunCode");
                                obj.citymun.CityMunDesc = reader.GetString("citymunDesc");
                                obj.citymun.hasProvince = true;
                                obj.prov.ProvCode = reader.GetString("provCode");
                                obj.prov.ProvDesc = reader.GetString("provDesc");
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

        public bool hasDuplicate(int id, string searchItem)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("SELECT businessName FROM tbl_supplier WHERE businessName = @BusinessName and id != @Id and deleted = false", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@BusinessName", searchItem);
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
                return false;
            }
        }

        public bool insert(Supplier obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        cmd.CommandText = "INSERT INTO tbl_supplier (businessName, supplierName, contact, address, brgyCode, citymunCode, provCode) values (@BusinessName, @SupplierName, @ContactNo, @StreetAddress, @BrgyCode, @CityMunCode, @ProvCode)";
                        cmd.Parameters.AddWithValue("@BusinessName", obj.BusinessName);
                        cmd.Parameters.AddWithValue("@SupplierName", obj.SupplierName);
                        cmd.Parameters.AddWithValue("@ContactNo",obj.ContactNo);
                        cmd.Parameters.AddWithValue("@StreetAddress",obj.StreetAddress);
                        cmd.Parameters.AddWithValue("@BrgyCode",obj.brgy.BrgyCode);
                        cmd.Parameters.AddWithValue("@CityMunCode",obj.citymun.CityMunCode);
                        cmd.Parameters.AddWithValue("@ProvCode",obj.prov.ProvCode);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
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
                        cmd.CommandText = "UPDATE tbl_supplier SET supplierName = @SupplierName, businessName = @BusinessName, contact = @ContactNo, address = @StreetAddress, brgyCode = @BrgyCode, citymunCode = @CityMunCode, provCode = @ProvCode WHERE id = @ID";
                        cmd.Parameters.AddWithValue("@BusinessName", obj.BusinessName);
                        cmd.Parameters.AddWithValue("@SupplierName", obj.SupplierName);
                        cmd.Parameters.AddWithValue("@ContactNo", obj.ContactNo);
                        cmd.Parameters.AddWithValue("@StreetAddress", obj.StreetAddress);
                        cmd.Parameters.AddWithValue("@BrgyCode", obj.brgy.BrgyCode);
                        cmd.Parameters.AddWithValue("@CityMunCode", obj.citymun.CityMunCode);
                        cmd.Parameters.AddWithValue("@ProvCode", obj.prov.ProvCode);
                        cmd.Parameters.AddWithValue("@ID", obj.SupplierID);
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

    public class SupplierValidator : AbstractValidator<Supplier>
    {
        SupplierModel model = new SupplierModel();
        public SupplierValidator()
        {
            RuleFor(bName => bName.BusinessName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} field is required.")
                .Must(hasDuplicate).WithMessage("{PropertyName} ({PropertyValue}) is already registered");

            RuleFor(sName => sName.SupplierName)
                .NotEmpty().WithMessage("{PropertyName} field is required");

            RuleFor(contact => contact.ContactNo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} field is required")
                .Length(9, 12).WithMessage("{PropertyName} is not valid.");

            RuleFor(brgy => brgy.brgy)
                .SetValidator(new BarangayValidator());

            RuleFor(citymun => citymun.citymun)
                .SetValidator(new CityMunValidator());

            RuleFor(prov => prov.prov)
                .SetValidator(new ProvinceValidator());
        }

        protected bool hasDuplicate(Supplier obj, string val)
        {
            return model.hasDuplicate(obj.SupplierID, val) ? false : true;
        }



    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string BusinessName { get; set; }
        public string SupplierName { get; set; }
        public string ContactNo { get; set; }
        public string StreetAddress { get; set; }
        public Barangay brgy = new Barangay();
        public CityMunicipality citymun = new CityMunicipality();
        public Province prov = new Province();
        public decimal Vat { get; set; }
        public string CompleteAddress { get { return $"{StreetAddress}, {brgy.BrgyDesc}, {citymun.CityMunDesc}"; } }
        public byte[] logo { get; set; }
    }
}
