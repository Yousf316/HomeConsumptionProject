using HomeC_Business;
using HomeConsuption.Purchase.Purchase_Categories;
using HomeConsuption.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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



       private void _SetDgvPurchaseColumn()
        {
            DataTable dataTable =clsPurchase_sub.GetPurchases_subColumns();

            DataTable data = dataTable.DefaultView.ToTable(false,"ItemID","ItemName","Description","ItemPrice","Quantity","TotalAmount");
            dataGridView1.DataSource = data;

            dataGridView1.Columns["ItemID"].HeaderText = "رقم الصنف";
            dataGridView1.Columns["ItemID"].Width = 150;

            dataGridView1.Columns["ItemName"].HeaderText = "اسم الصنف";
            dataGridView1.Columns["ItemName"].Width = 150;

            dataGridView1.Columns["Description"].HeaderText = "الوصف";
            dataGridView1.Columns["Description"].Width = 150;

            dataGridView1.Columns["ItemPrice"].HeaderText = "السعر";
            dataGridView1.Columns["ItemPrice"].Width = 150;

            dataGridView1.Columns["Quantity"].HeaderText = "الكمية";
            dataGridView1.Columns["Quantity"].Width = 150;

            dataGridView1.Columns["TotalAmount"].HeaderText = "المجموع";
            dataGridView1.Columns["TotalAmount"].Width = 150;

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

            txtTotalAfterTax.Text = (Convert.ToSingle(txtTotalBeforeTax.Text) * 1.15f).ToString("F2");

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
                dataGridView1.DataSource = null;
                _TypeID = 1;
            }
            else
            {
                _type = enType.withItems;
                _TypeID = 2;
                _SetDgvPurchaseColumn();
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


       
        private void btnSave_Click(object sender, EventArgs e)
        {
          if(txtStoreID.Text =="")
            {

                MessageBox.Show("اختار متجر","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }

          if(_SetPurchase())
            {
                MessageBox.Show("تم الحفظ بنجاح", "نجحت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(_type == enType.withItems)
                {
                    //will implemmtion soon
                }

               if( MessageBox.Show("هل تريد الاستمرار؟","",MessageBoxButtons.YesNo)==DialogResult.Yes)
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
            pCategories.ShowDialog();
            _GetAllCategories();
        }
<<<<<<< Updated upstream
=======

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditeSubPurchase addEditeSubPurchase = new frmAddEditeSubPurchase();
            addEditeSubPurchase.OnProductInfo += AddEditeSubPurchase_OnProductInfo;
            addEditeSubPurchase.ShowDialog();
        }

        private void AddEditeSubPurchase_OnProductInfo(object sender, frmAddEditeSubPurchase.ProductInfoArgs e)
        {
            
            throw new NotImplementedException();
        }
>>>>>>> Stashed changes
    }
}
