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
        public string idRepay { get; set; }

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        public DataTable dtaa = new DataTable();
        private DataSet dsaa = new DataSet();

        public DataTable dtas = new DataTable();
        private DataSet dsas = new DataSet();

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
            string sql = "SELECT fee_id, (" + subsql2 + ") AS Client, client_account_num, fee_purpose, amount, created_at, (" + subsql + ") AS Officer FROM loanfee  ORDER BY fee_id DESC";
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


        //READ REPAYMENT DATA
        public void getRepayment()
        {
            string subsql = "SELECT CONCAT(officer_fname, ' ', officer_lname) FROM officer WHERE officer_id = repayment.officer_id";

            string subsql2 = "SELECT CONCAT(client_fname, ' ', client_lname) FROM client WHERE client_account_num = repayment.client_account_num";
            dtaa.Clear();
            string sql = "SELECT repay_id, (" + subsql2 + ") AS Client, client_account_num, amount, outstanding, remark, created_at, (" + subsql + ") AS Officer FROM repayment  ORDER BY repay_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(dsaa);
            dtaa = dsaa.Tables[0];
        }


        //Delete repayment
        public void deleteRepayment()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM repayment WHERE repay_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idRepay;
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

        //READ REPAYMENT DATA
        public void getRepaymentHistory()
        {
            string subsql = "SELECT CONCAT(officer_fname, ' ', officer_lname) FROM officer WHERE officer_id = repaymenthistory.officer_id";

            string subsql2 = "SELECT CONCAT(client_fname, ' ', client_lname) FROM client WHERE client_account_num = repaymenthistory.client_account_num";
            dtas.Clear();
            string sql = "SELECT repayhistory_id, (" + subsql2 + ") AS Client, client_account_num, amount, outstanding, remark, created_at, (" + subsql + ") AS Officer FROM repaymenthistory  ORDER BY repayhistory_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(dsas);
            dtas = dsas.Tables[0];
        }

        //Delete repayment
        public void deleteRepaymentHistory()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM repaymenthistory WHERE repayhistory_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idRepay;
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
