using banqzManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banqzManagement.View.userpanel
{
    public partial class Client : Form
    {
        Clients client = new Clients();

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            getClientData();
            
        }

        
        private void getClientData()
        {
            try
            {
                client.getClient();
                dataGridViewClient.DataSource = client.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getClientData();
            
        }

        private void search()
        {
            try
            {
                DataView dv = client.dt.DefaultView;
                dv.RowFilter = string.Format(@"client_account_num LIKE '%" + txtSearch.Text.Trim() + "%' OR client_fname LIKE '%" + txtSearch.Text.Trim() + "%'");
                dataGridViewClient.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient client = new AddClient();
            client.ShowDialog();
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewClient.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewClient.Rows[e.RowIndex].Cells["ID"].Value);
                        client.id = id.ToString();
                        if (Convert.ToInt32(client.id) > 0)
                        {
                            //call the deleteUser method in the manageuser class
                            client.deleteClient();
                            MessageBox.Show("Client account deleted");
                        }

                    }
                }


                //code for the update
                if (dataGridViewClient.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    string id, officer, fname, lname, dob, phone, gender, address, idType, idNumber, accountNumber, gFirstname, gLastname, gPhone, gAddress;

                    id = dataGridViewClient.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    fname = dataGridViewClient.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
                    lname = dataGridViewClient.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
                    dob = dataGridViewClient.Rows[e.RowIndex].Cells["DOB"].Value.ToString();
                    phone = dataGridViewClient.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                    gender = dataGridViewClient.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                    address = dataGridViewClient.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                    idType = dataGridViewClient.Rows[e.RowIndex].Cells["IDType"].Value.ToString();
                    idNumber = dataGridViewClient.Rows[e.RowIndex].Cells["IDNumber"].Value.ToString();
                    accountNumber = dataGridViewClient.Rows[e.RowIndex].Cells["Account"].Value.ToString();
                    gFirstname = dataGridViewClient.Rows[e.RowIndex].Cells["GFirstname"].Value.ToString();
                    gLastname = dataGridViewClient.Rows[e.RowIndex].Cells["GLastname"].Value.ToString();
                    gPhone = dataGridViewClient.Rows[e.RowIndex].Cells["GPhone"].Value.ToString();
                    gAddress = dataGridViewClient.Rows[e.RowIndex].Cells["GAddress"].Value.ToString();
                    officer = dataGridViewClient.Rows[e.RowIndex].Cells["Officer"].Value.ToString();

                    UpdateClient user = new UpdateClient(id, officer, fname, lname, dob, phone, gender, address, idType, idNumber, accountNumber, gFirstname, gLastname, gPhone, gAddress);
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Error User002: Something went wrong");
            }
        }
    }
}
