using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
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
            //if(PersonID==-1||clsPerson.IsExists(PersonID)==false)
            //{
            //    this._perons = new clsPerson();
            //    LoadDefault();
            //    _mode = enMode.New;
            //}
            //else 
            //{
            //    this._perons = clsPerson.FindPerson(PersonID);
            //    GetPersonInfo();
            //    _mode = enMode.Update;
            //}
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
           // this._Gender = this._perons.GetGender();

           // if(_Gender ==0 ) 
           //     rdbMale.Checked = true;
           // else
           //     rdbFemal.Checked = true;


           // rtbAddress.Text=this._perons.GetAddress();
            

           // txtFirstName.Text  = this._perons.GetFirstName();
           // txtSecondName.Text = this._perons.GetSecondName();
           // txtThirdName.Text  = this._perons.GetThirdName();
           // txtLastName.Text   = this._perons.GetLastName();

           // txtPhone.Text = this._perons.GetPhoneNumber();
           // txtEmail.Text = this._perons.GetEmail();
           // _pre_NationalNo= txtNationalNo.Text = this._perons.GetNationalNo();

           // dtpBirthday.Value = this._perons.GetBirthDate();


           // this._NationalityCountryID =this._perons.GetNationalityCountryID();
           //cmbCountry.SelectedItem= clsCountry.FindCountries(this._perons.GetNationalityCountryID());
           // lbPersonID.Text=this._perons.GetPersonID().ToString();

           // if(this._perons.GetImagePath()==""|| this._perons.GetImagePath() ==null)
           // {
           //     SetDefaultImage();
           // }
           // else
           // {
           //     pictureBox1.ImageLocation = this._perons.GetImagePath();
           //     lkRemoveImage.Visible = true;
               
           // }
           
        }

        private void LoadDefault()
        {

            dtpBirthday.MaxDate = DateTime.Today.AddYears(-18);
            GetAllCountries();
            pictureBox1.ImageLocation = "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_man.png";

            rdbMale.Checked = true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtNationalNo_Leave(object sender, EventArgs e)
        {
            if(_mode==enMode.Update)
            {
                if(this._pre_NationalNo==txtNationalNo.Text)
                {
                    errorProvider1.SetError(txtNationalNo, "");
                    return;
                }
            }


            //if (clsPerson.IsExists(txtNationalNo.Text))
            //{

            //    errorProvider1.SetError(txtNationalNo, "the National is most not exsits");

            //}
            //else
            //{
            //    errorProvider1.SetError(txtNationalNo, "");
            //}

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

            if (rdbFemal.Checked)
            {
                if (pictureBox1.ImageLocation == "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_man.png" || pictureBox1.ImageLocation == null)
                    pictureBox1.ImageLocation = "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_girl.png";

                this._Gender = 1;
            }
            else
            {
                if (pictureBox1.ImageLocation == "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_girl.png" || pictureBox1.ImageLocation == null)
                    pictureBox1.ImageLocation = "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_man.png";

                this._Gender = 0;
            }

        }
        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           //bool IsSucceed =false;

           // SetPathUserImage();
           //if (!this._perons.SetPersoninfo(txtNationalNo.Text,txtFirstName.Text,txtSecondName.Text
           //    ,txtThirdName.Text,txtLastName.Text,dtpBirthday.Value,this._Gender,rtbAddress.Text
           //    , txtPhone.Text,txtEmail.Text, _NationalityCountryID, _PathUserImage))
           // {
           //     MessageBox.Show("fill info");
           //     IsSucceed = false;
           // }
           // else
           // {

           //    if( this._perons.SavePeople())
           //     {
           //         MessageBox.Show("Success");
           //         lbPersonID.Text= this._perons.GetPersonID().ToString();
           //         SetPersonID(this._perons.GetPersonID());
           //         this._mode = enMode.Update;
           //         IsSucceed = true;
           //         DataBack?.Invoke(this, this._perons.GetPersonID());
           //     }

           // }
           // if (OnSaveButton != null)
           //     _OnSaveButton(IsSucceed);
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

        private void rtbAddress_TextChanged(object sender, EventArgs e)
        {
            
            if (rtbAddress.Text == "")
            {
                errorProvider1.SetError(rtbAddress, "this filed is request!");

            }
            else
            {
                errorProvider1.SetError(rtbAddress, "");
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
            openFileDialog1.ShowDialog();
            
            
        }

        private void SetPathUserImage()
        {
            if(IsDefaultImage())
            {
                _PathUserImage = "";
            }
            else
            {
                _PathUserImage = pictureBox1.ImageLocation;
            }
        }
        private bool IsDefaultImage ()
        {
            if (pictureBox1.ImageLocation != "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_man.png"
                    && pictureBox1.ImageLocation != "C:\\Users\\USERZ\\Desktop\\DVLD Project\\Icons\\person_girl.png")
            {
              
                return false;
            }
           
            return true;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string Path_img;
            
                if(!IsDefaultImage())
                {
                    File.Delete(pictureBox1.ImageLocation);
                }
            
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            try
            {
                Guid newGuid = Guid.NewGuid();
                File.Copy(pictureBox1.ImageLocation, Path_img= Path.Combine("C:\\Users\\USERZ\\Desktop\\DVLD Project\\PeopleImages", newGuid.ToString()+".png"));
                pictureBox1.ImageLocation = Path_img;
            }
            catch (DirectoryNotFoundException ex)
            {
                // Handle DirectoryNotFoundException
            }
            catch (IOException ex)
            {
                // Handle IOException
            }


            lkRemoveImage.Visible = true;
           
        }

        private void lkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string deletPath = pictureBox1.ImageLocation;
            if(!IsDefaultImage())
            {
                if(File.Exists(deletPath))
                File.Delete(deletPath);
                pictureBox1.ImageLocation = null;
                SetDefaultImage();

                SetPathUserImage();
                lkRemoveImage.Visible = false;


            }
            
            
            
            
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
    }
}
