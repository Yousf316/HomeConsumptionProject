using HomeC_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
            {
                tvCategories.Enabled = false;
                tvCategories.CheckBoxes = false;
            }
            else
            {
                tvCategories.Enabled = true;
                tvCategories.CheckBoxes = true;

            }


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
            _SetTvList();
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
                // lbTotall.Text = clsPurchase.GetTotalAllPurchases(cmbCategories.SelectedItem.ToString(),dtpFrom.Value.ToString("d"), dtpTo.Value.ToString("d")).ToString("F2");
                lbTotall.Text = _CalculateTreeViewNodes(true).ToString("F2");
                return;
            }

             if (!cbAllCategories.Checked && cbAllDate.Checked)
            {
                lbTotall.Text = _CalculateTreeViewNodes().ToString("F2");
                return;
            }


        }


        private void _SetTvList()
        {
            DataTable dt = clsPurchase_Category.GetAllPurchase_Categories();
            tvCategories.Nodes.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                tvCategories.Nodes.Add(dr["CategoryName"].ToString()) ;
                tvCategories.CheckBoxes = true;
            }
        }

        private void tvCategories_AfterCheck(object sender, TreeViewEventArgs e)
        {

            //if(e.Node.Checked)
            //{
            //    MessageBox.Show(e.Node.Text);

            //}
        }

        private float _CalculateTreeViewNodes(bool WithDate =false)
        {
            float Total = 0;

            foreach (TreeNode item in tvCategories.Nodes)
            {

              if ( item.Checked)
                {
                    if( WithDate )
                    {
                        Total+= clsPurchase.GetTotalAllPurchases(item.Text, dtpFrom.Value.ToString("d"), dtpTo.Value.ToString("d"));

                    }else
                    {
                        Total +=clsPurchase.GetTotalAllPurchases(item.Text);

                    }
                }

            }
            return Total;   

        }


    }
}
