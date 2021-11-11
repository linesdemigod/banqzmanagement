using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class Officers : Database
    {

        //property for the delete method
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
        public string status { get; set; }
        public string role { get; set; }
        public string id { set; get; }
        public string rol { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getOfficer()
        {
            dt.Clear();
            string sql = "SELECT officer.officer_id, officer.officer_fname, officer.officer_lname, officer.officer_phone, officer.officer_gender, officer.officer_dob, officer.officer_uid, officer.officer_password, role.role, officer.officer_status FROM officer INNER JOIN role USING (role_id)  WHERE officer.role_id = '3' OR officer.role_id = " + rol + "  OR officer.role_id = '2' ORDER BY officer_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //Delete officer
        public void deleteOfficer()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM officer WHERE officer_id=@id";
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
    }
}
