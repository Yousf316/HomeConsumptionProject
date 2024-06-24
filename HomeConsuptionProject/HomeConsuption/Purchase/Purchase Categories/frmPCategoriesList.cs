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

namespace HomeConsuption.Purchase.Purchase_Categories
{
    public partial class frmPCategoriesList : Form
    {
        public frmPCategoriesList()
        {
            InitializeComponent();
        }


        private static DataTable _dAllData;
        private DataTable _dData;


        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void _RefreshStoresList()
        {
            _dAllData = clsPurchase_Category.GetAllPurchase_Categories();
            _dData = _dAllData.DefaultView.ToTable(false, "PCategoryID", "CategoryName");

            RefreshdgvStoresHeaders();
        }

        private void RefreshdgvStoresHeaders()
        {
            dgvList.DataSource = _dData;

            if (dgvList.RowCount > 0)
            {
                dgvList.Columns["PCategoryID"].HeaderText = "الرقم";


                dgvList.Columns["CategoryName"].HeaderText = "أسم المجموعة";




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
          frmAddEditePCategories addEditePCategories = new frmAddEditePCategories();
            addEditePCategories.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditePCategories pCategoriesEdite = new frmAddEditePCategories( (int)dgvList.CurrentRow.Cells[0].Value);
            pCategoriesEdite.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( clsPurchase_Category.DeletePurchase_Categories((int)dgvList.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("تم حذف الصنف رئيسي", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" الصنف مرتبط مع بيانات اخرى", "فشلت العملية ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
