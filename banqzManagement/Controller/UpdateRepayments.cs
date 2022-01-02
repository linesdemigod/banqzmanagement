using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class UpdateRepayments : Database
    {
        public string id { get; set; }
        public string amount { get; set; }
        public string outstanding { get; set; }
        public string officer { get; set; }

        //Update
        public void updateRepayment()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string subsql = "SELECT officer_id FROM officer WHERE officer_uid = @officer";

                    cmd.CommandText = "UPDATE repayment SET officer_id = ("+subsql+"), amount = @amount, outstanding = @outstanding WHERE repay_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@officer", MySqlDbType.VarChar).Value = officer;
                    cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;
                    cmd.Parameters.Add("@outstanding", MySqlDbType.VarChar).Value = outstanding;
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
