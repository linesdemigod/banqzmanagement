using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class Logins : Database
    {
        public string username { get; set; }
        public string password { get; set; }
        public int role { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }


        //Method to check and verify the data in the db
        public bool user_verification()
        {
            bool check = false;
            //open database connection


            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM officer WHERE officer_uid=@username AND officer_password=@password";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    check = true;
                    role = rd.GetInt32("role_id");
                    fname = rd.GetString("officer_fname");
                    lname = rd.GetString("officer_lname");
                    gender = rd.GetString("officer_gender");
                    phone = rd.GetString("officer_phone");
                }

                conn.Close();
            }



            return check;
        }
    }
}
