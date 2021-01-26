using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Jaezer_POS_and_Inventory.Model
{
    public class ExpenseModel:DBConnection
    {

        public List<Expenses> GetAllExpenses(string dateFrom, string dateTo)
        {
            var list = new List<Expenses>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        cmd.CommandText = $"select * from expenses where deleted = false and edate between '{dateFrom}' and '{dateTo}' order by edate desc, description ASC";
                        con.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                list.Add(new Expenses {
                                    Id = rd.GetInt32("id"),
                                    ExpID = rd.GetInt32("expID"),
                                    Description = rd.GetString("description"),
                                    Amount = rd.GetDecimal("amount"),
                                    Date = rd.GetDateTime("edate").ToString("yyyy-MM-dd"),
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
            return list;
        }
        public bool deleteExpense(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_expenses set deleted = true where id = {id}", con))
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
        public bool updateExpense(Expenses obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("update tbl_expenses set expID = @ExpID, amount = @Amount, userID = @UserID where id = @ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ExpID", obj.ExpID);
                        cmd.Parameters.AddWithValue("@Amount", obj.Amount);
                        cmd.Parameters.AddWithValue("@ID", obj.Id);
                        cmd.Parameters.AddWithValue("@UserID", obj.UserID);
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
        public bool insertExpense(Expenses obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("insert into tbl_expenses (expID, amount, edate, userID) values(@ExpID, @Amount,@Date, @UserID)", con))
                    {
                        cmd.Parameters.AddWithValue("@ExpID", obj.ExpID);
                        cmd.Parameters.AddWithValue("@Amount", obj.Amount);
                        cmd.Parameters.AddWithValue("@UserID", obj.UserID);
                        cmd.Parameters.AddWithValue("@Date", obj.Date);
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
        public bool insert(Expenses obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("insert into tbl_expenses_cat (description) values(@Description)", con))
                    {
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
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

        public bool delete(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_expenses_cat set deleted = true where id = {id}", con))
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
        public bool update(Expenses obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_expenses_cat set description = @Description where id = {obj.Id}", con))
                    {
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
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
            

        public List<Expenses> GetAll(string search)
        {
            var list = new List<Expenses>();
            using (con = new MySqlConnection(ConnString))
            {
                using (cmd = new MySqlCommand("select description, id from tbl_expenses_cat where deleted = false and description LIKE @Description", con))
                {
                    cmd.Parameters.AddWithValue("@Description", $"%{search}%");
                    con.Open();
                    using (MySqlDataReader rd = cmd.ExecuteReader())
                    {
                        while(rd.Read())
                        {
                            list.Add(new Expenses { Id = rd.GetInt32("id"), Description = rd.GetString("description") });
                        }
                    }
                }
            }

            return list;
        }
        public bool hasDuplicate(int id, string data)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("SELECT description from tbl_expenses_cat where description = @Description and id != @Id", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Description", data);
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


    public class ExpenseValidator:AbstractValidator<Expenses>
    {
        public ExpenseValidator()
        {
            RuleFor(exp => exp.Description)
                .NotEmpty().WithName("Expenses");

            RuleFor(amnt => amnt.Amount)
                 .NotEmpty();
        }
    }
    public class ExpensesValidator:AbstractValidator<Expenses>
    {
        public ExpensesValidator()
        {
            RuleFor(exp => exp.Description)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithName("Expenses")
                .Must(hasDuplicate).WithMessage("{PropertyValue} is already registered.");
        }

        private bool hasDuplicate(Expenses obj, string expenses)
        {
            return new ExpenseModel().hasDuplicate(obj.Id, expenses) ? false : true;
        }
    }

    public class Expenses
    {
        public int Id { get; set; }
        public int ExpID { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
