namespace HomeConsuption.People
{
    partial class frmShowPersonDetails
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
            this.ctrShowPerson1 = new HomeConsuption.ctrShowPerson();
            this.SuspendLayout();
            // 
            // ctrShowPerson1
            // 
            this.ctrShowPerson1.Location = new System.Drawing.Point(12, 26);
            this.ctrShowPerson1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrShowPerson1.Name = "ctrShowPerson1";
            this.ctrShowPerson1.obPerson = null;
            this.ctrShowPerson1.Size = new System.Drawing.Size(449, 358);
            this.ctrShowPerson1.TabIndex = 0;
            // 
            // frmShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 395);
            this.Controls.Add(this.ctrShowPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPersonDetails";
            this.Text = "المعلومات الشخصية";
            this.Load += new System.EventHandler(this.frmShowPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrShowPerson ctrShowPerson1;
    }
}