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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HomeConsuption
{
    public partial class ctrManagePeople : UserControl
    {

        enum enMode { None,PersonID , NationalNo,
            FirstName,SecondName,ThirdName,
            LastName,Address,Email,Phone,DateOfBirth,Gendor}

        enMode _mode = enMode.None;
        public ctrManagePeople()
        {
            InitializeComponent();
        }

        private void SetRecordCount()
        {
            lbRecordsCount.Text = dataGridView1.RowCount.ToString();
        }
        private void RefreshSelectAllPeople()
        {
            dataGridView1.DataSource = clsPerson.GetAllPeople();
            SetRecordCount();
        }
        private void ctrManagePeople_Load(object sender, EventArgs e)
        {
           cmbFinds.SelectedIndex = 0;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            //frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            //frm.ShowDialog();
            //RefreshSelectAllPeople();
        }
        private void SearchOpreator()
        {

            if(_mode == enMode.PersonID|| _mode == enMode.Phone)
            {

              if(  !int.TryParse(txtSearch.Text, out int PersonID))
                {
                    txtSearch.Text = "";
                    return;
                }

               //dataGridView1.DataSource= clsPerson.GetPersonInfo(_mode.ToString(), txtSearch.Text);

            }else
            {
                //dataGridView1.DataSource = clsPerson.GetPersonInfo(_mode.ToString(),txtSearch.Text);
            }

            SetRecordCount();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            SearchOpreator();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshSelectAllPeople();
            dateTimePicker1.Visible = false;
            if (cmbFinds.SelectedItem.ToString() == "None")
            {
                txtSearch.Visible = false;
               
                return;
            }

            txtSearch.Visible = true;

            switch(cmbFinds.SelectedItem.ToString())
            {
                case "PersonID":
                    _mode = enMode.PersonID;
                    break;
                case "NationalNo":
                    _mode = enMode.NationalNo;
                    break;
                case "FirstName":
                    _mode = enMode.FirstName;
                    break;
                case "SecondName":
                    _mode = enMode.SecondName;
                        break;
                case "ThirdName":
                    _mode = enMode.ThirdName;
                    break;
                case "LastName":
                    _mode = enMode.LastName;
                    break;
                case "Email":
                    _mode = enMode.Email;
                    break;
                case "Phone":
                    _mode = enMode.Phone;
                    break;
                case "Address":
                    _mode= enMode.Address;
                    break;
                case "Gendor":
                    _mode = enMode.Gendor;
                    break;
                case "DateOfBirth":
                    _mode= enMode.DateOfBirth;
                    
                    dateTimePicker1.Visible = true;
                    dateTimePicker1.MaxDate= DateTime.Today.AddYears(-18); ;

                    break;  



            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = clsPerson.GetPersonInfo(_mode.ToString(), dateTimePicker1.Value.ToString("yyyy-M-dd"));
            SetRecordCount();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmShowPersonDetails frm=new frmShowPersonDetails(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            //frm.ShowDialog();
            //RefreshSelectAllPeople();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAddUpdatePerson frm=new frmAddUpdatePerson(-1);
            //frm.ShowDialog();
            //RefreshSelectAllPeople();
        }

        private void editePersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAddUpdatePerson frm = new frmAddUpdatePerson(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            //frm.ShowDialog();
            //RefreshSelectAllPeople();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are You sure to delete "+ID+" ","Confirm",MessageBoxButtons.OKCancel)!=DialogResult.OK)
            {
                return;
            }


           if( clsPerson.DeletePerson(ID) )
            {
                MessageBox.Show("Delete Succssfully");
                RefreshSelectAllPeople() ;  
            }
            else
            {
                MessageBox.Show("Person was not Deleted becouse it hase Data Linked to it");
            }
            
        }


    }
}
