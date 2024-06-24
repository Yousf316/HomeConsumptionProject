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

namespace HomeConsuption.Purchase.Purchase_Sub_Categories
{
    public partial class frmAddEditePSubCategory : Form
    {
        public frmAddEditePSubCategory()
        {
            InitializeComponent();
        }

        enum enMode { AddNew, Update }

        enMode _mode = enMode.AddNew;
        public class SubCategoryInfoArgs : EventArgs
        {
            public int PSCategoryID { get; }
            public int PCategoryID { get; }
            public string CategoryName { get; }

            public SubCategoryInfoArgs(int PSCategoryID, string CategoryName, int pCategoryID)
            {
                this.PSCategoryID = PSCategoryID;
                this.CategoryName = CategoryName;
                PCategoryID = pCategoryID;
            }
        }

        public delegate void CallbackCategoryID(object sender, SubCategoryInfoArgs categoryInfo);

        public event CallbackCategoryID DataBackCategoryID;


        int _PSCategoryID;
        clsPurchase_SubCategory _objCategory;
        public frmAddEditePSubCategory(int PSCategoryID)
        {
            InitializeComponent();
            _PSCategoryID = PSCategoryID;
            _mode = enMode.Update;

        }

        private void _GetDefaultValues()
        {
            _objCategory = new clsPurchase_SubCategory();
            lbCateID.Text = "[????]";
            txtCateName.Text = "";

        }

        private void _SetCategoryInfo()
        {
            _objCategory = clsPurchase_SubCategory.FindPurchase_SubCategories(_PSCategoryID);
            lbCateID.Text = _objCategory.PSCategoryID.ToString();
            txtCateName.Text = _objCategory.SubCategoryName;
            cmbCategories.Visible = false;
            lbCategory.Visible = false;
        }
         private void _SetSubBaseCategory()
        {

            clsPurchaseSubBaseCategories subBaseCategories = new clsPurchaseSubBaseCategories();

            subBaseCategories.SetValues(_objCategory.PSCategoryID, clsPurchase_Category.FindPurchase_Category(cmbCategories.SelectedItem.ToString()).PCategoryID);

            if (subBaseCategories.SavePurchaseSubBaseCategories())
            {
                SubCategoryInfoArgs categoryA = new SubCategoryInfoArgs(_objCategory.PSCategoryID, _objCategory.SubCategoryName, subBaseCategories.objPCategory.PCategoryID);
                DataBackCategoryID?.Invoke(this, categoryA);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _objCategory.SetValues(txtCateName.Text.Trim(),clsGlobal.CurrentUser.UserID);

            if (_objCategory.SavePurchase_SubCategories())
            {
                lbCateID.Text = _objCategory.PSCategoryID.ToString();

                if (_mode == enMode.AddNew)
                    _SetSubBaseCategory();

                MessageBox.Show("تمت العملية بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("فشلت العملية", "فشلت العملية ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            _GetAllCategories();
            if (_mode == enMode.AddNew)
            {
                _GetDefaultValues();
            }
            else
            {
                _SetCategoryInfo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _GetAllCategories()
        {
            DataTable dt = clsPurchase_Category.GetAllPurchase_Categories();
            cmbCategories.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cmbCategories.Items.Add(dr["CategoryName"].ToString());
            }
            if(cmbCategories.Items.Count >0)
                cmbCategories.SelectedIndex = 0;
        }



    }
}
