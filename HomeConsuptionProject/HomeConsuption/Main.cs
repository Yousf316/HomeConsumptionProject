using HomeConsuption.Forms;
using HomeConsuption.Product;
using HomeConsuption.Product.Sizes;
using HomeConsuption.Purchase;
using HomeConsuption.Purchase.Purchase_Categories;
using HomeConsuption.Purchase.Purchase_Sub_Categories;
using HomeConsuption.Reports;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Main(frmLogin login)
        {
            InitializeComponent();
        }

        private void قائمةالمتاجرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStores frmList = new frmListStores();
            frmList.ShowDialog();
        }

        private void اصدارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPurchase frmAddPurchase =  new frmAddEditPurchase();
            frmAddPurchase.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void اضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeProduct AddEditeProduct = new frmAddEditeProduct();
            AddEditeProduct.ShowDialog();
        }

        private void قائمةالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseList objPurchaseList = new frmPurchaseList();
            objPurchaseList.ShowDialog();
        }

        private void ادراجمتجرجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditStore frmAddEditStore = new frmAddEditStore();
            frmAddEditStore.ShowDialog();
        }

        private void ادراجمجموعةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCategory addEditCategory = new frmAddEditCategory();
            addEditCategory.ShowDialog();
        }

        private void قائمةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductList objProductList = new frmProductList();
            objProductList.ShowDialog();
        }

        private void قائمةالمجموعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryList categoryList =new frmCategoryList();
            categoryList.ShowDialog();
        }

        private void قائمةالمقاساتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSizeList sizeList = new frmSizeList();
            sizeList.ShowDialog();
        }

        private void ادراجمقاسجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeSize addEditeSize = new frmAddEditeSize();
            addEditeSize.ShowDialog();
        }

        private void أدراجصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditePCategories editePCategories = new frmAddEditePCategories();
            editePCategories.ShowDialog();
        }

        private void أدارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void تقريرالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseReports purchaseReports = new frmPurchaseReports();
            purchaseReports.ShowDialog();
        }

        private void الاصنافالريئسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPCategoriesList pcategoriesList = new frmPCategoriesList();
            pcategoriesList.ShowDialog();
        }

        private void صنفرئيسيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditePCategories editePCategories = new frmAddEditePCategories();
            editePCategories.ShowDialog();
        }

        private void صنففرعيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditePSubCategory addEditePSubCategory = new frmAddEditePSubCategory();
            addEditePSubCategory.ShowDialog();
        }

        private void الاصنافالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchseSubCategoriesList purchseSubCategoriesList = new frmPurchseSubCategoriesList();
            purchseSubCategoriesList.ShowDialog();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frmAddUpdateUsers = new frmAddUpdateUsers();
            frmAddUpdateUsers.ShowDialog();
        }

        private void قائمةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frmManageUsers = new frmManageUsers();
            frmManageUsers.ShowDialog();
        }
    }
}
