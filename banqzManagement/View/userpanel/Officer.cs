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
    public partial class Officer : Form
    {
        //instance of Officers
        Officers office = new Officers();

        public Officer()
        {
            InitializeComponent();
        }

        //method to put the data to the gridviewdata
        public void getUsersData()
        {
            office.rol = Login.Login_role;

            office.getOfficer();

            dataGridViewOfficer.DataSource = office.dt;
        }

        private void Officer_Load(object sender, EventArgs e)
        {
            getUsersData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getUsersData();
        }

        private void btnAddOfficer_Click(object sender, EventArgs e)
        {
            AddOfficer officer = new AddOfficer();
            officer.ShowDialog();
        }
    }
}
