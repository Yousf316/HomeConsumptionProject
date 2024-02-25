using HomeConsuption.Product;
using HomeConsuption.Product.Sizes;
using HomeConsuption.Purchase;
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
    }
}
