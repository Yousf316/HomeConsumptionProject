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

namespace HomeConsuption.Product.Sizes
{
    public partial class frmSizeList : Form
    {
        public frmSizeList()
        {
            InitializeComponent();
        }

        int _PageNumber = 1;
        int _RowsCountPerPage = 12;
        int _RowCount;
        int _PageSize { get => (int)Math.Ceiling((double)_RowCount / _RowsCountPerPage); }


        enum enMode { None, OnlyNumber }

        private enMode _mode = enMode.None;

        string _ColumnName ="";

        private void _RefreshTable(int PageNumber, int RowCountPerPage)
        {
             DataTable dtOrginal =clsSize.GetAllSizesInfoWithPages(PageNumber, RowCountPerPage, ref _RowCount);
            
            if (_RowCount == 0)
                return;

             DataTable dtDistnaiton = dtOrginal.AsDataView().ToTable(false, "SizeID", "SizeName");

           

            dataGridView1.DataSource = dtDistnaiton;

            dataGridView1.Columns["SizeID"].HeaderText = "رقم الحجم";
            dataGridView1.Columns["SizeID"].Width = 100;

            dataGridView1.Columns["SizeName"].HeaderText = "أسم الحجم";
            dataGridView1.Columns["SizeName"].Width = 220;

            


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
            if (_PageNumber == _PageSize || _PageNumber > _PageSize)
            {
                return;
            }

            _PageNumber++;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditeSize  frmAdd = new frmAddEditeSize();
            frmAdd.ShowDialog();
            _PageNumber = 1;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));

        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAddEditeSize frmAdd = new frmAddEditeSize((int)dataGridView1.CurrentRow.Cells[0].Value);
            frmAdd.ShowDialog();
            _PageNumber = 1;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void تعديلمToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void _SearchOperator()
        {

            if (_mode == enMode.OnlyNumber)
            {

                if (!float.TryParse(txtSearch.Text, out float ID))
                {
                    txtSearch.Text = "";
                    return;
                }

                dataGridView1.DataSource = clsPurchase.GetPurchaseInfo(this._ColumnName, txtSearch.Text);

            }
            else
            {
                dataGridView1.DataSource = clsPurchase.GetPurchaseInfo(this._ColumnName, txtSearch.Text);
            }


        }


    }
}
