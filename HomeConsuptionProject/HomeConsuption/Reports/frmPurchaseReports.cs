using HomeC_Business;
using System;

using System.Data;
using System.Diagnostics.Eventing.Reader;
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

               lbTotall.Text = _CalculateAllTreeViewNodes(false).ToString("F2");
                return;
            }

            if (cbAllCategories.Checked && !cbAllDate.Checked)
            {
                lbTotall.Text = _CalculateAllTreeViewNodes(true).ToString("F2");
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
            DataTable dtBaseCategories = clsPurchase_Category.GetAllPurchase_Categories();
            DataTable dtSubCategories;
            tvCategories.Nodes.Clear();
            foreach (DataRow dr in dtBaseCategories.Rows)
            {
                string CategoryName = dr["CategoryName"].ToString();
                tvCategories.Nodes.Add(CategoryName, CategoryName) ;

                dtSubCategories = clsPurchaseSubBaseCategories.GetAllPurchase_SubBaseCategoriesByPCategory(CategoryName);

                foreach (DataRow drSub in dtSubCategories.Rows)
                {
                    tvCategories.Nodes[CategoryName].Nodes.Add(drSub["SubCategoryName"].ToString());
                }

              
            }

            tvCategories.CheckBoxes = true;
        }

        private void tvCategories_AfterCheck(object sender, TreeViewEventArgs e)
        {

            //if(e.Node.Checked)
            //{
            //    MessageBox.Show(e.Node.Text);

            //}
        }

        private float _CalculateAllTreeViewNodes(bool WithDate = false)
        {
          
            float Total = 0;
            float TotalPerItem = 0;
            dgvList.Rows.Clear();

            foreach (TreeNode item in tvCategories.Nodes)
            {

               

                    if (WithDate)
                    {

                    if (cbAllDays.Checked)
                    {
                        int Days = (DateTime.DaysInMonth(dtpFrom.Value.Year, dtpTo.Value.Month));
                        TotalPerItem = clsPurchase.GetTotalAllPurchases(item.Text, $"{dtpFrom.Value.Month}/{1}/{dtpFrom.Value.Year}", $"{dtpTo.Value.Month}/{Days}/{dtpTo.Value.Year}");

                    }
                    else
                    {
                        TotalPerItem = clsPurchase.GetTotalAllPurchases(item.Text, dtpFrom.Value.ToString("d"), dtpTo.Value.ToString("d"));

                    }

                }
                    else
                    {
                        TotalPerItem = clsPurchase.GetTotalAllPurchases(item.Text);

                    }
                if (TotalPerItem > 0)
                    dgvList.Rows.Add( TotalPerItem.ToString("F2"), item.Text);

                Total += TotalPerItem;
                

            }

            return Total;

        }


        private float _CalculateTreeViewNodes(bool WithDate =false)
        {
            float Total = 0;
            float TotalPerItem = 0;
            dgvList.Rows.Clear();
            foreach (TreeNode item in tvCategories.Nodes)
            {

              if ( item.Checked)
                {

                    if( WithDate )
                    {
                     
                        if(cbAllDays.Checked)
                        {
                            int Days = (DateTime.DaysInMonth(dtpFrom.Value.Year, dtpTo.Value.Month));
                            TotalPerItem = clsPurchase.GetTotalAllPurchases(item.Text, $"{dtpFrom.Value.Month}/{1}/{dtpFrom.Value.Year}", $"{dtpTo.Value.Month}/{Days}/{dtpTo.Value.Year}");

                        }else
                        {
                            TotalPerItem = clsPurchase.GetTotalAllPurchases(item.Text, dtpFrom.Value.ToString("d"), dtpTo.Value.ToString("d"));

                        }





                    }else
                    {
                        TotalPerItem = clsPurchase.GetTotalAllPurchases(item.Text);

                    }
                    if( TotalPerItem > 0 )
                    dgvList.Rows.Add(TotalPerItem.ToString("F2"), item.Text);

                    Total += TotalPerItem;
                }else
                {
                    Total += _CalculateTreeViewNodesChildern(item.Text, WithDate);
                }

            }
            return Total;   

        }

        private float _CalculateTreeViewNodesChildern(string BaseCatrgotyName,bool WithDate = false)
        {
            float Total = 0;
            float TotalPerItem = 0;
            
            foreach (TreeNode item in tvCategories.Nodes[BaseCatrgotyName].Nodes)
            {

                if (item.Checked)
                {

                    if (WithDate)
                    {

                        if (cbAllDays.Checked)
                        {
                            int Days = (DateTime.DaysInMonth(dtpFrom.Value.Year, dtpTo.Value.Month));
                            TotalPerItem = clsPurchase.GetTotalAllPurchases(BaseCatrgotyName, item.Text, $"{dtpFrom.Value.Month}/{1}/{dtpFrom.Value.Year}", $"{dtpTo.Value.Month}/{Days}/{dtpTo.Value.Year}");

                        }
                        else
                        {
                            TotalPerItem = clsPurchase.GetTotalAllPurchases(BaseCatrgotyName, item.Text, dtpFrom.Value.ToString("d"), dtpTo.Value.ToString("d"));

                        }





                    }
                    else
                    {
                        TotalPerItem = clsPurchase.GetTotalAllPurchasesBySubBaseCategory(BaseCatrgotyName, item.Text);

                    }
                    if (TotalPerItem > 0)
                        dgvList.Rows.Add(TotalPerItem.ToString("F2"), item.Text);

                    Total += TotalPerItem;
                }

            }
            return Total;

        }

        private void cbAllDays_CheckedChanged(object sender, EventArgs e)
        {
            if( cbAllDays.Checked )
            {
                dtpFrom.CustomFormat = "MMMM";
                dtpTo.CustomFormat = "MMMM";
            }else
            {
                dtpFrom.CustomFormat = "MM/dd/yyyy";
                dtpTo.CustomFormat = "MM/dd/yyyy";
            }
        }
    }
}
