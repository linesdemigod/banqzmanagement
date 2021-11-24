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
            string sql = "SELECT a.client_account_num AS 'Account Number', t.amount AS Repayment, a.outstanding As Outstanding, a.remark AS Remark, t.date FROM repayment a JOIN(SELECT client_account_num, MAX(created_at) AS date, SUM(amount) AS amount FROM repayment GROUP BY client_account_num) AS t ON a.client_account_num = t.client_account_num AND a.created_at = t.date";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //filter the loan by date
        public void getRepaymentReportFilter()
        {
            //string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT dd.client_account_num AS 'Account Number', dd.amount AS Repayment, dd.outstanding AS Outstanding, dd.remark AS Remark, dd.created_at AS date FROM (SELECT client_account_num, sum(amount) as Amount, max(created_at) as MaxTime FROM repayment GROUP BY client_account_num) r INNER JOIN repayment dd ON dd.client_account_num = r.client_account_num AND dd.created_at = r.MaxTime INNER JOIN (select client_account_num, sum(amount) as Amount from repayment group by client_account_num) as a ON r.Amount = a.Amount AND r.client_account_num = a.client_account_num WHERE created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE)";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void dailyReport()
        {
            string sql = "SELECT dd.client_account_num AS 'Account Number', dd.amount AS Repayment, dd.outstanding AS Outstanding, dd.remark AS Remark, dd.created_at AS date FROM (SELECT client_account_num, sum(amount) as Amount, max(created_at) as MaxTime FROM repayment GROUP BY client_account_num) r INNER JOIN repayment dd ON dd.client_account_num = r.client_account_num AND dd.created_at = r.MaxTime INNER JOIN (select client_account_num, sum(amount) as Amount from repayment group by client_account_num) as a ON r.Amount = a.Amount AND r.client_account_num = a.client_account_num WHERE date(created_at) = curdate()";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void weeklyReport()
        {
            string sql = "SELECT dd.client_account_num AS 'Account Number', dd.amount AS Repayment, dd.outstanding AS Outstanding, dd.remark AS Remark, dd.created_at AS date FROM (SELECT client_account_num, sum(amount) as Amount, max(created_at) as MaxTime FROM repayment GROUP BY client_account_num) r INNER JOIN repayment dd ON dd.client_account_num = r.client_account_num AND dd.created_at = r.MaxTime INNER JOIN (select client_account_num, sum(amount) as Amount from repayment group by client_account_num) as a ON r.Amount = a.Amount AND r.client_account_num = a.client_account_num WHERE WEEK(created_at) = WEEK(NOW())";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void monthlyReport()
        {

            string sql = "SELECT dd.client_account_num AS 'Account Number', dd.amount AS Repayment, dd.outstanding AS Outstanding, dd.remark AS Remark, dd.created_at AS date FROM (SELECT client_account_num, sum(amount) as Amount, max(created_at) as MaxTime FROM repayment GROUP BY client_account_num) r INNER JOIN repayment dd ON dd.client_account_num = r.client_account_num AND dd.created_at = r.MaxTime INNER JOIN (select client_account_num, sum(amount) as Amount from repayment group by client_account_num) as a ON r.Amount = a.Amount AND r.client_account_num = a.client_account_num WHERE MONTH(created_at) = MONTH(NOW())";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void getReportByYear()
        {
            string sql = "SELECT dd.client_account_num AS 'Account Number', dd.amount AS Repayment, dd.outstanding AS Outstanding, dd.remark AS Remark, dd.created_at AS date FROM (SELECT client_account_num, sum(amount) as Amount, max(created_at) as MaxTime FROM repayment GROUP BY client_account_num) r INNER JOIN repayment dd ON dd.client_account_num = r.client_account_num AND dd.created_at = r.MaxTime INNER JOIN (select client_account_num, sum(amount) as Amount from repayment group by client_account_num) as a ON r.Amount = a.Amount AND r.client_account_num = a.client_account_num WHERE Year(created_at) = '" + getYear + "'";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
