using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Jaezer_POS_and_Inventory.Model
{
    class BrandModel : DBConnection
    {

        public bool insert(Brand obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using(cmd = new MySqlCommand("INSERT into tbl_brand (brand) VALUES (@Brand)", con))
                    {
                        cmd.Parameters.AddWithValue("@Brand", obj.brand);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AppName);
                return false;
            }
        }

        public bool update(Brand obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (cmd = new MySqlCommand("UPDATE tbl_brand SET brand = @Brand WHERE id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@Brand", obj.brand);
                        cmd.Parameters.AddWithValue("@id", obj.id);
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
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (cmd = new MySqlCommand("UPDATE tbl_brand SET deleted = true WHERE id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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

        public bool delete_batch(List<int> _ids)
        {
            try
            {
                query = "UPDATE tbl_brand SET ";
                foreach (var id in _ids)
                    query += $"deleted = CASE WHEN id = {id} THEN true ELSE deleted END,";
                query = query.Remove(query.Length - 1, 1);
                query += $" WHERE id IN({string.Join(",", _ids)})";
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (cmd = new MySqlCommand(query, con))
                    {
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


        public bool hasDuplicate(int _id, string brandName)
        {
            try
            {
                if(_id == 0)
                {
                    query = "SELECT brand FROM tbl_brand where deleted = false and brand = @Brand";
                } else
                {
                    query = $"SELECT brand FROM tbl_brand where deleted = false and brand = @Brand and id != {_id}";
                }

                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("Brand", brandName);
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
                throw;
            }
        }


        public IList<Brand> getBrandList(string Search)
        {
            var list = new List<Brand>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using(cmd  = new MySqlCommand("SELECT id, brand FROM tbl_brand WHERE deleted = false AND brand LIKE @Brand ORDER BY brand ASC", con))
                    {
                        cmd.Parameters.AddWithValue("@Brand", $"%{Search}%");
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var obj = new Brand();
                                obj.id = reader.GetInt32("id");
                                obj.brand = reader.GetString("brand").ToUpper(); ;
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


    public class BrandValidator : AbstractValidator<Brand>
    {
        private BrandModel brandModel = new BrandModel();
        public BrandValidator()
        {
            RuleFor(obj => obj.brand)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("({PropertyName}) field is required.")
                .Must(hasDuplicate).WithMessage("{PropertyValue} is already registered.");

        }

        private bool hasDuplicate(Brand obj,string brandName)
        {
            return brandModel.hasDuplicate(obj.id, brandName) ? false : true;
        }
    }

    public class Brand
    {
        public int id { get; set; }
        public string brand { get; set; }
    }
}
