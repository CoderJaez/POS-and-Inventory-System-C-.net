using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Jaezer_POS_and_Inventory.View.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jaezer_POS_and_Inventory.Model
{
    public class CategoryModel:DBConnection
    {
        public bool deleteCategory(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE tbl_category set deleted = true where id = @id", con))
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

        public bool delete_batch(List<int> _id)
        {
            try
            {
                query = "UPDATE tbl_category SET ";
                foreach (var id in _id)
                    query += $"deleted  = CASE WHEN id = {id} THEN true else deleted END,";
                query = query.Remove(query.Length - 1, 1);
                query += $" WHERE id IN ({string.Join(",",_id)})";
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
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public bool updateCategpry(Category cat)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    using ( cmd = new MySqlCommand("UPDATE tbl_category set category = @Category where id = @id",con))
                    {
                        cmd.Parameters.AddWithValue("@Category", cat.category);
                        cmd.Parameters.AddWithValue("@id", cat.id);
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
        public bool insertCategory(Category cat)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();

                    using ( cmd = new MySqlCommand("INSERT INTO tbl_category (category) VALUES (@Category)", con))
                    {
                        cmd.Parameters.AddWithValue("@Category", cat.category);
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

        public bool isCatRegistered(int id, string category)
        {
            try
            {
                if (id == 0)
                {
                    query = "SELECT category from tbl_category WHERE category = @Category and deleted = false";
                } else
                {
                    query = $"SELECT category from tbl_category WHERE category = @Category and deleted = false and id != {id}";

                }
                using (MySqlConnection con = new MySqlConnection(ConnString))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Category",category);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ ex.Message} /n Check Duplication");
                return false;
            }
        }

        public IList<Category> getCategory(string search)
        {
            var catList = new List<Category>();
            try
            {
                using(MySqlConnection con = new MySqlConnection(ConnString))
                {
                    con.Open();
                    using( cmd = new MySqlCommand("SELECT id,category FROM tbl_category where deleted = false AND category like @Category ORDER BY category ASC", con))
                    {
                        cmd.Parameters.AddWithValue("@Category", $"%{search}%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var obj = new Category();
                                obj.id = reader.GetInt32("id");
                                obj.category = reader.GetString("category").ToUpper();
                                catList.Add(obj);
                            }
                            
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return catList;
        }
    }

    class CategoryValidator : AbstractValidator<Category>
    {
        CategoryModel catModel = new CategoryModel();
        public CategoryValidator()
        {
            RuleFor(cat => cat.category)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("({PropertyName}) is required")
                .Length(4, 50).WithMessage("Length ({TotalLength}) of {PropertyName} Invalid")
                .Must(isDuplicate).WithMessage("{PropertyValue} is already registered");
        }


        protected bool isValidCategory(string course)
        {
            course = course.Replace(" ", "");
            return course.All(char.IsLetter);
        }

        protected bool isDuplicate(Category obj,string category)
        {
            return catModel.isCatRegistered(obj.id, category)?false:true;
        }
    }

    public class Category 
    {
        public int id { get; set; }
        public string category { get; set; }
    }
}
