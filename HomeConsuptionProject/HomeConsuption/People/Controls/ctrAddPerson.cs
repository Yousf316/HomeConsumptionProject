using System;
using System.ComponentModel;

using System.Windows.Forms;
using System.IO;
using HomeC_Business;
namespace HomeConsuption
{
    public partial class ctrAddPerson : UserControl
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        public event Action<bool> OnCloseButton;
        // Create a protected method to raise the event with a parameter
        protected virtual void _OnCloseButton(bool Exsits)
        {
            Action<bool> handler = OnCloseButton;
            if (handler != null)
            {
                handler(Exsits); // Raise the event with the parameter
            }
        }

        public event Action<bool> OnSaveButton;
        // Create a protected method to raise the event with a parameter
        protected virtual void _OnSaveButton(bool Exsits)
        {
            Action<bool> handler = OnSaveButton;
            if (handler != null)
            {
                handler(Exsits); // Raise the event with the parameter
            }
        }
        public ctrAddPerson()
        {
            InitializeComponent();
        }

        clsPerson _perons { get; set; }
        int _Gender { get; set; }
        
        int _NationalityCountryID { get; set; }

        string _pre_NationalNo { get; set; }
        string _PathUserImage { get; set; }

        enum enMode { New,Update}
        enMode _mode = enMode.New;
        public void SetPersonID (int PersonID=-1)
        {
            if (PersonID == -1 || clsPerson.IsPersonExsits(PersonID) == false)
            {
                this._perons = new clsPerson();
                LoadDefault();
                _mode = enMode.New;
            }
            else
            {
                this._perons = clsPerson.FindPerson(PersonID);
                GetPersonInfo();
                _mode = enMode.Update;
            }
        }

        private void GetAllCountries()
        {
            //DataTable dt = clsCountry.GetAllCountries();
            //cmbCountry.Items.Clear();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    cmbCountry.Items.Add(dr[1].ToString());
            //}
            //cmbCountry.SelectedItem = "Yemen";


          
        }

        private void GetPersonInfo()
        {
            


           


            txtFirstName.Text = this._perons.FirstName;
            txtSecondName.Text = this._perons.SecondName;
            txtThirdName.Text = this._perons.ThirdName;
            txtLastName.Text = this._perons.LastName;

            txtPhone.Text = this._perons.PhoneNumber;
            txtEmail.Text = this._perons.Email;



           
           

        }

        private void LoadDefault()
        {

            GetAllCountries();
           

        
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       
        private void ctrAddPerson_Load(object sender, EventArgs e)
        {

            SetPersonID(-1);
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void SetDefaultImage()
        {

           
        }
        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool IsSucceed = false;

            SetPathUserImage();
            this._perons.SetValues(txtFirstName.Text,txtSecondName.Text,txtThirdName.Text,txtLastName.Text,txtPhone.Text,txtEmail.Text,1);
            
            
            

                if (this._perons.SavePeople())
                {
                    MessageBox.Show("Success");
                    lbPersonID.Text = this._perons.PersonID.ToString();
                    SetPersonID(this._perons.PersonID);
                    this._mode = enMode.Update;
                    IsSucceed = true;
                    DataBack?.Invoke(this, this._perons.PersonID);
                }

            
            if (OnSaveButton != null)
                _OnSaveButton(IsSucceed);
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Trim();

            if (txt.Text == "")
            {
                errorProvider1.SetError(txt, "this filed is request!");
                
            }
            else
            {
                errorProvider1.SetError(txt, "");
            }
        }

        
        private void cmbCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCountry_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this._NationalityCountryID = clsCountry.GetCountryID(cmbCountry.SelectedItem.ToString());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (OnCloseButton != null)
                _OnCloseButton(true);

        }

        private void lkbSetPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            
            
        }

        private void SetPathUserImage()
        {
           
        }
       
      
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail .Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "write a correct email");

            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Trim();

            if (txt.Text == "")
            {
                errorProvider1.SetError(txt, "this filed is request!");
               
            }
            else
            {
                errorProvider1.SetError(txt, "");
               
                 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
