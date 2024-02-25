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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HomeConsuption
{
    public partial class frmListStores : Form
    {
        public delegate void CallbackStoreID(object sender,int StoreID);

        public event CallbackStoreID DataBack_StoreID;
        // Create a method for a delegate.
        protected static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }


        public frmListStores()
        {
            InitializeComponent();
            Parallel.Invoke(() => _RefreshStoresList()); 
        }

        private static DataTable _dAllStores;
        private DataTable _dStores ;


        private void _RefreshStoresList()
        {
            _dAllStores = clsStore.GetAllStores();

            if (_dAllStores.Rows.Count == 0)
                return;

            _dStores = _dAllStores.DefaultView.ToTable(false, "StoreID", "StoreName", "StoreLocation");

            RefreshdgvStoresHeaders();
        }

        private void RefreshdgvStoresHeaders()
        {
            dgvStores.DataSource = _dStores;

            if (dgvStores.RowCount > 0)
            {
                dgvStores.Columns["StoreID"].HeaderText = "الرقم";
                dgvStores.Columns["StoreID"].Width = 110;

                dgvStores.Columns["StoreName"].HeaderText = "أسم المتجر";
                dgvStores.Columns["StoreName"].Width = 230;

                dgvStores.Columns["StoreLocation"].HeaderText = "موقع المتجر";
                dgvStores.Columns["StoreLocation"].Width = 175;


            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditStore frmAddStore = new frmAddEditStore();
            frmAddStore.ShowDialog();

            Parallel.Invoke(() => _RefreshStoresList());

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditStore editStore = new frmAddEditStore((int)dgvStores.CurrentRow.Cells["StoreID"].Value);
            editStore.ShowDialog();
            Parallel.Invoke(() => _RefreshStoresList());
        }

        private void _SearchStores(string StoreName)
        {
        


            _dStores.DefaultView.RowFilter = string.Format("[StoreName] like '%{0}%'", StoreName); 

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                _SearchStores(textBox1.Text);
            }
            else
            {
                Parallel.Invoke(() => _RefreshStoresList());

            }
        }

        private void dgvStores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int StoreID = (int)dgvStores.CurrentRow.Cells["StoreID"].Value;
            DataBack_StoreID?.Invoke(this, StoreID);
        }

        private void frmListStores_Load(object sender, EventArgs e)
        {

        }
    }
}
