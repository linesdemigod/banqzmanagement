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
    public partial class Contract : Form
    {
        Contracts contract = new Contracts();

        public Contract()
        {
            InitializeComponent();
        }

        //when the form load 
        private void Contract_Load(object sender, EventArgs e)
        {
            

            getRunningContracts(); //get running contract

            getExpiryContracts(); // get expiry contract

        }

        #region RUNNING CONTRACT
        //function to get the running contract to the datagrid
        private void getRunningContracts()
        {
            contract.getRunningContract();
            dataGridViewRunning.DataSource = contract.dt;
        }

        //search the running contract
        private void searchByAccountNumberRunning()
        {
            try
            {
                DataView dv = contract.dt.DefaultView;
                dv.RowFilter = string.Format(@"client_account_num LIKE '%" + txtRunningSearch.Text.Trim() + "%'");
                dataGridViewRunning.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //search the running contract by account number
        private void txtRunningSearch_TextChanged(object sender, EventArgs e)
        {
            searchByAccountNumberRunning();
        }
        #endregion END RUNNING CONTRACT

        #region EXPIRY CONTRACT
        private void getExpiryContracts()
        {
            contract.getExpiryContract();
            dataGridViewExpiry.DataSource = contract.dat;
        }

        //search the running contract
        private void searchByAccountNumberExpiry()
        {
            try
            {
                DataView dv = contract.dat.DefaultView;
                dv.RowFilter = string.Format(@"client_account_num LIKE '%" + txtSearchExpiry.Text.Trim() + "%'");
                dataGridViewExpiry.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //search the expiry contract by account number
        private void txtSearchExpiry_TextChanged(object sender, EventArgs e)
        {
            searchByAccountNumberExpiry();
        }

        #endregion END EXPIRY CONTRACT
    }
}
