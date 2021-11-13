using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class Loans : Database
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string phone { get; set; }
        public string account { get; set; }
        public string interestRate { get; set; }

        //SEARCH USER 
        public void getAccountInfo()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT client_fname, client_lname, client_phone FROM client WHERE client_account_num=@account";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@account", MySqlDbType.VarChar).Value = account;
                rd = cmd.ExecuteReader();
                if (rd.Read() == true)
                {

                    fname = rd.GetString("client_fname");
                    lname = rd.GetString("client_lname");
                    phone = rd.GetString("client_phone");
                }
            }
            conn.Close();
        }

        public void getInterestRate()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT com_interest_rate FROM company";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        interestRate = rd.GetString("com_interest_rate");

                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
