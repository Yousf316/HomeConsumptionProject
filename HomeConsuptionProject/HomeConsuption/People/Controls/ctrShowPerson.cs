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
            //lbName.Text = obPerson.GetFullName();
            //lbDateOfBirth.Text = obPerson.GetBirthDate().ToString("d");
            //lbAddress.Text = obPerson.GetAddress();
            //lbCountry.Text = clsCountry.FindCountries(obPerson.GetNationalityCountryID());
            //lbEmail.Text = obPerson.GetEmail(); 
            //lbNationalNo.Text = obPerson.GetNationalNo();
            //lbPersonID.Text=obPerson.GetPersonID().ToString();
            //lbGender.Text = obPerson.GetGenderName();
            //lbPhone.Text = obPerson.GetPhoneNumber();

            //if(obPerson.GetImagePath() !="")
            //pictureBox1.ImageLocation = obPerson.GetImagePath();
            //else
            //    pictureBox1.ImageLocation = obPerson.GetDefaultImage();
        }
        //public void GetPersonInfo(int PersonID=-1)
        //{
        //    if(PersonID == -1|| !clsPerson.IsExists(PersonID))
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        this.obPerson= clsPerson.FindPerson(PersonID);
        //        LoadPersonInfo();
        //    }
            
        //}

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
