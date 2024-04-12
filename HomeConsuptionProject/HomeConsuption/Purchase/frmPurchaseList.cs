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
        enum enModeList { WithDate,All_Date }

        private enMode _mode = enMode.None;
        private enModeList _modelist = enModeList.All_Date;

        int _PageNumber =1;
        string _ColumnName ;
        int _RowsCountPerPage =10;
        int _RowCount;
        int _PageSize { get => (int)Math.Ceiling((double)_RowCount / _RowsCountPerPage); }
        string _TypeName;

        DataTable _dtPurchase;



        private void frmPurchaseList_Load(object sender, EventArgs e)
        {
            cmbColumns.SelectedIndex = 0;
            cbAll.Checked = true;
           
           
        }

        private void _GetDateTableofPurchasinfo(int PageNumber, int RowCountPerPage)
        {
            _dtPurchase = clsPurchase.GetAllPurchasesInfoWithPages(PageNumber, RowCountPerPage, ref _RowCount);

        }

        private  void _RefreshTable(int PageNumber,int RowCountPerPage)
        {
                if(_modelist ==enModeList.WithDate)
              _GetPurchaseListByDate(PageNumber, RowCountPerPage);
           else
              _GetPurchaseList(PageNumber, RowCountPerPage);



            dataGridView1.DataSource = _dtPurchase;
            lbPageSize.Text = _PageSize !=0?_PageSize.ToString():"لا يوجد";
            lbCurrentPage.Text = _PageNumber.ToString();
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

                  dataGridView1.Columns["CategoryName"].HeaderText = "الصنف";
                dataGridView1.Columns["CategoryName"].Width = 130;
                  dataGridView1.Columns["SubCategoryName"].HeaderText = " الصنف الفرعي";
                dataGridView1.Columns["SubCategoryName"].Width = 130;


            }
        }


        private void btnprevious_Click(object sender, EventArgs e)
        {
            if(_PageNumber == 1)
            {
                _PageNumber = _PageSize !=0? _PageSize:1;
            }
            else
            _PageNumber--;
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PageNumber >=_PageSize)
            {
                _PageNumber = 1;
            }
            else
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

                

            }

            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTypes.Visible = false;
           string Item= cmbColumns.Items[cmbColumns.SelectedIndex].ToString();

            switch(Item)
            {
                case "الكل":
                    _ColumnName = "All";
                    txtSearch.Visible = false;
                    
                    Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
                    

                    break; 
                case "رقم الفاتورة":
                    _ColumnName = "PurchaseID";
                    txtSearch.Visible = true;
                    _mode = enMode.OnlyNumber;

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
                    cmbTypes.Visible = true;
                    break; 

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchOperator();
        }

        private void _GetPurchaseListByDate(int PageNumber, int RowCountPerPage)
        {

            switch(_ColumnName)
            {
                case "All":
             _dtPurchase = clsPurchase.GetAllPurchasesInfoWithPagesByDate(PageNumber, RowCountPerPage, dtpFrom.Value, dtpTo.Value, ref _RowCount);

                    break;


                case "StoreName":
                    _dtPurchase = clsPurchase.GetAllPurchasesInfoWithPagesByDateOfStoreName(PageNumber, RowCountPerPage, dtpFrom.Value, dtpTo.Value,txtSearch.Text.Trim(), ref _RowCount);

                    break;

                case "TypeName":
                    _dtPurchase = clsPurchase.GetAllPurchaseInfoWithPagingByDateofType(PageNumber, RowCountPerPage, dtpFrom.Value, dtpTo.Value, _TypeName, ref _RowCount);

                    break;


                case "TotalAfterTax":
                    float.TryParse(txtSearch.Text.Trim(), out float totalAfterTax);
                    _dtPurchase = clsPurchase.GetAllPurchaseInfoWithPagingByDateofTotalAfterTax(PageNumber, RowCountPerPage, dtpFrom.Value, dtpTo.Value, totalAfterTax, ref _RowCount);

                    break;

                case "PurchaseID":
                    _dtPurchase = clsPurchase.GetPurchaseInfo(Convert.ToInt32(txtSearch.Text.Trim()));

                    break;
            }


        }


        private void _GetPurchaseList(int PageNumber, int RowCountPerPage)
        {

            switch (_ColumnName)
            {
                case "All":
                    _dtPurchase = clsPurchase.GetAllPurchasesInfoWithPages(PageNumber, RowCountPerPage, ref _RowCount);

                    break;


                case "StoreName":
                    _dtPurchase = clsPurchase.GetAllPurchasesInfoWithPagesByStoreName(PageNumber, RowCountPerPage, txtSearch.Text.Trim(), ref _RowCount);

                    break;

                case "TypeName":
                    _dtPurchase = clsPurchase.GetAllPurchasesInfoWithPagesByTypeName(PageNumber, RowCountPerPage, _TypeName, ref _RowCount);

                    break;


                case "TotalAfterTax":
                    float.TryParse(txtSearch.Text.Trim(), out float totalAfterTax);
                    _dtPurchase = clsPurchase.GetAllPurchasesInfoWithPagesByTotalAfterTax(PageNumber, RowCountPerPage, totalAfterTax, ref _RowCount);

                    break;
                case "PurchaseID":
                    _dtPurchase = clsPurchase.GetPurchaseInfo(Convert.ToInt32( txtSearch.Text.Trim()));

                    break;
            }


        }



        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
             
                dtpFrom.Enabled = !cbAll.Checked;
                dtpTo.Enabled = !cbAll.Checked;
           
            if( cbAll.Checked )
            {
                _modelist = enModeList.All_Date;
                dtpFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
                dtpTo.Value = new DateTime(DateTime.Now.Year, 12, 31);
                
            }else
            {
                _modelist = enModeList.WithDate;
            }

            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
           


            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void الحذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PurchaseID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            clsPurchase.DeletePurchase(PurchaseID);
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _TypeName = cmbTypes.SelectedItem.ToString();
            Parallel.Invoke(() => _RefreshTable(_PageNumber, _RowsCountPerPage));
        }
    }
}
