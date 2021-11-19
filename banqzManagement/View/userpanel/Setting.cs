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
    public partial class Setting : Form
    {

        Settings setting = new Settings();

        public Setting()
        {
            InitializeComponent();
        }

        //load to get company information
        private void Setting_Load(object sender, EventArgs e)
        {
            getCompanyInfo();
        }

        //get company information to the textbox
        private void getCompanyInfo()
        {
            setting.getCompany();
            txtCompanyName.Text = setting.company;
            txtCompanyAddress.Text = setting.address;
            txtCompanyPhone.Text = setting.phone;
            txtCompanyInterestRate.Text = setting.interest;
        }

        private void updateCompanyInfo()
        {
            setting.company = txtCompanyName.Text;
            setting.interest = txtCompanyInterestRate.Text;
            setting.address = txtCompanyAddress.Text;
            setting.phone = txtCompanyPhone.Text;

            if (txtCompanyName.Text == "" || txtCompanyAddress.Text == "" || txtCompanyPhone.Text == "" || txtCompanyInterestRate.Text == "")
            {
                MessageBox.Show("Please, Fill all field");

                return;
            }

            setting.update_company();

            MessageBox.Show("Update Successful");
        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            updateCompanyInfo();
        }

        private void getNumberDecimal (object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
