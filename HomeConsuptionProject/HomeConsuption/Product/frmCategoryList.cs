﻿using HomeC_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.Product
{
    public partial class frmCategoryList : Form
    {
        public frmCategoryList()
        {
            InitializeComponent();
        }

        private static DataTable _dAllStores;
        private DataTable _dStores;


        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void _RefreshStoresList()
        {
            _dAllStores = clsCategory.GetAllCatgoriesInfo();
            if(_dAllStores != null)
            _dStores = _dAllStores.DefaultView.ToTable(false, "CategoryID", "CategoryName");

            RefreshdgvStoresHeaders();
        }

        private void RefreshdgvStoresHeaders()
        {
            dgvList.DataSource = _dStores;

            if (dgvList.RowCount > 0)
            {
                dgvList.Columns["CategoryID"].HeaderText = "الرقم";
                

                dgvList.Columns["CategoryName"].HeaderText = "أسم المجموعة";
                

             

            }
        }

        private void _SearchStores(string CategoryName)
        {
       
            if(_dStores != null) 
            _dStores.DefaultView.RowFilter = string.Format("[CategoryName] like '%{0}%'", CategoryName);

           
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
            frmAddEditCategory AddEditCategory = new frmAddEditCategory();
            AddEditCategory.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCategory addEditCategory = new frmAddEditCategory((int)dgvList.CurrentRow.Cells[0].Value);
            addEditCategory.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }
    }
}
