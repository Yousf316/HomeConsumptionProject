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

namespace HomeConsuption.Product.Sizes
{
    public partial class frmAddEditeSize : Form
    {
        public frmAddEditeSize()
        {
            InitializeComponent();
        }
        enum enMode { AddNew, Update }

        enMode _mode = enMode.AddNew;
        public class SizeInfoArgs : EventArgs
        {
            public int SizeID { get; }
            public string SizeName { get; }

            public SizeInfoArgs(int SizeID, string SizeName)
            {
                this.SizeID = SizeID;
                this.SizeName = SizeName;
            }
        }

        public delegate void CallbackSizeID(object sender, SizeInfoArgs categoryInfo);

        public event CallbackSizeID DataBackSizeID;


        int _SizeID;
        clsSize _objSize;
        public frmAddEditeSize(int sizeID)
        {
            InitializeComponent();
            _SizeID = sizeID;
             _mode = enMode.Update;
        }

        private void _GetDefaultValues()
        {
            _objSize = new clsSize();
            lbID.Text = "[????]";
            txtCateName.Text = "";
        }
        private void _SetSizeInfo()
        {
            _objSize = clsSize.FindSize(_SizeID);
            lbID.Text = _objSize.SizeID.ToString();
            txtCateName.Text = _objSize.SizeName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _objSize.SetParameters(txtCateName.Text);

            if (_objSize.SaveSizes())
            {
                lbID.Text = _objSize.SizeID.ToString();

                MessageBox.Show("تمت العملية بنجاح", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SizeInfoArgs categoryA = new SizeInfoArgs(_objSize.SizeID, _objSize.SizeName);
                DataBackSizeID?.Invoke(this, categoryA);

            }
            else
            {
                MessageBox.Show("فشلت العملية", "فشلت العملية ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            if (_mode == enMode.AddNew)
            {
                _GetDefaultValues();
            }
            else
            {
                _SetSizeInfo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

    }
}
