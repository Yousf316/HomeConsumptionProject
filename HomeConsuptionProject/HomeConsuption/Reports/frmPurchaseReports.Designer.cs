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
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(79, 21);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(136, 21);
            this.cmbCategories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(221, 13);
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
            this.dtpTo.Location = new System.Drawing.Point(94, 121);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(100, 20);
            this.dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(94, 71);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpFrom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(200, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "من";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(130, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "ألى";
            // 
            // cbAllCategories
            // 
            this.cbAllCategories.AutoSize = true;
            this.cbAllCategories.Location = new System.Drawing.Point(27, 23);
            this.cbAllCategories.Name = "cbAllCategories";
            this.cbAllCategories.Size = new System.Drawing.Size(46, 17);
            this.cbAllCategories.TabIndex = 8;
            this.cbAllCategories.Text = "الكل";
            this.cbAllCategories.UseVisualStyleBackColor = true;
            this.cbAllCategories.CheckedChanged += new System.EventHandler(this.cbAllCategories_CheckedChanged);
            // 
            // cbAllDate
            // 
            this.cbAllDate.AutoSize = true;
            this.cbAllDate.Location = new System.Drawing.Point(27, 101);
            this.cbAllDate.Name = "cbAllDate";
            this.cbAllDate.Size = new System.Drawing.Size(46, 17);
            this.cbAllDate.TabIndex = 9;
            this.cbAllDate.Text = "الكل";
            this.cbAllDate.UseVisualStyleBackColor = true;
            this.cbAllDate.CheckedChanged += new System.EventHandler(this.cbAllDate_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label5.Location = new System.Drawing.Point(221, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = ": التاريخ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 179);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "تنفيذ";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbAllDate);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.cbAllCategories);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(507, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 225);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotall);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbToDate);
            this.groupBox1.Controls.Add(this.lbFromDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(34, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "التقرير";
            // 
            // lbTotall
            // 
            this.lbTotall.AutoSize = true;
            this.lbTotall.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbTotall.Location = new System.Drawing.Point(160, 157);
            this.lbTotall.Name = "lbTotall";
            this.lbTotall.Size = new System.Drawing.Size(71, 24);
            this.lbTotall.TabIndex = 18;
            this.lbTotall.Text = "[?????]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(325, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = ": المجموع";
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbToDate.Location = new System.Drawing.Point(123, 76);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(71, 24);
            this.lbToDate.TabIndex = 16;
            this.lbToDate.Text = "[?????]";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbFromDate.Location = new System.Drawing.Point(123, 31);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(71, 24);
            this.lbFromDate.TabIndex = 15;
            this.lbFromDate.Text = "[?????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label7.Location = new System.Drawing.Point(245, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = ": ألى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.Location = new System.Drawing.Point(245, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = ": من";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lb1.Location = new System.Drawing.Point(350, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(68, 24);
            this.lb1.TabIndex = 12;
            this.lb1.Text = ": الفترة";
            // 
            // frmPurchaseReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPurchaseReports";
            this.Text = "تقرير المشتريات";
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
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbTotall;
        private System.Windows.Forms.Label label8;
    }
}