using HomeC_Business;
using HomeConsuption.People;
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
    public partial class ctrShowPeopleWithSearch : UserControl
    {

        public event Action<int> OnButtonSetPerson;
        // Create a protected method to raise the event with a parameter
        protected virtual void _OnButtonSetPerson(int PeronID)
        {
            Action<int> handler = OnButtonSetPerson;
            if (handler != null)
            {
                handler(PeronID); // Raise the event with the parameter
            }
        }

        public clsPerson obPerson { get {return ctrShowPerson1.obPerson; } }

        public ctrShowPeopleWithSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        private void Frm_DataBack(object sender, int PersonID)
        {
            SetPersonInfoLock(PersonID);
        }

        private void ctrShowPeopleWithSearch_Load(object sender, EventArgs e)
        {
            cmbFinds.SelectedIndex = 0;
        }

        private void SearchOperator()
        {

            if (cmbFinds.SelectedItem.ToString() == "الرقم الشخصي")
            {

                if (!int.TryParse(txtSearch.Text, out int PersonID))
                {
                    txtSearch.Text = "";
                    return;
                }
                if (clsPerson.IsPersonExsits(PersonID))
                {
                    ctrShowPerson1.GetPersonInfo(PersonID);


                    if (OnButtonSetPerson != null)
                        _OnButtonSetPerson(PersonID);

                }
                else
                {
                    MessageBox.Show("ID " + PersonID + " Is not Exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
           

        }

        public void SetPersonInfoLock(int PersonID)
        {
            if (clsPerson.IsPersonExsits(PersonID))
            {
                txtSearch.Text = PersonID.ToString();
                pnlSearchPerson.Enabled = false;
            }
            ctrShowPerson1.GetPersonInfo(PersonID);
        }

        public int GetPersonID()
        {
           return ctrShowPerson1.GetPersonID();
        }

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch(object sender, EventArgs e)
        {
            SearchOperator();


        }

        private void ctrShowPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
