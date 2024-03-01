using HomeC_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.Purchase
{
    public partial class frmPurchaseList : Form
    {
        public frmPurchaseList()
        {
            InitializeComponent();
        }

        enum enMode { None,OnlyNumber }

        private enMode _mode = enMode.None;

        int _PageNumber =1;
        string _ColumnName ;
        int _RowsCountPerPage =10;
        int _RowCount;
        int _PageSize { get => (int)Math.Ceiling((double)_RowCount / _RowsCountPerPage); }

        

        private void frmPurchaseList_Load(object sender, EventArgs e)
        {
            cmbColumns.SelectedIndex = 0;

           
           
        }

        private  void _RefreshTable(int PageNumber,int RowCountPerPage)
        {
            DataTable dt =  clsPurchase.GetAllPurchasesInfoWithPages(PageNumber, RowCountPerPage, ref _RowCount);


            dataGridView1.DataSource = dt;
            lbPageSize.Text = _PageSize.ToString();
            RefreshdgvStoresHeaders();
        }

        private void RefreshdgvStoresHeaders()
        {
        

            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Columns["PurchaseID"].HeaderText = "الرقم";
                dataGridView1.Columns["PurchaseID"].Width = 110;

                dataGridView1.Columns["IssueDate"].HeaderText = "تاريخ الفاتـورة";
                dataGridView1.Columns["IssueDate"].Width = 230;

                dataGridView1.Columns["TypeName"].HeaderText = "نوع الفاتـورة";
                dataGridView1.Columns["TypeName"].Width = 175;

                 dataGridView1.Columns["TotalAfterTax"].HeaderText = "المـجـموع";
                dataGridView1.Columns["TotalAfterTax"].Width = 175;

                  dataGridView1.Columns["StoreName"].HeaderText = "أسـم المتجر";
                dataGridView1.Columns["StoreName"].Width = 275;

                  dataGridView1.Columns["CategoryName"].HeaderText = "أسـم الصنف";
                dataGridView1.Columns["CategoryName"].Width = 130;


            }
        }


        private void btnprevious_Click(object sender, EventArgs e)
        {
            if(_PageNumber == 1)
            {
                return;
            }

            _PageNumber--;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PageNumber ==_PageSize)
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void التعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PurchaseID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmAddEditPurchase editPurchase = new frmAddEditPurchase(PurchaseID);
            editPurchase.ShowDialog();
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           string Item= cmbColumns.Items[cmbColumns.SelectedIndex].ToString();

            switch(Item)
            {
                case "الكل":
                    Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
                    txtSearch.Visible = false;
                   
                    break; 
                case "رقم الفاتورة":
                    _ColumnName = "PurchaseID";
                    txtSearch.Visible = true;
                    _mode = enMode.OnlyNumber;

                    break; 
               case "تاريخ الفاتورة":
                    _ColumnName = "IssueDate";
                    txtSearch.Visible = false;
                    break; 
               case "المجموع":
                    _ColumnName = "TotalAfterTax";
                    txtSearch.Visible = true;
                    _mode = enMode.OnlyNumber;
                    break; 
               case "أسم المتجر":
                    _ColumnName = "StoreName";
                    txtSearch.Visible = true;
                    _mode = enMode.None;
                    break; 
               case "نوع الفاتورة":
                    _ColumnName = "TypeName";
                    txtSearch.Visible = false;

                    break; 

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchOperator();
        }
    }
}
