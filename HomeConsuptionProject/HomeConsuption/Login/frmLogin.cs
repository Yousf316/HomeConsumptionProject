
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
using HomeC_Business;
using HomeConsuption.Global;
using System.Configuration;
using HomeConsuption.DataBases;

namespace HomeConsuption.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void _GetAllDataBase()
        {
          
                cmbDataBaseName.Items.Clear();
                foreach (ConnectionStringSettings connectionString in ConfigurationManager.ConnectionStrings)
                {

                    cmbDataBaseName.Items.Add(connectionString.Name);
                    
                }
            
        }

        private void _SetDataBase(string DatabaseName)
        {

           if( cmbDataBaseName.Items.Contains(DatabaseName))
            {
                cmbDataBaseName.SelectedItem = DatabaseName;
            }



        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _GetAllDataBase();
            string UserName = ""; string Password = "";
            string Database = "";
            if (clsGlobal.GetStoredCredential(ref UserName,ref Password))
            {
                rjtxtPassword.Texts = Password;
                rjtxtUserName.Texts = UserName;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;

            }

            if(clsGlobal.GetDataBaseName(ref Database))
            {
                _SetDataBase(Database);
            }
           
        }

       
       
   
       
        
    

   

      

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rjbtnOk_Click(object sender, EventArgs e)
        {
            if(cmbDataBaseName.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اخنيار قاعدة بيانات", "مشكلة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //string HashPassword = clsValidatoin.HashCodeCompute(rjtxtPassword.Texts.Trim());
            clsUser UserID = clsUser.FindUserByUserNameAndPassword(rjtxtUserName.Texts.Trim(), rjtxtPassword.Texts.Trim());

            string DatabaseName = cmbDataBaseName.SelectedItem.ToString();
            clsGlobal.RememberDataBase(DatabaseName);
            if (UserID != null)
            {

                if (UserID.IsActive)
                {
                    if (chkRememberMe.Checked)
                    {
                        clsGlobal.RememberUsernameAndPassword(rjtxtUserName.Texts.Trim(), rjtxtPassword.Texts);
                    }
                    else
                    {
                        clsGlobal.RememberUsernameAndPassword(null, null);
                    }

                    MessageBox.Show("تم التسجيل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clsEventLogs.IsSourceNameExists();

                    clsEventLogs.WriteLog("User Login Successfuly", System.Diagnostics.EventLogEntryType.Information);


                    clsGlobal.CurrentUser = UserID;

                    Main home = new Main(this);
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("المستخدم غير مفعل تواصل مع المدير", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsEventLogs.WriteLog("User is Not Active try Login", System.Diagnostics.EventLogEntryType.Error);

                }
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كملة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clsEventLogs.WriteLog("User Login Faild", System.Diagnostics.EventLogEntryType.Error);

            }

        }

        private void rjbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsGlobalBusiness.SetConnectionString(cmbDataBaseName.SelectedItem.ToString());
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frmDataBaseList frmDataBaseList = new frmDataBaseList();
            frmDataBaseList.ShowDialog();
            _GetAllDataBase();
        }
    }
}
