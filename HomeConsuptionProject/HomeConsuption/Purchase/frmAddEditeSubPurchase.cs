using HomeC_Business;
using HomeConsuption.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.Purchase
{
    public partial class frmAddEditeSubPurchase : Form
    {
        public frmAddEditeSubPurchase()
        {
            InitializeComponent();
        }


        clsItem item;
        public int? ProductSize { set; get; }

        public float Quantity { set; get; }
        public float PricePerUnit { set; get; }
        public float Total { set; get; }

        public class ProductInfoArgs : EventArgs
        {
            public int ProductID { set; get; }
            public string ProductName { set; get; }
            public string ProductDescription { set; get; }
            public int ProductCategoryID { set; get; }
            public int? ProductSize { set; get; }

            public float Quantity { set; get; }
            public float PricePerUnit { set; get; }
            public float Total { set; get; }

            public ProductInfoArgs(int productID, string productName, string productDescription, int productCategoryID, int? productSize, float quantity, float pricePerUnit, float total)
            {
                ProductID = productID;
                ProductName = productName;
                ProductDescription = productDescription;
                ProductCategoryID = productCategoryID;
                ProductSize = productSize;
                Quantity = quantity;
                PricePerUnit = pricePerUnit;
                Total = total;
            }

        }

        
        [Category("Info")]
        public event EventHandler<ProductInfoArgs> OnProductInfo;

        protected virtual void _OnProductInfo(ProductInfoArgs e)
        {
            EventHandler<ProductInfoArgs> handler = OnProductInfo;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void frmAddEditeSubPurchase_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseProduct_Click(object sender, EventArgs e)
        {
            frmProductList productList = new frmProductList();
            productList.OnProductInfo += ProductList_OnProductInfo;
            productList.ShowDialog();
        }

        private void ProductList_OnProductInfo(object sender, frmProductList.ProductInfoArgs e)
        {
            item = clsItem.FindItem(e.ProductID);
            SetProductInfo();
        }

        private void SetProductInfo()
        {
            txtPricePerUnit.Text = item.Price.ToString("F2");
            txtProdouctID.Text = item.ItemID.ToString();
            txtProdouctName.Text = item.ItemName_AR !=""? item.ItemName_AR : item.ItemName_EN;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //_OnProductInfo(new ProductInfoArgs(item.ItemID,item.ItemName_AR,))
        }
    }
}
