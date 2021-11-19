using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class Settings : Database
    {

        public string company { get; set; }
        public string interest { get; set; }
        public string address { get; set; }
        public string phone { get; set; }


        //SEARCH USER 
        public void getCompany()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM company";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        company = rd.GetString("com_name");
                        interest = rd.GetString("com_interest_rate");
                        address = rd.GetString("com_address");
                        phone = rd.GetString("com_phone");

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


        //Update
        public void update_company()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE company SET  com_name = @name, com_interest_rate = @interest, com_address = @address, com_phone = @phone";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = company;
                    cmd.Parameters.Add("@interest", MySqlDbType.VarChar).Value = interest;
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
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
