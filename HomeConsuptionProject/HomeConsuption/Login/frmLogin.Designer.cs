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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDataBaseName = new System.Windows.Forms.ComboBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المسخدم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة المرور :";
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.chkRememberMe.Location = new System.Drawing.Point(398, 457);
            this.chkRememberMe.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(86, 22);
            this.chkRememberMe.TabIndex = 5;
            this.chkRememberMe.Text = "تذكرني ";
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
            this.rjbtnOk.Location = new System.Drawing.Point(439, 521);
            this.rjbtnOk.Margin = new System.Windows.Forms.Padding(4);
            this.rjbtnOk.Name = "rjbtnOk";
            this.rjbtnOk.Size = new System.Drawing.Size(120, 38);
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
            this.rjbtnClose.Location = new System.Drawing.Point(271, 521);
            this.rjbtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.rjbtnClose.Name = "rjbtnClose";
            this.rjbtnClose.Size = new System.Drawing.Size(120, 38);
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
            this.rjtxtUserName.BorderRadius = 0;
            this.rjtxtUserName.BorderSize = 2;
            this.rjtxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtUserName.Location = new System.Drawing.Point(343, 305);
            this.rjtxtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.rjtxtUserName.Multiline = false;
            this.rjtxtUserName.Name = "rjtxtUserName";
            this.rjtxtUserName.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.rjtxtUserName.PasswordChar = false;
            this.rjtxtUserName.Size = new System.Drawing.Size(190, 39);
            this.rjtxtUserName.TabIndex = 10;
            this.rjtxtUserName.Texts = "";
            this.rjtxtUserName.UnderlinedStyle = true;
            // 
            // rjtxtPassword
            // 
            this.rjtxtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtxtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtxtPassword.BorderRadius = 0;
            this.rjtxtPassword.BorderSize = 2;
            this.rjtxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtPassword.Location = new System.Drawing.Point(343, 376);
            this.rjtxtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.rjtxtPassword.Multiline = false;
            this.rjtxtPassword.Name = "rjtxtPassword";
            this.rjtxtPassword.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.rjtxtPassword.PasswordChar = true;
            this.rjtxtPassword.Size = new System.Drawing.Size(190, 39);
            this.rjtxtPassword.TabIndex = 11;
            this.rjtxtPassword.Texts = "";
            this.rjtxtPassword.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeConsuption.Properties.Resources.icons8_online_store_96;
            this.pictureBox1.Location = new System.Drawing.Point(359, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 593);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "الاصدار التجريبي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "قاعدة البيانات :";
            // 
            // cmbDataBaseName
            // 
            this.cmbDataBaseName.FormattingEnabled = true;
            this.cmbDataBaseName.Location = new System.Drawing.Point(343, 254);
            this.cmbDataBaseName.Name = "cmbDataBaseName";
            this.cmbDataBaseName.Size = new System.Drawing.Size(190, 24);
            this.cmbDataBaseName.TabIndex = 15;
            this.cmbDataBaseName.SelectedIndexChanged += new System.EventHandler(this.cmbDataBaseName_SelectedIndexChanged);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 5;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(550, 247);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(171, 31);
            this.rjButton1.TabIndex = 16;
            this.rjButton1.Text = "اعدادات قواعد البيانات";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.rjbtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rjbtnClose;
            this.ClientSize = new System.Drawing.Size(863, 620);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.cmbDataBaseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjtxtPassword);
            this.Controls.Add(this.rjtxtUserName);
            this.Controls.Add(this.rjbtnClose);
            this.Controls.Add(this.rjbtnOk);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDataBaseName;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}