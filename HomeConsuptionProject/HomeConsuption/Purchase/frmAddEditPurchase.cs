//#define Test
using HomeC_Business;
using HomeConsuption.Purchase;
using HomeConsuption.Purchase.Purchase_Categories;
using HomeConsuption.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeConsuption
{
    public partial class frmAddEditPurchase : Form
    {

        private int? _PurchaseID;
        public frmAddEditPurchase()
        {
            InitializeComponent();
            _mode = enMode.Addnew;
        }
        public frmAddEditPurchase(int PurchaseID)
        {
            InitializeComponent();
            _mode = enMode.Update;
            _PurchaseID = PurchaseID;
        }

        enum enMode { Addnew,Update}
        enMode _mode = enMode.Addnew;
        enum enType { withItems,no_Items}
        enType _type = enType.withItems;

        private int _TypeID;

        private clsStore _objStore ;

        DataTable dtSubPurchase;

        int _NextRowNumber = 1;

        private void AddEditPurchase_Load(object sender, EventArgs e)
        {
            _GetAllCategories();
            if (_mode == enMode.Addnew)
            {

                _SetDefaultValues();
            }
            else
            {
                _GetPurchaseValues();

            }


            _TestPropti();


        }
        [Conditional("Test")]
        private void _TestPropti()
        {
            btnTest.Visible = true;
        }

        private void _SetDefaultValues()
        {
            txtDiscount.Text = "0.00";
            txtTaxAmount.Text = "0.00";
            txtTotalAfterTax.Text = "0.00";
            txtTotalBeforeTax.Text = "0.00";
            txtTotalAmount.Text = "0.00";
            lbRecordCount.Text = "0";
            lbID.Text = "[????]";
            txtStoreID.Text = "";
            txtStoreName.Text = "";
            cbTypeInvoice.SelectedIndex = 0;
            cbTypeInvoice.Enabled = true;

            cmbCategoryList.SelectedItem = "عام";

            this.Text = "أصدار فاتورة مشتريات";

        }

        private void _GetDataTablePurchase()
        {
            dtSubPurchase.Clear();
            DataTable dTable = clsPurchase_sub.GetPurchases_sub(this._PurchaseID??-1);

            foreach (DataRow dr in dTable.Rows)
            {
                int.TryParse(dr["Size"].ToString(), out int Size);
                int? SizeID = Size;
                dtSubPurchase.Rows.Add((int)dr["P_subID"], (int)dr["ItemID"], dr["ItemName"].ToString(), SizeID == 0? null: SizeID, "", dr["Description"].ToString()
                    , Convert.ToSingle( dr["Quantity"].ToString()), Convert.ToSingle(dr["ItemPrice"].ToString()), Convert.ToSingle(dr["TotalAmount"].ToString()));
            }
            _NextRowNumber += dTable.Rows.Count;
            _RefreshRecordCount();
        }

        private void _GetPurchaseValues()
        {
            clsPurchase purchase = clsPurchase.FindPurchase(_PurchaseID??-1);

            if(purchase == null)
            {
                MessageBox.Show(_PurchaseID.ToString() + " لا يوجد فاتورة بهذا الرقم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            txtDiscount.Text = purchase.Discount !=null? purchase.Discount.ToString():"0.00";
            txtTotalAmount.Text = purchase.Discount != null ? (purchase.Discount+purchase.TotalBeforTax).ToString() : purchase.TotalBeforTax.ToString();
            txtStoreID.Text = purchase.StoreID.ToString();
            txtStoreName.Text = purchase.objStoreInfo.StoreName;

            lbID.Text = purchase.PurchaseID.ToString();


            dtpDate.Value = purchase.IssueDate;

            cbTypeInvoice.SelectedIndex = purchase.Type ==1? 0:1;
            cbTypeInvoice.Enabled = false;

            cmbCategoryList.SelectedItem = clsPurchase_Category.FindPurchase_Category(purchase.PCategoryID).CategoryName;

            if(purchase.Type ==2)
            _GetDataTablePurchase();

            this.Text = "تعديل فاتورة مشتريات";
        }

        private void btnAddNewStore_Click(object sender, EventArgs e)
        {
            frmAddEditStore frmAddEditStore = new frmAddEditStore();
            frmAddEditStore.DataBack_StoreID += GetStoreID;
            frmAddEditStore.ShowDialog();
        }

        private void txtStoreName_Enter(object sender, EventArgs e)
        {
            frmListStores frmList = new frmListStores();
            frmList.DataBack_StoreID += GetStoreID;
            frmList.ShowDialog();
        }
        private void GetStoreID(object sender,int StoreID)
        {
           _objStore = clsStore.Findstore(StoreID);

            if (_objStore != null)
            {
                txtStoreID.Text = _objStore.GetStoreID().ToString();
                txtStoreName.Text = _objStore.StoreName;
            }


        }

        private void txtStoreName_DoubleClick(object sender, EventArgs e)
        {
            frmListStores frmList = new frmListStores();
            frmList.DataBack_StoreID += GetStoreID;
            frmList.ShowDialog();
        }

        private void _SubPurchaseColumns()
        {
            dtSubPurchase = new DataTable();

            DataColumn column = new DataColumn("RowCount", typeof(int));
          
            dtSubPurchase.Columns.Add(column);
            
            dtSubPurchase.Columns.Add("ProductID", typeof(int));
            dtSubPurchase.Columns.Add("ProductName", typeof(string));
            dtSubPurchase.Columns.Add("SizeID", typeof(int));
            dtSubPurchase.Columns.Add("SizeName", typeof(string));
            dtSubPurchase.Columns.Add("Description", typeof(string));
            dtSubPurchase.Columns.Add("Quantity", typeof(float));
            dtSubPurchase.Columns.Add("ItemPrice", typeof(float));
            dtSubPurchase.Columns.Add("TotalAmount", typeof(float));

        }

        private void _RefreshRecordCount()
        {
            lbRecordCount.Text = dtSubPurchase.Rows.Count.ToString();
        }

       private void _SetDgvPurchaseColumn()
        {
           
            dgvSubPurchase.DataSource = dtSubPurchase;

            dgvSubPurchase.Columns["RowCount"].HeaderText = "رقم الصنف";
            dgvSubPurchase.Columns["RowCount"].Width = 150;


            dgvSubPurchase.Columns["SizeID"].Visible = false;
              dgvSubPurchase.Columns["ProductID"].Visible = false;


            dgvSubPurchase.Columns["SizeName"].HeaderText = "الحجم";
            dgvSubPurchase.Columns["SizeName"].Width = 150;
            dgvSubPurchase.Columns["SizeName"].Visible = false ;

            dgvSubPurchase.Columns["ProductName"].HeaderText = "اسم الصنف";
            dgvSubPurchase.Columns["ProductName"].Width = 150;

            dgvSubPurchase.Columns["Description"].HeaderText = "الوصف";
            dgvSubPurchase.Columns["Description"].Width = 150;

            dgvSubPurchase.Columns["ItemPrice"].HeaderText = "السعر";
            dgvSubPurchase.Columns["ItemPrice"].Width = 150;

            dgvSubPurchase.Columns["Quantity"].HeaderText = "الكمية";
            dgvSubPurchase.Columns["Quantity"].Width = 150;

            dgvSubPurchase.Columns["TotalAmount"].HeaderText = "المجموع";
            dgvSubPurchase.Columns["TotalAmount"].Width = 150;

        }
       
      
        private void _SumAllProduct()
        {
            float SumTotal = 0;

            foreach (DataRow Row in dtSubPurchase.Rows)
            {
                SumTotal += (float)Row["TotalAmount"];
            }

            txtTotalAmount.Text = SumTotal.ToString();
            cbIncludTax_CheckedChanged(null, null);
            _RefreshRecordCount();
        }

       private void _SetTotalAmountBeforeTax()
        {
            if(txtDiscount.Text =="")
            {
                txtDiscount.Text = "0.00";
            }

            if (txtTotalAmount.Text == "")
            {
                txtTotalAmount.Text = "0.00";
            }

            float totalAmount = Convert.ToSingle(txtTotalAmount.Text);
            float Discount = Convert.ToSingle(txtDiscount.Text);
            txtTotalBeforeTax.Text = (totalAmount-Discount).ToString("F3");
        }

       private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            

        }

        

        private void txtTotalBeforeTax_TextChanged(object sender, EventArgs e)
        {

            txtTotalAfterTax.Text = (Convert.ToSingle(txtTotalBeforeTax.Text) * clsGlobal.Taxprec).ToString("F2");

            txtTaxAmount.Text = (Convert.ToSingle(txtTotalAfterTax.Text) - Convert.ToSingle(txtTotalBeforeTax.Text)).ToString("F2");
        }

        private void txtTotalAmount_DoubleClick(object sender, EventArgs e)
        {
            frmTotalAmountwithTax totalAmountwithTax = new frmTotalAmountwithTax();

            totalAmountwithTax.BackAmountBeforeTax += BackTotalAmountBeforeTax;

            totalAmountwithTax.ShowDialog();
        }

        private void BackTotalAmountBeforeTax(object sender, double AmountBT)
        {
            txtTotalAmount.Text = AmountBT.ToString();
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == 1)
            {
                MessageBox.Show("this field will be Manage Items");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTypeInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTypeInvoice.SelectedIndex == 0)
            {
                _type = enType.no_Items;
                dtSubPurchase = null;
                dgvSubPurchase.DataSource = null;
                _TypeID = 1;
                btnAddRecord.Enabled = false;
                txtTotalAmount.Enabled = true;
            }
            else
            {
                _type = enType.withItems;
                _TypeID = 2;
                _SubPurchaseColumns();
                _SetDgvPurchaseColumn();
                btnAddRecord.Enabled = true;
                txtTotalAmount.Enabled = false;

            }
        }
         
        private bool _SetPurchase()
        {
            clsPurchase purchase;
            if (_PurchaseID != null)
            {
                purchase = clsPurchase.FindPurchase(_PurchaseID ?? -1);

                if (purchase == null) {

                    MessageBox.Show("لا يوجد فاتورة بهذا الرقم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

            }else
            {
                purchase = new clsPurchase();
            }



            float TotalBeforTax = Convert.ToSingle(txtTotalBeforeTax.Text);
            float TaxAmount = Convert.ToSingle(txtTaxAmount.Text);
            float TotalAfterTax = Convert.ToSingle(txtTotalAfterTax.Text);
            float? Discount = Convert.ToSingle(txtDiscount.Text);

            Discount = Discount ==0.00? null :Discount;
            int StoreID = Convert.ToInt32(txtStoreID.Text);
             
            int pCategoryID = clsPurchase_Category.FindPurchase_Category(cmbCategoryList.SelectedItem.ToString()).PCategoryID;


            purchase.SetValues(dtpDate.Value, TotalBeforTax, TaxAmount, TotalAfterTax, StoreID, _TypeID, pCategoryID, Discount);

            if (purchase.SavePurchases())
            {
                _PurchaseID = purchase.PurchaseID;
                lbID.Text = _PurchaseID.ToString();
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool _SetPurchaseSub()
        {

            clsPurchase_sub.DeletePurchase_sub(this._PurchaseID??-1);
            if (dtSubPurchase.Rows.Count == 0)
                return false;

                foreach (DataRow drow in dtSubPurchase.Rows)
            {
                clsPurchase_sub purchasesub = new clsPurchase_sub();

                int.TryParse(drow["SizeID"].ToString(), out int sSizeID);
                    int? SizeID = sSizeID;
                int RowCount = (int)drow["RowCount"];
                purchasesub.SetValues(this._PurchaseID??-1, RowCount, (int)drow["ProductID"], drow["ProductName"].ToString()
                    , drow["Description"].ToString(), (float)drow["ItemPrice"], (float)drow["Quantity"]
                    , (float)drow["TotalAmount"], SizeID == 0 ? null : SizeID);


               if( !purchasesub.SavePurchases_sub())
                {
                    return false;
                }
            }
            

            return true;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
          if(txtStoreID.Text =="")
            {

                MessageBox.Show("اختار متجر","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }

            if (_type == enType.withItems)
            {
                if(dtSubPurchase.Rows.Count ==0)
                {

                    MessageBox.Show("!!أضف بند", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                
                }
            }

            if (_SetPurchase())
            {
                MessageBox.Show("تم الحفظ بنجاح", "نجحت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(_type == enType.withItems)
                {
                    _SetPurchaseSub();
                }

               if( MessageBox.Show("هل تريد الاستمرار؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    _mode = enMode.Update;
                    AddEditPurchase_Load(null, null);
                }
                else
                {
                    _mode = enMode.Addnew;

                    _PurchaseID = null;
                    AddEditPurchase_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            _SetTotalAmountBeforeTax();
        }


        private void _GetAllCategories()
        {
            DataTable dt = clsPurchase_Category.GetAllPurchase_Categories();
            cmbCategoryList.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cmbCategoryList.Items.Add(dr["CategoryName"].ToString());
            }

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
           frmAddEditePCategories pCategories = new frmAddEditePCategories();
            pCategories.DataBackCategoryInfo += PCategories_DataBackCategoryInfo;
            pCategories.ShowDialog();
        }

        private void PCategories_DataBackCategoryInfo(object sender, frmAddEditePCategories.CategoryInfoArgs categoryInfo)
        {
            _GetAllCategories();
            cmbCategoryList.SelectedItem = categoryInfo.CategoryName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditeSubPurchase addEditeSubPurchase = new frmAddEditeSubPurchase();
            addEditeSubPurchase.OnProductInfo += AddEditeSubPurchase_OnProductInfo;
            addEditeSubPurchase.ShowDialog();
            _SumAllProduct();
        }

        private void AddEditeSubPurchase_OnProductInfo(object sender, frmAddEditeSubPurchase.ProductInfoArgs e)
        {
            if(e.RowCount == null)
            {
                dtSubPurchase.Rows.Add(
              _NextRowNumber,
              e.ProductID,
              e.ProductName,
              e.ProductSizeID,
              e.ProductSizeName,
              e.ProductDescription,
              e.Quantity,
              e.PricePerUnit,
              e.Total);
                _NextRowNumber++;
            }
            else
            {
                int RowCount = e.RowCount - 1??0;
                dtSubPurchase.Rows[RowCount]["ProductID"] = e.ProductID.ToString();
                dtSubPurchase.Rows[RowCount]["ProductName"] = e.ProductName.ToString();

                //
                int SizeID = e.ProductSizeID ?? -1;
                if(SizeID ==-1)
                dtSubPurchase.Rows[RowCount]["SizeID"] = DBNull.Value;
                else
                dtSubPurchase.Rows[RowCount]["SizeID"] = e.ProductSizeID;
                //
                dtSubPurchase.Rows[RowCount]["SizeName"] = "";
                dtSubPurchase.Rows[RowCount]["Description"] = e.ProductDescription;
                dtSubPurchase.Rows[RowCount]["Quantity"] = e.Quantity.ToString();
                dtSubPurchase.Rows[RowCount]["ItemPrice"] = e.PricePerUnit.ToString();
                dtSubPurchase.Rows[RowCount]["TotalAmount"] = e.Total.ToString();
                dtSubPurchase.Rows[RowCount]["ItemPrice"] = e.PricePerUnit.ToString();

            }

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow drSubPurchase = dgvSubPurchase.CurrentRow;

            float.TryParse(drSubPurchase.Cells["Quantity"].Value.ToString(), out float quantity);
            float.TryParse(drSubPurchase.Cells["ItemPrice"].Value.ToString(), out float ItemPrice);
            int.TryParse(drSubPurchase.Cells["SizeID"].Value.ToString(), out int sSizeID);
            int.TryParse(drSubPurchase.Cells["RowCount"].Value.ToString(), out int rrowCount);
            int productId = (int)drSubPurchase.Cells["ProductID"].Value;
            string description = drSubPurchase.Cells["Description"].Value.ToString();

            int? SizeID = sSizeID;
           
            int? rowCount = rrowCount;
            
           

            frmAddEditeSubPurchase addEditeSubPurchase = new frmAddEditeSubPurchase(
                rowCount,
                productId,
                description,
                SizeID ==0?null: SizeID,
                quantity,
                ItemPrice
            );


            addEditeSubPurchase.OnProductInfo += AddEditeSubPurchase_OnProductInfo;
            addEditeSubPurchase.ShowDialog();
            _SumAllProduct();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int RowCount= (int)dgvSubPurchase.CurrentRow.Cells["RowCount"].Value;

            int RowPositon = RowCount - 1;
            dtSubPurchase.Rows[RowPositon].Delete();

            if(dtSubPurchase.Rows.Count >0)
            {
                for(int i = RowPositon; i < dtSubPurchase.Rows.Count; i++)
                {
                    dtSubPurchase.Rows[i]["RowCount"] = RowCount;
                    RowCount++;
                }

            }

            _NextRowNumber = RowCount;

            _SumAllProduct();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            _SetPurchaseSub();
        }

        private void cbIncludTax_CheckedChanged(object sender, EventArgs e)
        {
            float totalAmount = Convert.ToSingle(txtTotalAmount.Text);
            if (cbIncludTax.Checked)
            {
                 totalAmount = Convert.ToSingle(txtTotalAmount.Text);
                txtTotalAmount.Text = (totalAmount / clsGlobal.Taxprec).ToString();

            }else
            {
                totalAmount = Convert.ToSingle(txtTotalAmount.Text);
                txtTotalAmount.Text = (totalAmount * clsGlobal.Taxprec).ToString();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
