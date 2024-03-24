using HomeC_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption
{
    public partial class frmManageUsers : Form
    {
        enum enMode
        {
            OnlyNumber,None
        }

        enMode _mode = enMode.None;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void RefreshUsersList()
        {
            //dataGridView1.DataSource = clsUser.GetAllUsers();
            RefreshRecordCount();
        }
        private void RefreshRecordCount()
        {
            lbRecordsCount.Text = dataGridView1.Rows.Count.ToString();
           
        }

        private void SearchOperator()
        {

            if (_mode == enMode.OnlyNumber)
            {

                if (!int.TryParse(txtSearch.Text, out int PersonID))
                {
                    txtSearch.Text = "";
                    return;
                }

                //dataGridView1.DataSource = clsUser.GetUserInfo(cmbFinds.SelectedItem.ToString(), txtSearch.Text);

            }
            else
            {
                //dataGridView1.DataSource = clsUser.GetUserInfo(cmbFinds.SelectedItem.ToString(), txtSearch.Text);
            }

            RefreshRecordCount();
        }

        private void cmbFinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUsersList();
            comboBox1.Visible = false;
            if (cmbFinds.SelectedItem.ToString() == "None")
            {
                txtSearch.Visible = false;
                
                return;
            }

            txtSearch.Visible = true;

            switch(cmbFinds.SelectedItem.ToString())
            {
                case "PersonID":
                   
                case "UserID":
                    _mode = enMode.OnlyNumber;
                    break;
                case "UserName":
                   
                case "IsActive":
                    _mode = enMode.None;
                    txtSearch.Visible = false;
                    comboBox1.Visible = true;
                    comboBox1.SelectedIndex = 0;
                    break;
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchOperator();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frm=new frmAddUpdateUsers();
            frm.ShowDialog();
            RefreshUsersList();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            cmbFinds.SelectedIndex = 0;
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frm = new frmAddUpdateUsers();
            frm.ShowDialog();
            RefreshUsersList();
        }

        private void editePersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frm = new frmAddUpdateUsers((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshUsersList();

        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are You sure to delete " + ID + " ", "Confirm", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }


            //if (clsUser.DeleteUser(ID))
            //{
            //    MessageBox.Show("Delete Succssfully");
            //    RefreshUsersList();
            //}
            //else
            //{
            //    MessageBox.Show("User was not Deleted becouse it hase Data Linked to it");
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                RefreshUsersList();
                return;
            }


            if (comboBox1.SelectedIndex == 1)
            {
                //dataGridView1.DataSource = clsUser.GetUserInfo(cmbFinds.SelectedItem.ToString(), "1");

            }else if(comboBox1.SelectedIndex == 2)
            {
                //dataGridView1.DataSource = clsUser.GetUserInfo(cmbFinds.SelectedItem.ToString(), "0");
            }

           
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frmShowUserInfo = new frmShowUserInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frmShowUserInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchangePassword frmchangePassword1 = new frmchangePassword((int)dataGridView1.CurrentRow.Cells[0].Value);
            frmchangePassword1.ShowDialog();
            RefreshUsersList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
