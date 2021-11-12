using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqzManagement.Controller
{
    class AddClients : Database
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
        public string rol { get; set; }
        public string checkAccountNumber { get; set; }




        //check if the account number exist
        public bool accountNumberExist()
        {
            bool check = false;
            try
            {

                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM client WHERE client_account_num = @account";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@account", MySqlDbType.VarChar).Value = accountNumber;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        check = true;
                        checkAccountNumber = rd.GetString("client_account_num");
                    }

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

            return check;
        }


        //Insert the data to the database
        public void createUser()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT officer_id FROM officer WHERE officer_uid = @officer";
                    cmd.CommandText = "INSERT INTO client(officer_id, client_fname, client_lname, client_dob, client_phone, client_gender, client_address, client_idtype, client_idnumber, client_account_num, guarantor_fname, guarantor_lname, guarantor_phone, guarantor_address) VALUES((" + sql + "), @firstname, @lastname,@dob, @telephone, @gender, @address, @idtype, @idnumber, @accnumber, @gfirstname, @glastname, @gphone, @gaddress)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
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
