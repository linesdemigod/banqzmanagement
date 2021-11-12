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
    }
}
