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
using static HomeConsuption.Purchase.Purchase_Sub_Categories.frmAddEditePSubCategory;

namespace HomeConsuption.Purchase.Purchase_Sub_Base
{
    public partial class frmAddPurchaseSubBaseCategories : Form
    {
        public frmAddPurchaseSubBaseCategories()
        {
            InitializeComponent();
        }

        clsPurchase_SubCategory _SubCategory { get => clsPurchase_SubCategory.FindPurchase_SubCategories(cmbSubCategories.SelectedItem.ToString()); }
        clsPurchase_Category _Category { get => clsPurchase_Category.FindPurchase_Category(cmbCategories.SelectedItem.ToString()); }


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
        private void _GetAllSubCategories()
        {
            DataTable dt = clsPurchase_SubCategory.GetAllPurchase_SubCategories();
            cmbSubCategories.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cmbSubCategories.Items.Add(dr["SubCategoryName"].ToString());
            }
            if (cmbSubCategories.Items.Count > 0)
                cmbSubCategories.SelectedIndex = 0;
        }

        private void frmPurchaseSubBaseCategories_Load(object sender, EventArgs e)
        {
            _GetAllCategories();
            _GetAllSubCategories();




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetSubBaseCategory()
        {

            clsPurchaseSubBaseCategories subBaseCategories = new clsPurchaseSubBaseCategories();

            subBaseCategories.SetValues(_SubCategory.PSCategoryID, _Category.PCategoryID);

            if (subBaseCategories.SavePurchaseSubBaseCategories())
            {

                MessageBox.Show(" تم ربط الصنف", "نجحت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                MessageBox.Show(" لم يتم ربط الصنف", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPurchaseSubBaseCategories subBaseCategories =  clsPurchaseSubBaseCategories.FindPurchaseSubBaseCategoriesData(_SubCategory.PSCategoryID,_Category.PCategoryID);
            if (subBaseCategories == null)
                _SetSubBaseCategory();
            else
                MessageBox.Show("!!الصنف مرتبط","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
