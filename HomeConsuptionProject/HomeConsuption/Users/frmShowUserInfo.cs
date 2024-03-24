
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeConsuption
{
    public partial class frmShowUserInfo : Form
    {
        int UserID;
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            this.UserID=UserID;
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
           ctrShowUserInfo1.GetUserInfo(UserID);
        }
    }
}
