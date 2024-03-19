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
        public frmCancelSubwithBaseCategories()
        {
            InitializeComponent();
        }
    }
}
