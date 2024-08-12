using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.DataBases
{
    public partial class frmAddEditeDataBase : Form
    {

        enum enMode { New,Update}
        enMode _mode;
        public frmAddEditeDataBase()
        {
            InitializeComponent();
            _mode = enMode.New;
        }
        public frmAddEditeDataBase(string Name, string connectionString)
        {
            InitializeComponent();
            txtDataBaseName.Text = connectionString;
            txtNickName.Text = Name;
            _mode = enMode.Update;
        }
        private void AddConnectionString(string name, string connectionString)
        {
            // Open the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Check if the connection string already exists
            if (config.ConnectionStrings.ConnectionStrings[name] != null)
            {
                Console.WriteLine("Connection string already exists.");
                return;
            }

            // Create a new connection string
            ConnectionStringSettings newConnectionString = new ConnectionStringSettings(name, connectionString);

            // Add the connection string to the configuration
            config.ConnectionStrings.ConnectionStrings.Add(newConnectionString);

            // Save the configuration file
            config.Save(ConfigurationSaveMode.Modified);

            // Refresh the section to reflect the changes
            ConfigurationManager.RefreshSection("connectionStrings");

           MessageBox.Show("تمت العملية بنجاح","نجحت العملية",MessageBoxButtons.OK);
        }


        private void UpdateConnectionString(string name, string newConnectionString)
        {
            // Open the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Check if the connection string exists
            if (config.ConnectionStrings.ConnectionStrings[name] != null)
            {
                // Update the connection string
                config.ConnectionStrings.ConnectionStrings[name].ConnectionString = newConnectionString;

                // Save the configuration file
                config.Save(ConfigurationSaveMode.Modified);

                // Refresh the section to reflect the changes
                ConfigurationManager.RefreshSection("connectionStrings");

                Console.WriteLine("Connection string updated successfully.");
            }
            else
            {
                Console.WriteLine("Connection string not found.");
            }
        }

        private void DeleteConnectionString(string name)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_mode == enMode.New)
            {
                AddConnectionString(txtNickName.Text, txtDataBaseName.Text);
            }else
            {
                UpdateConnectionString(txtNickName.Text, txtDataBaseName.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
