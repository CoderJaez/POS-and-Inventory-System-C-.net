using System;
using System.Collections.Generic;
using FluentValidation;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jaezer_POS_and_Inventory.Model
{
    class UserModel:DBConnection
    {
        public List<IUser> GetUser(string search)
        {
            var list = new List<IUser>();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("select id, username, fullname, usertype, status from tbl_user where deleted = false and username != 'jaezer' and (username like @Username or fullname like @Fullname or usertype like @Usertype) order by username asc, fullname asc", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Username", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Fullname", $"%{search}%");
                        cmd.Parameters.AddWithValue("@Usertype", $"%{search}%");
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                var obj = new User();
                                obj.UserID = rd.GetInt32("id");
                                obj.UserName = rd.GetString("username");
                                obj.Fullname = rd.GetString("fullname");
                                obj.Status = rd.GetBoolean("status");
                                obj.UserType = rd.GetString("usertype");
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
        public bool Insert(User obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("insert into tbl_user (username, password,fullname, usertype) values (@Username, @Password, @Fullname, @Usertype)",con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Username", obj.UserName);
                        cmd.Parameters.AddWithValue("@Password", obj.Password);
                        cmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                        cmd.Parameters.AddWithValue("@Usertype", obj.UserType);
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

        public bool UpdateStatus(int id, bool status)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_user set status = {status} where id = {id}", con))
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

        public bool Delete(int id)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_user set deleted = true where id = {id}", con))
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
        public bool ChangePassword(User obj)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"update tbl_user set password = @NewPassword where id = {obj.UserID}", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@NewPassword", obj.NewPassword);
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

        public bool HasUserDuplicate(int id, string username)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand("", con))
                    {
                        con.Open();
                        if (id == 0)
                            query = "select username from tbl_user where username = @Username and deleted = false";
                        else
                            query = $"select username from tbl_user where username = @Username and id != {id} and deleted = false";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Username", username);
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            return rd.HasRows;
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

        public bool IsPasswordMatch(int id, string password)
        {
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"select username from tbl_user where password = @Password and id = {id} ", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Password", password);
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            return rd.HasRows;
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

        public User IsAccountMatch(string Uname, string Pass)
        {
            var obj = new User();
            try
            {
                using (con = new MySqlConnection(ConnString))
                {
                    using (cmd = new MySqlCommand($"select * from tbl_user where username =@Username and password = @Password and deleted = false  ", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Password", Pass);
                        cmd.Parameters.AddWithValue("@Username", Uname);

                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                           while(rd.Read())
                            {
                                obj.UserID = rd.GetInt32("id");
                                obj.UserName = rd.GetString("username");
                                obj.Fullname = rd.GetString("fullname");
                                obj.Status = rd.GetBoolean("status");
                                obj.UserType = rd.GetString("usertype");
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

        
    }

    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(uname => uname.UserName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Must(Hasduplicate).WithMessage("The {PropertyValuue} is already registered");
            RuleFor(fname => fname.Fullname)
                .NotEmpty();
            RuleFor(utype => utype.UserType)
                .NotEmpty();
                
        }

        private bool Hasduplicate(User obj, string value)
        {
            var model = new UserModel();
            return model.HasUserDuplicate(obj.UserID, value) ? false : true;
        }

        
    }

    
    public class ChangePassValidator:AbstractValidator<User>
    {
        public ChangePassValidator()
        {
            RuleFor(pass => pass.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Must(CheckOldPass).WithMessage("Old {PropertyName} is Incorrect");

            RuleFor(npass => npass.NewPassword)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .MinimumLength(5);

            RuleFor(cpass => cpass.ConfirmNewPassword)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .MinimumLength(5)
                .Equal(cpass => cpass.NewPassword).WithMessage("{PropertyName} does not matched");

        }

        private bool CheckOldPass(User obj, string pass)
        {
            var model = new UserModel();
            return model.IsPasswordMatch(obj.UserID, pass);
        }
    }


    public class UserAuthValidator:AbstractValidator<User>
    {
        public UserAuthValidator()
        {
            RuleFor(uname => uname.UserName)
                .NotEmpty();

            RuleFor(pass => pass.Password)
                .NotEmpty();
                
        }
        
    }


    public class User : IUser
    {
        public bool Status
        {
            get;
            set;
        }

        public int UserID
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }
        public string Fullname { get; set; }
        public string Password
        {
            get;
            set;
        }

        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
        public string UserType
        {
            get;
            set;
          
        }
    }
}
