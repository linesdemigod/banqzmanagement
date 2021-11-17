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

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getLoans()
        {
            string subsql = "SELECT CONCAT(officer_fname, ' ', officer_lname) FROM officer WHERE officer_id = loaninfo.officer_id";
            dt.Clear();
            string sql = "SELECT loan_id, client_account_num, amount_disbursed, interest, loan_duration, interest_amount_disbursed, date_disbursed, date_expiry, ("+subsql+") AS Officer FROM loaninfo ORDER BY loan_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
