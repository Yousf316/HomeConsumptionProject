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
    public partial class frmAddEditStore : Form
    {
        int? _StoreID;

        public delegate void CallbackStoreID(object sender, int StoreID);

        public event CallbackStoreID DataBack_StoreID;

        public frmAddEditStore()
        {
            InitializeComponent();
        }
        public frmAddEditStore(int StoreID)
        {
            InitializeComponent();
            _StoreID = StoreID;
        }

       private void _GetStoreInfoByID(int StoreID)
        {
            clsStore objstore = clsStore.Findstore(StoreID);

            if (objstore == null)
            {
                MessageBox.Show($" {StoreID} : لا يوجد متجر بالرقم ","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lbID.Text = objstore.GetStoreID().ToString();
            txtStoreName.Text = objstore.StoreName;
            txtLocation.Text = objstore.Location != "" ? objstore.Location:"" ;
        }
         private bool AddNewStore()
        {

            clsStore objnewstore = new clsStore();
            objnewstore.StoreName = txtStoreName.Text;
            objnewstore.Location = txtLocation.Text;

            if (objnewstore.SaveStores())
            {
                _StoreID = objnewstore.GetStoreID();

                MessageBox.Show($" نجح في انشاء متجر جديد ", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _GetStoreInfoByID(_StoreID??-1);
                return true;
            }
            else
            {
                MessageBox.Show($" فشل في انشاء متجر جديد ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool SaveStoreInfoByID()
        {
            clsStore objstore = clsStore.Findstore(_StoreID??-1);

            if (objstore == null)
            {
               return AddNewStore();
                

            }
            lbID.Text = objstore.GetStoreID().ToString();
            objstore.StoreName = txtStoreName.Text;
            objstore.Location =txtLocation.Text;

            if (objstore.SaveStores())
            {
                
                MessageBox.Show($" تم التعديل بنجاح ", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show($" فشل  التعديل   ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        

        private void txtStoreName_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtbox = (TextBox)sender ;
            if (txtbox.Text =="")
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtbox, "يجب ملئ هذا الحقل");
            }else
            {
                errorProvider1.SetError(txtbox, "");
            }

        }

        private void AddEditStore_Load(object sender, EventArgs e)
        {
            if(_StoreID !=null)
            {
                _GetStoreInfoByID(_StoreID??-1);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(SaveStoreInfoByID())
            {
                DataBack_StoreID?.Invoke(this, _StoreID??-1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
