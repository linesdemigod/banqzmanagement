using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class Clients : Database
    {

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getClient()
        {
            dt.Clear();
            string subsql = "SELECT CONCAT(officer_fname, ' ', officer_lname) FROM officer WHERE officer_id = client.officer_id";

            string sql = "SELECT client_id, client_fname, client_lname, client_dob, client_phone, client_gender,client_address, client_idtype, client_idnumber, client_account_num, guarantor_fname, guarantor_lname, guarantor_phone, guarantor_address, (" + subsql + ") AS Officer FROM client ORDER BY client_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}
