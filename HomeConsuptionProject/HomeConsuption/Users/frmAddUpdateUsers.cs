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
    public partial class frmAddUpdateUsers : Form
    {
        private int _UserID {  get; set; }
        private string _UserName {  get; set; }
        private int _PersonID {  get; set; }
        private string _Password {  get; set; }
        private bool _IsActive {  get; set; }

        clsUser user { get; set; }
        public frmAddUpdateUsers(int UserID=-1)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private bool SaveUser()
        {
           if(user == null)
                user = new clsUser();

            string HashPassword = clsValidatoin.HashCodeCompute(txtPassword.Text);

            if(HashPassword != user.Password)
            {
                MessageBox.Show("كلمة المرور غير مطابقة", "فشلت العملية",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }    

            user.SetValues(_PersonID, txtUserName.Text, HashPassword, chkIsActive.Checked);
            
                if (user.SaveUsers())
                {
                    _UserID = user.UserID;
                    return true;
                }

            

            return false;
        }
        private void SetUserInfo()
        {


            if(_IsActive)
            {
               chkIsActive.Checked = true;
            }
            else
            {
                chkIsActive.Checked = false;
            }

            txtUserName.Text = _UserName;
            txtPassword.Text = _Password;
            txtConfirmPassword.Text = _Password;
            lbUserID.Text = _UserID.ToString();
            ctrShowPeopleWithSearch1.SetPersonInfoLock(_PersonID);

        }
        private bool GetUserInfo()
        {
             user = clsUser.FindUser(_UserID);

            if(user == null)
                return false;

            this._UserID = user.UserID;
          //  this._Password = user.GetPassword();
            this._IsActive = user.IsActive;
            this._PersonID = user.PersonID;
            this._UserName = user.UserName;

            
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled=false;
            linkLabel1.Visible = true;
            SetUserInfo();
            return true;
        }
     

        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
           if( GetUserInfo())
            {
                lbTitle.Text = "تحديث بيانات المستخدم";
            }
            else
            {
                ctrShowPeopleWithSearch1.SetPersonInfoLock(-1);
                lbTitle.Text = "اضافة مستخدم جديد";
            
            }

            this.Text = lbTitle.Text;
        }

        private void ctrShowPeopleWithSearch1_OnButtonSet(int PersonID)
        {

            if (clsUser.IsExist(PersonID))
            {
                MessageBox.Show("Person already has user");
            }
            else
            {

                _PersonID = PersonID;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Not Match");
            }else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

     

      
      

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmchangePassword frmchangePassword = new frmchangePassword(this._UserID);
            frmchangePassword.ShowDialog();

        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjbtnSave_Click(object sender, EventArgs e)
        {

            if (SaveUser())
            {
                if (GetUserInfo())
                {
                    MessageBox.Show("Add User Successfuly", "Success");
                    lbTitle.Text = "Update User";
                }
            }
        }

        private void rjbtnNext_Click(object sender, EventArgs e)
        {
            tabctr1.SelectedIndex = 1;
        }

      
    }
}
