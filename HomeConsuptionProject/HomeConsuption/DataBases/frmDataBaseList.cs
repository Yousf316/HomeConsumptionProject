using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace HomeConsuption.DataBases
{
    public partial class frmDataBaseList : Form
    {
        public frmDataBaseList()
        {
            InitializeComponent();
        }
        private void _LoadConnectionStrings()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("ConnectionString");

            foreach (ConnectionStringSettings connectionString in ConfigurationManager.ConnectionStrings)
            {
                DataRow row = dataTable.NewRow();
                row["Name"] = connectionString.Name;
                row["ConnectionString"] = connectionString.ConnectionString;
                dataTable.Rows.Add(row);
            }

            dgvDBs.DataSource = dataTable;

            dgvDBs.Columns["Name"].HeaderText = "الاسم المستعار";
            dgvDBs.Columns["ConnectionString"].HeaderText = "مسار قاعدة البيانات";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvDBs.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
        }
        private void frmDataBaseList_Load(object sender, EventArgs e)
        {
            _LoadConnectionStrings();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditeDataBase frmAddStore = new frmAddEditeDataBase();
            frmAddStore.ShowDialog();

            Parallel.Invoke(() => _LoadConnectionStrings());
        }





        private void _DeleteConnectionString(string name)
        {
            // Open the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Check if the connection string exists
            if (config.ConnectionStrings.ConnectionStrings[name] != null)
            {
                // Update the connection string

                config.ConnectionStrings.ConnectionStrings.Remove(config.ConnectionStrings.ConnectionStrings[name]);



                // Save the configuration file
                config.Save(ConfigurationSaveMode.Modified);

                // Refresh the section to reflect the changes
                ConfigurationManager.RefreshSection("connectionStrings");

                Console.WriteLine("Connection string Deleted successfully.");
            }
            else
            {
                Console.WriteLine("Connection string not found.");
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeDataBase frmAddStore = new frmAddEditeDataBase(dgvDBs.CurrentRow.Cells["Name"].Value.ToString(), dgvDBs.CurrentRow.Cells["ConnectionString"].Value.ToString());
            frmAddStore.ShowDialog();

            Parallel.Invoke(() => _LoadConnectionStrings());
        }

        private void حذفالمتجرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteConnectionString(dgvDBs.CurrentRow.Cells["Name"].Value.ToString());
            Parallel.Invoke(() => _LoadConnectionStrings());
        }
    }
}
