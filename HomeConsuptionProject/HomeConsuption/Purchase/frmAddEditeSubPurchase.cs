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
            _mode = enMode.AddNew;
        }
         public frmAddEditeSubPurchase(int productID, string productDescription,
              int? productSizeID, float quantity, float pricePerUnit, float total)
        {
            InitializeComponent();

            _mode = enMode.Update;

            item = clsItem.FindItem(productID);
            this.Quantity = quantity;
            this.PricePerUnit = pricePerUnit;
            this.Total = total;
            this.ProductSizeID = productSizeID;
            this.ProductDescription = productDescription;
        }


        enum enMode { AddNew,Update}

        enMode _mode = enMode.AddNew;

        clsItem item;
        public int? ProductSizeID { set; get; }
         public string ProductDescription { set; get; }

        public float Quantity { set; get; }
        public float PricePerUnit { set; get; }
        public float Total { set; get; }

        public class ProductInfoArgs : EventArgs
        {
            public int ProductID { set; get; }
            public string ProductName { set; get; }
            public string ProductDescription { set; get; }
            public int ProductCategoryID { set; get; }
            public int? ProductSizeID { set; get; }

            public float Quantity { set; get; }
            public float PricePerUnit { set; get; }
            public float Total { set; get; }

            public ProductInfoArgs(int productID, string productName, string productDescription, int productCategoryID, int? productSize, float quantity, float pricePerUnit, float total)
            {
                ProductID = productID;
                ProductName = productName;
                ProductDescription = productDescription;
                ProductCategoryID = productCategoryID;
                ProductSizeID = productSize;
                Quantity = quantity;
                PricePerUnit = pricePerUnit;
                Total = total;
            }

        }

        
       
        public event EventHandler<ProductInfoArgs> OnProductInfo;

        protected virtual void _OnProductInfo(ProductInfoArgs e)
        {
            EventHandler<ProductInfoArgs> handler = OnProductInfo;
            if (handler != null)
            {
                handler(this, e);
            }
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
            txtQuantity.Text = "0.00";
            txtPricePerUnit.Text = "0.00";
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
            SetProductInfoDefualt();
        }

        private void SetProductInfoDefualt()
        {
            txtPricePerUnit.Text = item.Price.ToString("F2");
            txtProdouctID.Text = item.ItemID.ToString();
            txtProdouctName.Text = item.ItemName_AR !=""? item.ItemName_AR : item.ItemName_EN;
            
        }
        private void GetProductInfo()
        {
            txtPricePerUnit.Text = this.PricePerUnit.ToString();
            txtQuantity.Text = this.Quantity.ToString();
            txtProdouctID.Text = item.ItemID.ToString();
            txtProdouctName.Text = item.ItemName_AR !=""? item.ItemName_AR : item.ItemName_EN;
            rtbDescription.Text = this.ProductDescription;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _OnProductInfo(new ProductInfoArgs(item.ItemID, txtProdouctName.Text, rtbDescription.Text, item.CategoryID, null, this.Quantity, this.PricePerUnit, this.Total));
            this.Close();

        }

        private void txtQuantityAndPrice_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(txtQuantity.Text, out float Quantity);
            this.Quantity = Quantity;

            float.TryParse(txtPricePerUnit.Text, out float PricePerUnit);

            this.PricePerUnit = PricePerUnit;

            lbTotal.Text = (this.Quantity * PricePerUnit).ToString();

            this.Total = Convert.ToSingle(lbTotal.Text);
        }

    }
}
