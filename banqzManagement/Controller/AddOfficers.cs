using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class AddOfficers : Database
    {
        //property for the delete method
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
        public string status { get; set; }
        public string role { get; set; }
        public string id { set; get; }
        public string rol { get; set; }
        public string checkUid { get; set; }


        //check if the username exist
        public bool uidExist()
        {
            bool check = false;
            try
            {

                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM officer WHERE officer_uid = @username";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        check = true;
                        checkUid = rd.GetString("officer_uid");
                    }

                    conn.Close();
                }


            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return check;
        }


        //Insert the data to the database
        public void createUser()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT role_id FROM role WHERE role = @role";
                    cmd.CommandText = "INSERT INTO officer(role_id, officer_fname, officer_lname, officer_dob, officer_phone, officer_gender, officer_uid, officer_password, officer_status) VALUES((" + sql + "), @firstname, @lastname,@dob, @telephone, @gender, @username, @password, @status)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastName;
                    cmd.Parameters.Add("@dob", MySqlDbType.VarChar).Value = dob;
                    cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = telephone;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        //Get officer roles
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getRole()
        {
            dt.Clear();
            string sql = "SELECT * FROM role";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}
