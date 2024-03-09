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


        int _CategoryID=-1;
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
            _objCategory = clsPurchase_SubCategory.FindPurchase_Category(_CategoryID);
            lbCateID.Text = _objCategory.PCategoryID.ToString();
            txtCateName.Text = _objCategory.SubCategoryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _objCategory.SubCategoryName = txtCateName.Text.Trim();


            if (_objCategory.SavePurchase_SubCategories())
            {
                lbCateID.Text = _objCategory.PCategoryID.ToString();

                MessageBox.Show("تمت العملية بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubCategoryInfoArgs categoryA = new SubCategoryInfoArgs(_objCategory.PSCategoryID, _objCategory.SubCategoryName, _objCategory.PSCategoryID);
                DataBackCategoryID?.Invoke(this, categoryA);

            }
            else
            {
                MessageBox.Show("فشلت العملية", "فشلت العملية ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
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


    }
}
