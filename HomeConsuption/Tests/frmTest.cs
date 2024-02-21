using HomeConsuption.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption.Tests
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            string path = @"D:\Projects\HomeConsuptionProject\HomeConsuption\Resources\icons8-product-96.png";
            pictureBox1.ImageLocation = path;
            textBox1.Text = pictureBox1.ImageLocation.ToString();
        }
    }
}
