using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class LoanFeeReports : Database
    {
        //for Loans
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //variables
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string getYear { get; set; }


        //query to get the loanfee from the db
        public void getLoanFeeReport()
        {
            string sql = "SELECT client_account_num AS 'Account Number', fee_purpose AS Purpose, amount As Amount FROM loanfee WHERE fee_purpose = 'Application' ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //filter the loan by date
        public void getLoanFeeReportFilter()
        {
            //string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT client_account_num AS 'Account Number', fee_purpose AS Purpose, amount As Amount FROM loanfee  WHERE fee_purpose = 'Application' AND created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE) ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void dailyReport()
        {
            string sql = "SELECT client_account_num AS 'Account Number', fee_purpose AS Purpose, amount As Amount FROM loanfee  WHERE fee_purpose = 'Application' AND date(created_at) = curdate() ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void weeklyReport()
        {
            string sql = "SELECT client_account_num AS 'Account Number', fee_purpose AS Purpose, amount As Amount FROM loanfee  WHERE fee_purpose = 'Application' AND WEEK(created_at) = WEEK(NOW()) ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void monthlyReport()
        {
            //string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT client_account_num AS 'Account Number', fee_purpose AS Purpose, amount As Amount FROM loanfee  WHERE fee_purpose = 'Application' AND MONTH(created_at) = MONTH(NOW()) ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void getReportByYear()
        {
            string sql = "SELECT client_account_num AS 'Account Number', fee_purpose AS Purpose, amount As Amount FROM loanfee  WHERE fee_purpose = 'Application' AND Year(created_at) = '" + getYear + "' ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
