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
        public string officer { get; set; }
        public string amount { get; set; }
        public string interest { get; set; }
        public string duration { get; set; }
        public string dateStart { get; set; }
        public string interestAmount { get; set; }
        public string dateExpiry { get; set; }
        public string outstanding { get; set; }
        public string getOutstanding { get; set; }

        //SEARCH Client
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


        //get the interest rate
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

        public void insertNewLoan()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT officer_id FROM officer WHERE officer_uid = @officer";
                    cmd.CommandText = "INSERT INTO loaninfo(officer_id, client_account_num, amount_disbursed, interest, loan_duration, date_disbursed, interest_amount_disbursed, date_expiry) VALUES(("+sql+"), @account, @amount, @interest, @duration, @datestart, @interestamount, @dateend)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@officer", MySqlDbType.VarChar).Value = officer;
                    cmd.Parameters.Add("@account", MySqlDbType.VarChar).Value = account;
                    cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;
                    cmd.Parameters.Add("@interest", MySqlDbType.VarChar).Value = interest;
                    cmd.Parameters.Add("@duration", MySqlDbType.VarChar).Value = duration;
                    cmd.Parameters.Add("@datestart", MySqlDbType.VarChar).Value = dateStart;
                    cmd.Parameters.Add("@interestamount", MySqlDbType.VarChar).Value = interestAmount;
                    cmd.Parameters.Add("@dateend", MySqlDbType.VarChar).Value = dateExpiry;
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

        public void insertToRepayment()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT officer_id FROM officer WHERE officer_uid = @officer";
                    cmd.CommandText = "INSERT INTO repayment(officer_id, client_account_num, amount, outstanding) VALUES((" + sql + "), @account, @amount, @outstanding)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@officer", MySqlDbType.VarChar).Value = officer;
                    cmd.Parameters.Add("@account", MySqlDbType.VarChar).Value = account;
                    cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;
                    cmd.Parameters.Add("@outstanding", MySqlDbType.VarChar).Value = outstanding;
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


        public void checkForOutstanding()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT outstanding FROM repayment WHERE client_account_num = @account";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@account", MySqlDbType.VarChar).Value = account;
                rd = cmd.ExecuteReader();
                if (rd.Read() == true)
                {

                    getOutstanding = rd.GetString("outstanding");
                }
            }
            conn.Close();
        }

       
    }
}
