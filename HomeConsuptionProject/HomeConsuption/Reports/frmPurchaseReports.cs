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

namespace HomeConsuption.Reports
{
    public partial class frmPurchaseReports : Form
    {
        public frmPurchaseReports()
        {
            InitializeComponent();
        }

        private void cbAllCategories_CheckedChanged(object sender, EventArgs e)
        {
           if (cbAllCategories.Checked)
                cmbCategories.Enabled = false;
           else
                cmbCategories.Enabled = true;



        }

        private void cbAllDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllDate.Checked)
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;  
            }
            else
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }

        }
        private void _GetAllCategories()
        {
            DataTable dt = clsPurchase_Category.GetAllPurchase_Categories();
            cmbCategories.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cmbCategories.Items.Add(dr["CategoryName"].ToString());
            }

        }
        private void frmPurchaseReports_Load(object sender, EventArgs e)
        {
            _GetAllCategories();
            cmbCategories.SelectedItem = "عام";

            cbAllDate.Checked = true;
            cbAllCategories.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(cbAllCategories.Checked && cbAllDate.Checked)
            {
               lbTotall.Text = clsPurchase.GetTotalAllPurchases().ToString("F2");
                return;
            }

            if (cbAllCategories.Checked && !cbAllDate.Checked)
            {
                lbTotall.Text = clsPurchase.GetTotalAllPurchases(dtpFrom.Value.ToString("d"),dtpTo.Value.ToString("d")).ToString("F2");
                return;
            }


            if (!cbAllCategories.Checked && !cbAllDate.Checked)
            {
                lbTotall.Text = clsPurchase.GetTotalAllPurchases(cmbCategories.SelectedItem.ToString(),dtpFrom.Value.ToString("d"), dtpTo.Value.ToString("d")).ToString("F2");
                return;
            }

             if (!cbAllCategories.Checked && cbAllDate.Checked)
            {
                lbTotall.Text = clsPurchase.GetTotalAllPurchases(cmbCategories.SelectedItem.ToString()).ToString("F2");
                return;
            }


        }
    }
}
