using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class Contracts : Database
    {

        public string id { get; set; }
        public string idFee { get; set; }
        public string idRepay { get; set; }

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();
        

        //Get the running contract from the database
        public void getRunningContract()
        {
           
            string subsql2 = "SELECT CONCAT(client_fname, ' ', client_lname) FROM client WHERE client_account_num = loaninfo.client_account_num";
            dt.Clear();
            string sql = "SELECT (" + subsql2 + ") AS Client, client_account_num, amount_disbursed, interest, loan_duration, interest_amount_disbursed, date_disbursed, MAX(date_expiry) AS DateExpiry FROM loaninfo WHERE date_expiry > now() GROUP BY client_account_num ORDER BY loan_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //Get the Expiry contract from the database
        public void getExpiryContract()
        {

            string subsql2 = "SELECT CONCAT(client_fname, ' ', client_lname) FROM client WHERE client_account_num = loaninfo.client_account_num";
            dat.Clear();
            string sql = "SELECT (" + subsql2 + ") AS Client, client_account_num, amount_disbursed, interest, loan_duration, interest_amount_disbursed, date_disbursed, MAX(date_expiry) AS DateExpiry FROM loaninfo WHERE date_expiry < now() GROUP BY client_account_num ORDER BY loan_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }
    }
}
