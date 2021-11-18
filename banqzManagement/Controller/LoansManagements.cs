using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class LoansManagements : Database
    {
        public string id { get; set; }
        public string idFee { get; set; }

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        //Get the loan from the database
        public void getLoans()
        {
            string subsql = "SELECT CONCAT(officer_fname, ' ', officer_lname) FROM officer WHERE officer_id = loaninfo.officer_id";
            string subsql2 = "SELECT CONCAT(client_fname, ' ', client_lname) FROM client WHERE client_account_num = loaninfo.client_account_num";
            dt.Clear();
            string sql = "SELECT loan_id, (" + subsql2 + ") AS Client, client_account_num, amount_disbursed, interest, loan_duration, interest_amount_disbursed, date_disbursed, date_expiry, (" + subsql+ ") AS Officer FROM loaninfo ORDER BY loan_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //Delete client
        public void deleteLoan()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM loaninfo WHERE loan_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

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

        //READ LOAN FEE DATA
        public void getLoanFee()
        {
            string subsql = "SELECT CONCAT(officer_fname, ' ', officer_lname) FROM officer WHERE officer_id = loanfee.officer_id";

            string subsql2 = "SELECT CONCAT(client_fname, ' ', client_lname) FROM client WHERE client_account_num = loanfee.client_account_num";
            dat.Clear();
            string sql = "SELECT fee_id,(" + subsql2 + ") AS Client, client_account_num, fee_purpose, amount, (" + subsql + ") AS Officer FROM loanfee ORDER BY fee_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }


        //Delete client
        public void deleteLoanFee()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM loanfee WHERE fee_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idFee;
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
