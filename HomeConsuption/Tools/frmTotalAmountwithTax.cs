using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.Tools
{
    public partial class frmTotalAmountwithTax : Form
    {

        public delegate void TotalAmountBeforeTax (object sender ,double amountBeforeTax);

        public event TotalAmountBeforeTax BackAmountBeforeTax;
        public frmTotalAmountwithTax()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text==""))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void _SetDefaultValues()
        {
            txtTaxAmount.Text = "0.00";
            txtPricewithTax.Text = "0.00";
            txtTotalAfterTax.Text = "0.00";
            txtTotalAmount.Text = "0.00";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtPricewithTax.Text=="")
            {
                _SetDefaultValues();
                return;
            }
            double TotalAmountwithTax = Convert.ToSingle(txtPricewithTax.Text);

            double TotalAmountwithoutTax = (TotalAmountwithTax /1.15);

            txtTotalAmount.Text = TotalAmountwithoutTax.ToString();


        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            double TotalAmountwithoutTax =Convert.ToSingle( txtTotalAmount.Text);

            double TotalAmountwithTax = TotalAmountwithoutTax * 1.15;

            txtTaxAmount.Text = (TotalAmountwithTax-TotalAmountwithoutTax).ToString();

            txtTotalAfterTax.Text = TotalAmountwithTax.ToString();
        }

        private void frmTotalAmountwithTax_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double TotalAmountwithoutTax = Convert.ToSingle(txtTotalAmount.Text);
            BackAmountBeforeTax?.Invoke(this, TotalAmountwithoutTax);

            this.Close();
        }
    }
}
