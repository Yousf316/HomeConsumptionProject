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

namespace HomeConsuption.Product
{
    public partial class frmAddEditCategory : Form
    {
        public frmAddEditCategory()
        {
            InitializeComponent();
        }

        enum enMode { AddNew,Update}

        enMode _mode = enMode.AddNew;
       public class CategoryInfoArgs : EventArgs
        {
            public int CategoryID { get; }
            public string CategoryName { get; }

           public CategoryInfoArgs(int CategoryID,string CategoryName)
            {
                this.CategoryID = CategoryID;
                this.CategoryName = CategoryName;
            }
        }

        public delegate void CallbackCategoryID(object sender, CategoryInfoArgs categoryInfo);

        public event CallbackCategoryID DataBackCategoryID;


        int _CategoryID;
        clsCategory _objCategory;
        public frmAddEditCategory(int categoryID)
        {
            InitializeComponent();
            _CategoryID = categoryID;
        }
        
        private void _GetDefaultValues()
        {
            _objCategory = new clsCategory();
            lbCateID.Text = "[????]";
           txtCateName.Text = "";
        }
         private void _SetCategoryInfo()
        {
            _objCategory = clsCategory.FindCategory(_CategoryID);
            lbCateID.Text = _objCategory.CategoryID.ToString();
           txtCateName.Text = _objCategory.CategoryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _objCategory.SetCategoryInfo(txtCateName.Text);

            if(_objCategory.SaveCategories())
            {
                lbCateID.Text = _objCategory.CategoryID.ToString();

                MessageBox.Show("", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoryInfoArgs categoryA = new CategoryInfoArgs(_objCategory.CategoryID, _objCategory.CategoryName);
                DataBackCategoryID?.Invoke(this, categoryA);

            }else
            {
                MessageBox.Show("", "فشلت العملية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            if(_mode == enMode.AddNew)
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
