using HomeC_Business;
using HomeConsuption.Purchase.Purchase_Categories;
using HomeConsuption.Purchase.Purchase_Sub_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.Purchase.Purchase_Sub_Categories
{
    public partial class frmPurchseSubCategoriesList : Form
    {
        public frmPurchseSubCategoriesList()
        {
            InitializeComponent();
        }

        enum enMode { All,Category}

        private enMode _mode = enMode.All;


        private static DataTable _dAllData;
        private DataTable _dData;
        clsPurchase_Category _objPCategory;

        private void _GetAllCategories()
        {
            DataTable dt = clsPurchase_Category.GetAllPurchase_Categories();
            cmbCategories.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cmbCategories.Items.Add(dr["CategoryName"].ToString());
            }
            if (cmbCategories.Items.Count > 0)
                cmbCategories.SelectedIndex = 0;
        }

        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            _GetAllCategories();
            cbAllCategories.Checked = true;
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void _RefreshStoresList()
        {
            if(_mode == enMode.All) 
            _dAllData = clsPurchase_SubCategory.GetAllPurchase_SubCategories();
            else
            _dAllData = clsPurchase_SubCategory.GetAllPurchase_SubCategoriesByPCategory(_objPCategory.PCategoryID);

            if(_dAllData ==null || _dAllData.Rows.Count ==0)
            {
                dgvList.DataSource = null;
                return;
            }
            _dData = _dAllData.DefaultView.ToTable(false, "PSCategoryID", "SubCategoryName");

            RefreshdgvStoresHeaders();
        }

        private void RefreshdgvStoresHeaders()
        {
            dgvList.DataSource = _dData;

            if (dgvList.RowCount > 0)
            {
                
                dgvList.Columns["PSCategoryID"].HeaderText = "الرقم";


                dgvList.Columns["SubCategoryName"].HeaderText = "أسم المجموعة";




            }
        }

        private void _SearchStores(string CategoryName)
        {


            _dData.DefaultView.RowFilter = string.Format("[CategoryName] like '%{0}%'", CategoryName);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                _SearchStores(textBox1.Text);
            }
            else
            {
                Parallel.Invoke(() => _RefreshStoresList());

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditePSubCategory addEditePSubCategory = new frmAddEditePSubCategory();
            addEditePSubCategory.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditePSubCategory AddEditePSubCategory = new frmAddEditePSubCategory((int)dgvList.CurrentRow.Cells[0].Value);
            AddEditePSubCategory.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPurchase_SubCategory.DeletePurchase_SubCategories((int)dgvList.CurrentRow.Cells[0].Value);
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _objPCategory = clsPurchase_Category.FindPurchase_Category(cmbCategories.SelectedItem.ToString());
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void cbAllCategories_CheckedChanged(object sender, EventArgs e)
        {
            _mode = cbAllCategories.Checked?enMode.All:enMode.Category;

            cmbCategories.Enabled = !cbAllCategories.Checked;
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddPurchaseSubBaseCategories addPurchaseSubBaseCategories = new frmAddPurchaseSubBaseCategories();
            addPurchaseSubBaseCategories.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }
    }
}
