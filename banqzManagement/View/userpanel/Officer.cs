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

        private void dataGridViewOfficer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewOfficer.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewOfficer.Rows[e.RowIndex].Cells["ID"].Value);
                        office.id = id.ToString();
                        if (Convert.ToInt32(office.id) > 0)
                        {
                            //call the deleteUser method in the manageuser class
                            office.deleteOfficer();
                            MessageBox.Show("User account deleted");
                        }

                    }
                }


                //code for the update
                if (dataGridViewOfficer.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    string id, role, fname, lname, dob, phone, gender, username, password, status;

                    id = dataGridViewOfficer.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    role = dataGridViewOfficer.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                    fname = dataGridViewOfficer.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
                    lname = dataGridViewOfficer.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
                    dob = dataGridViewOfficer.Rows[e.RowIndex].Cells["DoB"].Value.ToString();
                    phone = dataGridViewOfficer.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                    gender = dataGridViewOfficer.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                    username = dataGridViewOfficer.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                    password = dataGridViewOfficer.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    status = dataGridViewOfficer.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    UpdateOfficer user = new UpdateOfficer(id, role, fname, lname, dob, phone, gender, username, password, status);
                    user.ShowDialog();
                }
            }
            catch (Exception )
            {

                //MessageBox.Show("Error User002: Something went wrong");
            }
        }

        //refresh datagrid when user updated or deleted
        private void Officer_Activated(object sender, EventArgs e)
        {
            getUsersData();
        }

        private void dataGridViewOfficer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }
    }
}
