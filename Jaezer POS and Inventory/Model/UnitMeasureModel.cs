using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FluentValidation;

namespace Jaezer_POS_and_Inventory.Model
{
    class UnitMeasureModel:DBConnection
    {

        public bool SetProductDefaultUnit(Product obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("",con))
                    {
                        con.Open();
                        MySqlTransaction transact = con.BeginTransaction();
                        cmd.CommandText = $"update tbl_unit_grp set defaultUnit = false where prodID = {obj.ProductID}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = $"update tbl_unit_grp set defaultUnit = true where id = {obj.UnitID}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = $"update tbl_product set ugID = {obj.UnitID} where id = {obj.ProductID}";
                        cmd.ExecuteNonQuery();
                        transact.Commit();
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
       public List<UnitMeasurement> ProductUnitList(int prodID)
        {
            var list = new List<UnitMeasurement>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"select * from units where prodID = {prodID}", con))
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                var obj = new UnitMeasurement();
                                obj.id = reader.GetInt32("id");
                                obj.UnitCode = reader.GetString("unitCode");
                                obj.Qty = reader.GetDouble("qty");
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
        public List<UnitMeasurement> getUnitMList(string search)
        {
            var list = new List<UnitMeasurement>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (cmd = new MySqlCommand("SELECT id, unitCode, unitDesc FROM tbl_unit where deleted = false and unitCode like @Search", con))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{search}%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var obj = new UnitMeasurement();
                                obj.id = reader.GetInt32("id");
                                obj.UnitCode = reader.GetString("unitCode").ToUpper();
                                obj.Description = reader.GetString("unitDesc").ToUpper();
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

        public int insert(Product obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("insert into tbl_unit_grp (unitID, prodID, qty) values (@UnitID, @ProdID, @Qty)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@UnitID", obj.Unit.id);
                        cmd.Parameters.AddWithValue("@ProdID", obj.ProductID);
                        cmd.Parameters.AddWithValue("@Qty", obj.Unit.Qty);
                        cmd.ExecuteNonQuery();
                        return (int)cmd.LastInsertedId;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public bool insert(List<UnitMeasurement> units)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    query = "INSERT INTO tbl_unit (unitCode, unitDesc) VALUES ";
                    int i = 0;
                    foreach(var un in units)
                    {
                        query += $"(@UnitCode{i}, @Desc{i}),";
                        i++;
                    }
                    query = query.Remove(query.Length - 1, 1);
                    using (cmd = new MySqlCommand(query,con))
                    {
                        i = 0;
                        foreach (var un in units)
                        {
                            cmd.Parameters.AddWithValue($"@UnitCode{i}", un.UnitCode);
                            cmd.Parameters.AddWithValue($"@Desc{i}", un.Description);
                            i++;
                        }
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"/n {query}", AppName);
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
                        query = "UPDATE tbl_units SET ";
                        foreach (var id in _ids)
                            query += $"deleted = CASE WHEN id = {id} THEN true ELSE deleted END,";
                        query = query.Remove(query.Length - 1, 1);
                        query += $" WHERE id IN ({string.Join(",",_ids)}) ";
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

        public bool delete(int id, string table)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"UPDATE {table} SET deleted = true where id = {id}", con))
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

        public bool update(UnitMeasurement unit)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"UPDATE tbl_unit_grp SET unitID = @UnitID, qty = @Qty where id = @UgID", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@UnitID", unit.id);
                        cmd.Parameters.AddWithValue("@Qty", unit.Qty);
                        cmd.Parameters.AddWithValue("@UgID",unit.ugID);
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
        public bool update(IEnumerable<UnitMeasurement> units)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    string unitCode = "unitCode = CASE ", desc = "unitDesc = CASE", qty = "qty = CASE";
                    List<int> _id = new List<int>();
                    int i = 0;
                    query = "update tbl_unit SET ";
                   
                   using (cmd = new MySqlCommand("",con))
                    {
                        con.Open();
                        foreach (var obj in units)
                        {
                            unitCode += $"  WHEN id = {obj.id} THEN @UnitCode{i}";
                            desc += $" WHEN id = {obj.id} THEN @Desc{i}";
                            qty += $" WHEN id = {obj.id} THEN @Qty{i}";
                            cmd.Parameters.AddWithValue($"@UnitCode{i}",obj.UnitCode);
                            cmd.Parameters.AddWithValue($"@Desc{i}",obj.Description);
                            cmd.Parameters.AddWithValue($"@Qty{i}",obj.Qty);
                            _id.Add(obj.id);
                            i++;
                        }
                        unitCode += " END,";
                        desc += " END,";
                        qty += " END";
                        query += $"{unitCode} {desc} {qty} WHERE id IN({string.Join(",",_id)})";
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

        public bool hasDuplicate(int _id, string _unitCode)
        {
            try
            {
                if (_id == 0)
                    query = "SELECT unitCode FROM tbl_unit WHERE unitCode = @UnitCode and deleted = false";
                else
                    query = $"SELECT unitCode FROM tbl_unit WHERE unitCode = @UnitCode and deleted = false and id != {_id}";
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UnitCode", _unitCode);
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

        public bool hasDuplicate(int _id, int _prodID, string _unitCode)
        {
            try
            {
                if (_id == 0)
                    query = $"SELECT unitCode FROM units WHERE unitCode = @UnitCode and prodID = {_prodID} and deleted = false";
                else
                    query = $"SELECT unitCode FROM units WHERE unitCode = @UnitCode and prodID = {_prodID} and deleted = false and id != {_id}";
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UnitCode", _unitCode);
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
    }
    class ProductUnitValidator:AbstractValidator<Product>
    {
        UnitMeasureModel model = new UnitMeasureModel();
        public ProductUnitValidator()
        {
            RuleFor(unit => unit.Unit.UnitCode)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithName("UnitCode")
                .Must(hasDuplicate).WithMessage("UnitCode {PropertyValue} is already registered.");
            RuleFor(qty => qty.Unit.Qty)
                .NotEmpty().WithName("Qty");
        }

        private bool hasDuplicate(Product obj, string unitCode)
        {
            return model.hasDuplicate(obj.Unit.ugID, obj.ProductID, unitCode) ? false : true;
        }

    }
    class UnitMeasurementValidator : AbstractValidator<UnitMeasurement>
    {
        private UnitMeasureModel uModel = new UnitMeasureModel();
        public UnitMeasurementValidator()
        {
            RuleFor(units => units.UnitCode)
              .Cascade(CascadeMode.StopOnFirstFailure)
              .NotEmpty().WithMessage("{PropertyName} Field required.")
              .Must(hasDuplicate).WithMessage("{PropertyValue} already registered");
            RuleFor(units => units.Description)
                .NotEmpty().WithMessage("{PropertyName} is required");
           

        }


        private bool hasDuplicate(UnitMeasurement u, string _UnitCode)
        {
            return uModel.hasDuplicate(u.id, _UnitCode) ? false:true;
        }
    }

    public class CollUnitMeaseurementValidator:AbstractValidator<UnitMCollection>
    {
        private UnitMeasureModel uModel = new UnitMeasureModel();
        public CollUnitMeaseurementValidator()
        {

            RuleForEach(x => x.units)
                .SetValidator(new UnitMeasurementValidator());
        }

    }

    public class UnitMCollection
    {
       public List<UnitMeasurement> units = new List<UnitMeasurement>();
    }
    public class UnitMeasurement
    {
        public int ugID { get; set; }
        public int id { get; set; }
        public string UnitCode { get; set; }
        public string Description { get; set; }
        public double Qty { get; set;}
        public bool DefaultUnit { get; set; }
    }


    
}
