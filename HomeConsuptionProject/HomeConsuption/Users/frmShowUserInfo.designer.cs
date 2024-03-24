namespace HomeConsuption
{
    partial class frmShowUserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrShowUserInfo1 = new HomeConsuption.ctrShowUserInfo();
            this.SuspendLayout();
            // 
            // ctrShowUserInfo1
            // 
            this.ctrShowUserInfo1.Location = new System.Drawing.Point(-8, 35);
            this.ctrShowUserInfo1.Name = "ctrShowUserInfo1";
            this.ctrShowUserInfo1.Size = new System.Drawing.Size(1064, 599);
            this.ctrShowUserInfo1.TabIndex = 0;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 662);
            this.Controls.Add(this.ctrShowUserInfo1);
            this.Name = "frmShowUserInfo";
            this.Text = "frmShowUserInfo";
            this.Load += new System.EventHandler(this.frmShowUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrShowUserInfo ctrShowUserInfo1;
    }
}