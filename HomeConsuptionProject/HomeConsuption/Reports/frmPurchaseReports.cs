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
    }
}
