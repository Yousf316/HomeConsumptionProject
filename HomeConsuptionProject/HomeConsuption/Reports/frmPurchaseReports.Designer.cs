namespace HomeConsuption.Reports
{
    partial class frmPurchaseReports
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAllCategories = new System.Windows.Forms.CheckBox();
            this.cbAllDate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotall = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tvCategories = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(690, 245);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(136, 21);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(229, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = ": الصنف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeConsuption.Properties.Resources.icons8_report_96;
            this.pictureBox1.Location = new System.Drawing.Point(361, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label2.Location = new System.Drawing.Point(294, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = " تقرير المشتريات";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(102, 211);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(100, 20);
            this.dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(102, 161);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpFrom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(208, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "من";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(138, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "ألى";
            // 
            // cbAllCategories
            // 
            this.cbAllCategories.AutoSize = true;
            this.cbAllCategories.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbAllCategories.Location = new System.Drawing.Point(30, 98);
            this.cbAllCategories.Name = "cbAllCategories";
            this.cbAllCategories.Size = new System.Drawing.Size(51, 21);
            this.cbAllCategories.TabIndex = 8;
            this.cbAllCategories.Text = "الكل";
            this.cbAllCategories.UseVisualStyleBackColor = true;
            this.cbAllCategories.CheckedChanged += new System.EventHandler(this.cbAllCategories_CheckedChanged);
            // 
            // cbAllDate
            // 
            this.cbAllDate.AutoSize = true;
            this.cbAllDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbAllDate.Location = new System.Drawing.Point(30, 210);
            this.cbAllDate.Name = "cbAllDate";
            this.cbAllDate.Size = new System.Drawing.Size(51, 21);
            this.cbAllDate.TabIndex = 9;
            this.cbAllDate.Text = "الكل";
            this.cbAllDate.UseVisualStyleBackColor = true;
            this.cbAllDate.CheckedChanged += new System.EventHandler(this.cbAllDate_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label5.Location = new System.Drawing.Point(229, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = ": التاريخ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(102, 269);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "تنفيذ";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.tvCategories);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbAllDate);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.cbAllCategories);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(507, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 320);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotall);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(34, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 327);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "التقرير";
            // 
            // lbTotall
            // 
            this.lbTotall.AutoSize = true;
            this.lbTotall.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbTotall.Location = new System.Drawing.Point(111, 86);
            this.lbTotall.Name = "lbTotall";
            this.lbTotall.Size = new System.Drawing.Size(71, 24);
            this.lbTotall.TabIndex = 18;
            this.lbTotall.Text = "[?????]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(254, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = ": المجموع";
            // 
            // tvCategories
            // 
            this.tvCategories.Location = new System.Drawing.Point(80, 27);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.Size = new System.Drawing.Size(143, 128);
            this.tvCategories.TabIndex = 14;
            this.tvCategories.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCategories_AfterCheck);
            // 
            // frmPurchaseReports
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 637);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPurchaseReports";
            this.Text = "تقرير المشتريات";
            this.Load += new System.EventHandler(this.frmPurchaseReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAllCategories;
        private System.Windows.Forms.CheckBox cbAllDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView tvCategories;
    }
}