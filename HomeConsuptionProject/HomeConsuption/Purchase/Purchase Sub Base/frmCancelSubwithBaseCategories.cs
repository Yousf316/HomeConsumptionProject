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

namespace HomeConsuption.Purchase.Purchase_Sub_Base
{
    public partial class frmCancelSubwithBaseCategories : Form
    {

        clsPurchase_Category _purchase_Category;

        

        clsPurchase_SubCategory _purchase_SubCategory;

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
            DataTable dt = clsPurchase_SubCategory.GetAllPurchase_SubCategoriesByPCategory(_purchase_Category.PCategoryID);
            cmbSubCategories.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cmbSubCategories.Items.Add(dr["SubCategoryName"].ToString());
            }
            if (cmbSubCategories.Items.Count > 0)
                cmbSubCategories.SelectedIndex = 0;
            else
            {
                cmbSubCategories.Items.Add("لا يوجد صنف فرعي");
                cmbSubCategories.SelectedIndex = 0;
            }
        }
        public frmCancelSubwithBaseCategories()
        {
            InitializeComponent();
        }

        private void frmCancelSubwithBaseCategories_Load(object sender, EventArgs e)
        {
            _GetAllCategories();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _purchase_Category = clsPurchase_Category.FindPurchase_Category(cmbCategories.SelectedItem.ToString());
            _GetAllSubCategories();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if( clsPurchaseSubBaseCategories.DeleteSubBaseCategory(_purchase_Category.PCategoryID,_purchase_SubCategory.PSCategoryID))
            {
                MessageBox.Show("تم الغاء الربط بنجاح","تمت العملية بنجاح",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("الصنف مرتبط بفواتير", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmbSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _purchase_SubCategory = clsPurchase_SubCategory.FindPurchase_SubCategories(cmbSubCategories.SelectedItem.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
