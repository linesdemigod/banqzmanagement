using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class Profiles : Database
    {
        public string password { get; set; }
        public string id { get; set; }


        //Update
        public void updatePassword()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE officer SET officer_password = @password WHERE officer_uid=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
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
    }
}
