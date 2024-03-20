namespace HomeConsuption.Purchase
{
    partial class frmPurchaseList
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsSettingsPurchase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.المعلموماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الحذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPageSize = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsSettingsPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsSettingsPurchase;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmsSettingsPurchase
            // 
            this.cmsSettingsPurchase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.المعلموماتToolStripMenuItem,
            this.التعديلToolStripMenuItem,
            this.الحذفToolStripMenuItem});
            this.cmsSettingsPurchase.Name = "cmsSettingsPurchase";
            this.cmsSettingsPurchase.Size = new System.Drawing.Size(134, 70);
            this.cmsSettingsPurchase.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // المعلموماتToolStripMenuItem
            // 
            this.المعلموماتToolStripMenuItem.Name = "المعلموماتToolStripMenuItem";
            this.المعلموماتToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.المعلموماتToolStripMenuItem.Text = "المعلمومات";
            // 
            // التعديلToolStripMenuItem
            // 
            this.التعديلToolStripMenuItem.Name = "التعديلToolStripMenuItem";
            this.التعديلToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.التعديلToolStripMenuItem.Text = "التعديل";
            this.التعديلToolStripMenuItem.Click += new System.EventHandler(this.التعديلToolStripMenuItem_Click);
            // 
            // الحذفToolStripMenuItem
            // 
            this.الحذفToolStripMenuItem.Name = "الحذفToolStripMenuItem";
            this.الحذفToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.الحذفToolStripMenuItem.Text = "الحذف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(451, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = " أدارة المشتريات";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, 234);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbColumns
            // 
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Items.AddRange(new object[] {
            "الكل",
            "رقم الفاتورة",
            "المجموع",
            "أسم المتجر",
            "نوع الفاتورة"});
            this.cmbColumns.Location = new System.Drawing.Point(26, 234);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(131, 21);
            this.cmbColumns.TabIndex = 4;
            this.cmbColumns.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeConsuption.Properties.Resources.icons8_buy_for_coins_96;
            this.pictureBox1.Location = new System.Drawing.Point(520, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_arrow_96__1_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Location = new System.Drawing.Point(654, 558);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 47);
            this.btnNext.TabIndex = 359;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_arrow_96;
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.Location = new System.Drawing.Point(518, 558);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(45, 47);
            this.btnprevious.TabIndex = 358;
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(151, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 360;
            this.label2.Text = ": عدد الصفحات";
            // 
            // lbPageSize
            // 
            this.lbPageSize.AutoSize = true;
            this.lbPageSize.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbPageSize.Location = new System.Drawing.Point(92, 570);
            this.lbPageSize.Name = "lbPageSize";
            this.lbPageSize.Size = new System.Drawing.Size(53, 19);
            this.lbPageSize.TabIndex = 361;
            this.lbPageSize.Text = "[????]";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::HomeConsuption.Properties.Resources.icons8_buy_for_coins_641;
            this.button1.Location = new System.Drawing.Point(1065, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 66);
            this.button1.TabIndex = 362;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbCurrentPage.Location = new System.Drawing.Point(969, 558);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(53, 19);
            this.lbCurrentPage.TabIndex = 364;
            this.lbCurrentPage.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(1028, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 363;
            this.label4.Text = ": الصفحة";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(839, 231);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(104, 20);
            this.dtpFrom.TabIndex = 365;
            this.dtpFrom.Value = new System.DateTime(2024, 1, 1, 11, 21, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(671, 231);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(106, 20);
            this.dtpTo.TabIndex = 366;
            this.dtpTo.Value = new System.DateTime(2024, 12, 31, 11, 21, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(949, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 367;
            this.label3.Text = "من";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(793, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 368;
            this.label5.Text = "ألى";
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(619, 234);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(46, 17);
            this.cbAll.TabIndex = 369;
            this.cbAll.Text = "الكل";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // frmPurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 630);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPageSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.cmbColumns);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPurchaseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أدارة المشتريات";
            this.Load += new System.EventHandler(this.frmPurchaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsSettingsPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPageSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsSettingsPurchase;
        private System.Windows.Forms.ToolStripMenuItem المعلموماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الحذفToolStripMenuItem;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAll;
    }
}