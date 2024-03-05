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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        int _PageNumber = 1;
        int _RowsCountPerPage = 12;
        int _RowCount;
        int _PageSize { get => (int)Math.Ceiling((double)_RowCount / _RowsCountPerPage); }

        private static DataTable _dAllStores;
        private DataTable _dStores;


        public class ProductInfoArgs : EventArgs
        {
            public int ProductID { set; get; }

            public ProductInfoArgs(int productID)
            {
                ProductID = productID;
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

        private void _RefreshTable(int PageNumber, int RowCountPerPage)
        {
            DataTable dtOrginal = clsItem.GetAllItems(PageNumber, RowCountPerPage, ref _RowCount);

            if (_RowCount == 0)
                return;

            DataTable dtDistnaiton = dtOrginal.AsDataView().ToTable(false,"ItemID", "ItemName_AR", "ItemName_EN", "CategoryID","Price");



            dataGridView1.DataSource = dtDistnaiton;

            dataGridView1.Columns["ItemID"].HeaderText = "رقم المنتج";
            dataGridView1.Columns["ItemID"].Width = 100;

            dataGridView1.Columns["ItemName_AR"].HeaderText = "أسم المنتج بالعربي";
            dataGridView1.Columns["ItemName_AR"].Width = 120;

            dataGridView1.Columns["ItemName_EN"].HeaderText = "أسم المنتج بالاْنجليزي";
            dataGridView1.Columns["ItemName_EN"].Width = 120;

            dataGridView1.Columns["CategoryID"].HeaderText = "رقم المجموعة";
            dataGridView1.Columns["CategoryID"].Width = 100;

            dataGridView1.Columns["Price"].HeaderText = "السعر";
            dataGridView1.Columns["Price"].Width = 120;


            lbPageSize.Text = _PageSize.ToString();
        }
        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (_PageNumber == 1)
            {
                return;
            }

            _PageNumber--;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PageNumber == _PageSize)
            {
                return;
            }

            _PageNumber++;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditPurchase frmAddPurchase = new frmAddEditPurchase();
            frmAddPurchase.ShowDialog();
            _PageNumber = 1;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));

        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAddEditeProduct frmAddProduct = new frmAddEditeProduct();
            frmAddProduct.ShowDialog();
            _PageNumber = 1;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void تعديلمToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmAddEditeProduct objEditeProduct = new frmAddEditeProduct((int)dataGridView1.CurrentRow.Cells[0].Value);
            objEditeProduct.ShowDialog();
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ProductID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            _OnProductInfo(new ProductInfoArgs(ProductID));
            this.Close();
        }
    }
}
