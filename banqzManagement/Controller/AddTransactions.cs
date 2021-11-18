using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class AddTransactions : Database
    {
       
        public string getAmount { get; set; }
        public string account { get; set; }
        public string id { get; set; }
        public string officer { get; set; }
        public string purpose { get; set; }
        public string amount { get; set; }
        public string accNum { get; set; }


        public void checkForTransfer()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT fee_id, amount FROM loanfee WHERE client_account_num = @account AND fee_purpose = 'Collateral' ORDER BY fee_id DESC LIMIT 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@account", MySqlDbType.VarChar).Value = account;
                rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {

                    getAmount = rd.GetString("amount");
                    id = rd.GetString("fee_id");
                }
            }
            conn.Close();
        }


        //Update
        public void updateLoanFee()
        {
            
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string subsql = "SELECT officer_id FROM officer WHERE officer_uid = @officer";

                    cmd.CommandText = "UPDATE loanfee SET officer_id = ("+subsql+ "), client_account_num = @account, fee_purpose = @purpose, amount=@amount WHERE client_account_num = @accountNum AND fee_id = @id AND fee_purpose = 'Collateral'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@officer", MySqlDbType.VarChar).Value = officer;
                    cmd.Parameters.Add("@account", MySqlDbType.VarChar).Value = account;
                    cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = purpose;
                    cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;
                    cmd.Parameters.Add("@accountNum", MySqlDbType.VarChar).Value = accNum;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            
           

        }


    }
}
