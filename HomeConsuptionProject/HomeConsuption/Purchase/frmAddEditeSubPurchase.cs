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


         public frmAddEditeSubPurchase(int? RowCount,int productID, string productDescription,
              int? productSizeID, float quantity, float pricePerUnit)

        {
            InitializeComponent();

            _mode = enMode.Update;

            item = clsItem.FindItem(productID);
            this.Quantity = quantity;
            this.PricePerUnit = pricePerUnit;
           this.RowCount = RowCount;
            this.ProductSizeID = productSizeID;
            this.ProductDescription = productDescription;
        }


        enum enMode { AddNew,Update}

        enMode _mode = enMode.AddNew;

        clsItem item;
        public int? ProductSizeID { set; get; }
        public int? RowCount { set; get; }
         public string ProductDescription { set; get; }

        public float Quantity { set; get; }
        public float PricePerUnit { set; get; }
        public float Total { set; get; }

        public class ProductInfoArgs : EventArgs
        {
            public int? RowCount { set; get; }
            public int ProductID { set; get; }
            public string ProductName { set; get; }
            public string ProductDescription { set; get; }
            public int ProductCategoryID { set; get; }
            public int? ProductSizeID { set; get; }
            public string ProductSizeName { set; get; }

            public float Quantity { set; get; }
            public float PricePerUnit { set; get; }
            public float Total { set; get; }

            public ProductInfoArgs(int? RowCount, int productID, string productName, string productDescription, int productCategoryID, int? productSize, string productSizeName, float quantity, float pricePerUnit, float total)
            {
                ProductID = productID;
                ProductName = productName;
                ProductDescription = productDescription;
                ProductCategoryID = productCategoryID;
                ProductSizeID = productSize;
                ProductSizeName = productSizeName;
                Quantity = quantity;
                PricePerUnit = pricePerUnit;
                Total = total;
                this.RowCount = RowCount;
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



     
       
        
       


        private void frmAddEditeSubPurchase_Load(object sender, EventArgs e)
        {
            if(_mode ==enMode.Update)
            {
                GetProductInfo();

            }else
            {
                txtQuantity.Text = "0.00";
                txtPricePerUnit.Text = "0.00";
            }
            
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
            if(item != null)
            {
                SetProductInfoDefualt();
                btnSave.Enabled = true;
            }
           
        }

        private void SetProductInfoDefualt()
        {
            txtPricePerUnit.Text = item.Price.ToString("F2");
            txtQuantity.Text = "1";
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
            this.Quantity = Convert.ToSingle(txtQuantity.Text);
            this.PricePerUnit = Convert.ToSingle(txtPricePerUnit.Text);

            if(this.Total <=0)
            {
                
                return;
            }

            _OnProductInfo(new ProductInfoArgs(RowCount,item.ItemID, txtProdouctName.Text, rtbDescription.Text, item.CategoryID, null,"", this.Quantity, this.PricePerUnit, this.Total));
            this.Close();

        }

        private void txtQuantityAndPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
                txtQuantity.Text = "0.00";

            if (txtPricePerUnit.Text == "")
                txtPricePerUnit.Text = "0.00";


            float.TryParse(txtQuantity.Text, out float Quantity);
            

            float.TryParse(txtPricePerUnit.Text, out float PricePerUnit);

            PricePerUnit = cbIncludTax.Checked ? PricePerUnit / clsGlobal.Taxprec : PricePerUnit;

            lbTotal.Text = (Quantity * PricePerUnit).ToString();

            this.Total = Convert.ToSingle(lbTotal.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, control keys, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Reject invalid character
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbIncludTax_CheckedChanged(object sender, EventArgs e)
        {
           
                txtQuantityAndPrice_TextChanged(null, null);
        }
    }
}
