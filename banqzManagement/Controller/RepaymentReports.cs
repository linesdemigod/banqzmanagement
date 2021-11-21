using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class RepaymentReports : Database
    {

        //for Loans
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //variables
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string getYear { get; set; }

        //query to get the loans from the db
        public void getRepaymentReport()
        {
            string sql = "SELECT DISTINCT client_account_num AS 'Account Number', SUM(amount) AS Repayment, MIN(outstanding) As Outstanding, Remark AS Remark FROM repayment GROUP BY client_account_num";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //filter the loan by date
        public void getRepaymentReportFilter()
        {
            //string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT DISTINCT client_account_num AS 'Account Number', SUM(amount) AS Repayment, MIN(outstanding) As Outstanding, Remark AS Remark FROM repayment WHERE created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE) GROUP BY client_account_num";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void dailyReport()
        {
            string sql = "SELECT DISTINCT client_account_num AS 'Account Number', SUM(amount) AS Repayment, MIN(outstanding) As Outstanding, Remark AS Remark FROM repayment WHERE date(created_at) = curdate() GROUP BY client_account_num";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void weeklyReport()
        {
            string sql = "SELECT DISTINCT client_account_num AS 'Account Number', SUM(amount) AS Repayment, MIN(outstanding) As Outstanding, Remark AS Remark FROM repayment WHERE WEEK(created_at) = WEEK(NOW()) GROUP BY client_account_num";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void monthlyReport()
        {

            string sql = "SELECT DISTINCT client_account_num AS 'Account Number', SUM(amount) AS Repayment, MIN(outstanding) As Outstanding, Remark AS Remark FROM repayment WHERE MONTH(created_at) = MONTH(NOW()) GROUP BY client_account_num";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void getReportByYear()
        {
            string sql = "SELECT DISTINCT client_account_num AS 'Account Number', SUM(amount) AS Repayment, MIN(outstanding) As Outstanding, Remark AS Remark FROM repayment WHERE Year(created_at) = '" + getYear + "' GROUP BY client_account_num";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
