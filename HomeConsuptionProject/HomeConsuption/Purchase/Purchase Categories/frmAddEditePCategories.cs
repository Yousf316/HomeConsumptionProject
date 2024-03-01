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

namespace HomeConsuption.Purchase.Purchase_Categories
{
    public partial class frmAddEditePCategories : Form
    {
        public frmAddEditePCategories()
        {
            InitializeComponent();
        }

        enum enMode { AddNew, Update }

        enMode _mode = enMode.AddNew;
        public class CategoryInfoArgs : EventArgs
        {
            public int CategoryID { get; }
            public string CategoryName { get; }

            public CategoryInfoArgs(int CategoryID, string CategoryName)
            {
                this.CategoryID = CategoryID;
                this.CategoryName = CategoryName;
            }
        }

        public delegate void CallbackCategoryID(object sender, CategoryInfoArgs categoryInfo);

        public event CallbackCategoryID DataBackCategoryID;


        int _CategoryID;
        clsPurchase_Category _objCategory;
        public frmAddEditePCategories(int categoryID)
        {
            InitializeComponent();
            _CategoryID = categoryID;
            _mode = enMode.Update;

        }

        private void _GetDefaultValues()
        {
            _objCategory = new clsPurchase_Category();
            lbCateID.Text = "[????]";
            txtCateName.Text = "";
        }
        private void _SetCategoryInfo()
        {
            _objCategory = clsPurchase_Category.FindPurchase_Category(_CategoryID);
            lbCateID.Text = _objCategory.PCategoryID.ToString();
            txtCateName.Text = _objCategory.CategoryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _objCategory.CategoryName = txtCateName.Text.Trim();

            if (_objCategory.SavePurchase_Categories())
            {
                lbCateID.Text = _objCategory.PCategoryID.ToString();

                MessageBox.Show("تمت العملية بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoryInfoArgs categoryA = new CategoryInfoArgs(_objCategory.PCategoryID, _objCategory.CategoryName);
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
