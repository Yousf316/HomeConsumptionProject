using HomeC_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption
{
    public partial class ctrShowPerson : UserControl
    {
        public ctrShowPerson()
        {
            InitializeComponent();
        }
       public clsPerson obPerson {  get; set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadPersonInfo()
        {
            lbName.Text = obPerson.FullName;
           
            lbCountry.Text = clsCountry.FindCountry(obPerson.NationalityCountryID).CountryName;
            lbEmail.Text = obPerson.Email;
          
            lbPersonID.Text = obPerson.PersonID.ToString();
           
            lbPhone.Text = obPerson.PhoneNumber;

          
        }
        public void GetPersonInfo(int PersonID = -1)
        {
            if (PersonID == -1 || !clsPerson.IsPersonExsits(PersonID))
            {
                return;
            }
            else
            {
                this.obPerson = clsPerson.FindPerson(PersonID);
                LoadPersonInfo();
            }

        }

        public int GetPersonID()
        {
            return Convert.ToInt32(lbName.Text);
        }

        private void ctrShowPerson_Load(object sender, EventArgs e)
        {

        }

        private void lbCountry_Click(object sender, EventArgs e)
        {

        }

        private void lkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (obPerson == null)
                return;

            //Form frm = new frmAddUpdatePerson(obPerson.GetPersonID());
            //frm.ShowDialog();

            //GetPersonInfo(obPerson.GetPersonID());

        }
    }
}
