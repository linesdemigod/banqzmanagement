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
        //property for the delete method
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public string gender { get; set; }
        public string idType { get; set; }
        public string idNumber { get; set; }
        public string dob { get; set; }
        public string accountNumber { get; set; }
        public string officer { get; set; }
        public string address { get; set; }
        public string guarantorFirstname { get; set; }
        public string guarantorLastname { get; set; }
        public string guarantorPhone { get; set; }
        public string guarantorAddress { get; set; }
        public string id { set; get; }

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


        //Delete client
        public void deleteClient()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM client WHERE client_id=@id";
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


        //Update
        public void updateClient()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string subsql = "SELECT officer_id FROM officer WHERE officer_uid = @officer";

                    cmd.CommandText = "UPDATE client SET officer_id=(" + subsql + "), client_fname = @firstname, client_lname=@lastname, client_dob = @dob, client_phone=@telephone, client_gender=@gender, client_address=@address, client_idtype = @idtype, client_idnumber = @idnumber, client_account_num = @accnumber, guarantor_fname = @gfirstname, guarantor_lname = @glastname, guarantor_phone = @gphone, guarantor_address = @gaddress  WHERE client_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@officer", MySqlDbType.VarChar).Value = officer;
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastName;
                    cmd.Parameters.Add("@dob", MySqlDbType.VarChar).Value = dob;
                    cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = telephone;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                    cmd.Parameters.Add("@idtype", MySqlDbType.VarChar).Value = idType;
                    cmd.Parameters.Add("@idnumber", MySqlDbType.VarChar).Value = idNumber;
                    cmd.Parameters.Add("@accnumber", MySqlDbType.VarChar).Value = accountNumber;
                    cmd.Parameters.Add("@gfirstname", MySqlDbType.VarChar).Value = guarantorFirstname;
                    cmd.Parameters.Add("@glastname", MySqlDbType.VarChar).Value = guarantorLastname;
                    cmd.Parameters.Add("@gphone", MySqlDbType.VarChar).Value = guarantorPhone;
                    cmd.Parameters.Add("@gaddress", MySqlDbType.VarChar).Value = guarantorAddress;
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
