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
    public partial class frmchangePassword : Form
    {
       
        string _CurrentPassword { get; set; }
        clsUser objUser1;
        public frmchangePassword(int UserID)
        {
            InitializeComponent();
           
            objUser1 = clsUser.FindUser(UserID);
        }

        private void GetUserPassword()
        {
            if (objUser1 != null)
            {
                _CurrentPassword = objUser1.GetCurrentPassword();
            }
        }

        private bool SetNewPassword()
        {
            
            if (objUser1 != null)
            {


               objUser1.setPassword(txtNewPassword.Text.Trim());
                return objUser1.SaveUsers();
            }
            return false;
        }
        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private bool CheckPassword()
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                errorProvider1.SetError(txtCurrentPassword, "password is not Match!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");
                return true;
            }
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
                {
                MessageBox.Show("Wrong");
            }
            if(txtNewPassword.Text !="")
            {
                if(CheckPassword())
                {
                    if(SetNewPassword())
                    {
                        MessageBox.Show("Password Change succeeded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                        MessageBox.Show("Password Change Filed", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    MessageBox.Show("Password Change Faild", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Fill New Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmchangePassword_Load(object sender, EventArgs e)
        {
            GetUserPassword();
            ctrShowUserInfo1.GetUserInfo(objUser1.UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!objUser1.IsPasswordMatching(txtCurrentPassword.Text.Trim()) )
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Password is not Correct!");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");

            }
        }
    }
}
