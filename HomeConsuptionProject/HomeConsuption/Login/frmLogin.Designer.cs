namespace HomeConsuption.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.rjbtnOk = new CustomControls.RJControls.RJButton();
            this.rjbtnClose = new CustomControls.RJControls.RJButton();
            this.rjtxtUserName = new HomeConsuption.RJControls.RJTextBox();
            this.rjtxtPassword = new HomeConsuption.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المسخدم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة المرور :";
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.chkRememberMe.Location = new System.Drawing.Point(342, 257);
            this.chkRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(54, 18);
            this.chkRememberMe.TabIndex = 5;
            this.chkRememberMe.Text = "تذكر ";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            this.chkRememberMe.CheckedChanged += new System.EventHandler(this.chkRememberMe_CheckedChanged);
            // 
            // rjbtnOk
            // 
            this.rjbtnOk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnOk.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnOk.BorderRadius = 5;
            this.rjbtnOk.BorderSize = 0;
            this.rjbtnOk.FlatAppearance.BorderSize = 0;
            this.rjbtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjbtnOk.ForeColor = System.Drawing.Color.White;
            this.rjbtnOk.Location = new System.Drawing.Point(375, 316);
            this.rjbtnOk.Name = "rjbtnOk";
            this.rjbtnOk.Size = new System.Drawing.Size(103, 31);
            this.rjbtnOk.TabIndex = 8;
            this.rjbtnOk.Text = "ارسال";
            this.rjbtnOk.TextColor = System.Drawing.Color.White;
            this.rjbtnOk.UseVisualStyleBackColor = false;
            this.rjbtnOk.Click += new System.EventHandler(this.rjbtnOk_Click);
            // 
            // rjbtnClose
            // 
            this.rjbtnClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnClose.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnClose.BorderRadius = 5;
            this.rjbtnClose.BorderSize = 0;
            this.rjbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rjbtnClose.FlatAppearance.BorderSize = 0;
            this.rjbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjbtnClose.ForeColor = System.Drawing.Color.White;
            this.rjbtnClose.Location = new System.Drawing.Point(231, 316);
            this.rjbtnClose.Name = "rjbtnClose";
            this.rjbtnClose.Size = new System.Drawing.Size(103, 31);
            this.rjbtnClose.TabIndex = 9;
            this.rjbtnClose.Text = "خروج";
            this.rjbtnClose.TextColor = System.Drawing.Color.White;
            this.rjbtnClose.UseVisualStyleBackColor = false;
            this.rjbtnClose.Click += new System.EventHandler(this.rjbtnClose_Click);
            // 
            // rjtxtUserName
            // 
            this.rjtxtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxtUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtxtUserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtxtUserName.BorderSize = 2;
            this.rjtxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtUserName.Location = new System.Drawing.Point(295, 128);
            this.rjtxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtUserName.Multiline = false;
            this.rjtxtUserName.Name = "rjtxtUserName";
            this.rjtxtUserName.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtUserName.PasswordChar = false;
            this.rjtxtUserName.Size = new System.Drawing.Size(163, 31);
            this.rjtxtUserName.TabIndex = 10;
            this.rjtxtUserName.Texts = "";
            this.rjtxtUserName.UnderlinedStyle = true;
            // 
            // rjtxtPassword
            // 
            this.rjtxtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtxtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtxtPassword.BorderSize = 2;
            this.rjtxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtPassword.Location = new System.Drawing.Point(295, 186);
            this.rjtxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtPassword.Multiline = false;
            this.rjtxtPassword.Name = "rjtxtPassword";
            this.rjtxtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtPassword.PasswordChar = true;
            this.rjtxtPassword.Size = new System.Drawing.Size(163, 31);
            this.rjtxtPassword.TabIndex = 11;
            this.rjtxtPassword.Texts = "";
            this.rjtxtPassword.UnderlinedStyle = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.rjbtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rjbtnClose;
            this.ClientSize = new System.Drawing.Size(703, 466);
            this.Controls.Add(this.rjtxtPassword);
            this.Controls.Add(this.rjtxtUserName);
            this.Controls.Add(this.rjbtnClose);
            this.Controls.Add(this.rjbtnOk);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private CustomControls.RJControls.RJButton rjbtnOk;
        private CustomControls.RJControls.RJButton rjbtnClose;
        private RJControls.RJTextBox rjtxtUserName;
        private RJControls.RJTextBox rjtxtPassword;
    }
}