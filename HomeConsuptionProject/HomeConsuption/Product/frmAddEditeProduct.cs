using HomeC_Business;
using HomeConsuption.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.Product
{
    public partial class frmAddEditeProduct : Form
    {


        enum enMode { AddNew,Update}

        enMode _mode = enMode.AddNew;

        public frmAddEditeProduct()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }

        int?    _ItemID ;
        clsItem _Item;

        public frmAddEditeProduct(int ItemID)
        {
            InitializeComponent();
            _ItemID = ItemID;
            _mode = enMode.Update;

        }

        private void _GetDefaultValues()
        {
            _Item = new clsItem();
            txtPrice.Text = "0.00";
            txtProductArabicName.Text = "";
            txtProductEngName.Text = "";
            picProductImage.Image = Resources.icons8_product_96;
           
        }

        private void _GetItemValues()
        {

            _Item = clsItem.FindItem(_ItemID??-1);

            if (_Item == null)
            {
                MessageBox.Show("لا يوجد منتج بهذا الرقم", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            lbID.Text = _Item.ItemID.ToString();
            txtPrice.Text = _Item.Price.ToString();
            txtProductArabicName.Text = _Item.ItemName_AR.ToString();
            txtProductEngName.Text = _Item.ItemName_EN.ToString();
            picProductImage.ImageLocation = _Item.ImagePath !=""? _Item.ImagePath:null;
            cmbCategories.SelectedItem = clsCategory.FindCategory(_Item.CategoryID).CategoryName;
            


        }

        private void _SetItemInfo()
        {
            int CategoryID = clsCategory.FindCategory(cmbCategories.SelectedItem.ToString()).CategoryID;
            float Price = Convert.ToSingle(txtPrice.Text);
            _HandleProductImage();
            _Item.SetItemValues(txtProductArabicName.Text.Trim(), txtProductEngName.Text.Trim(), CategoryID, Price, picProductImage.ImageLocation);

            if(_Item.SaveItems())
            {
                MessageBox.Show("تمت الحفظ بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ItemID = _Item.ItemID;
                _mode = enMode.Update;
                frmAddEditeProduct_Load(null,null);
            }
            else
            {
                MessageBox.Show("لم تتم عملية الحفظ ", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void _GetAllCategories()
        {
            DataTable dt = clsCategory.GetAllCatgoriesInfo();
            cmbCategories.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cmbCategories.Items.Add(dr["CategoryName"].ToString());
            }

        }


        private void frmAddEditeProduct_Load(object sender, EventArgs e)
        {
            _GetAllCategories();

            cmbCategories.SelectedIndex = 0;

            if (_mode ==enMode.AddNew)
            {
                _GetDefaultValues();

            }else
            {
                _GetItemValues();
            }
        }

        private void lnkAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "اختر صورة";
            this.ShowIcon = false;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                picProductImage.Load(selectedFilePath);
                lnkRemoveImage.Visible = true;
                // ...
            }
        }
        private bool _HandleProductImage()
        {

            if (_Item.ImagePath != picProductImage.ImageLocation)
            {
                if (_Item.ImagePath != "")
                {


                    try
                    {
                        File.Delete(_Item.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (picProductImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = picProductImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        picProductImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;


        }


        private void lkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picProductImage.ImageLocation = null;

            picProductImage.Image = Resources.icons8_product_96;




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SetItemInfo();
        }

        private void btnAddNewCat_Click(object sender, EventArgs e)
        {
            frmAddEditCategory addEditCategory = new frmAddEditCategory();
            addEditCategory.DataBackCategoryID += AddEditCategory_DataBackCategoryID;
            addEditCategory.ShowDialog();
        }

        private void AddEditCategory_DataBackCategoryID(object sender, frmAddEditCategory.CategoryInfoArgs categoryInfo)
        {
             _GetAllCategories();
            cmbCategories.SelectedItem = categoryInfo.CategoryName;
        }
    }
}
