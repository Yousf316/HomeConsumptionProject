namespace HomeConsuption
{
    partial class frmAddEditPurchase
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTypeInvoice = new System.Windows.Forms.ComboBox();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.btnAddNewStore = new System.Windows.Forms.Button();
            this.dgvSubPurchase = new System.Windows.Forms.DataGridView();
            this.cmsSubPurchase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalAfterTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalBeforeTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbRecordCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.cbIncludTax = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubPurchase)).BeginInit();
            this.cmsSubPurchase.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(185, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = ": الرقم";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbID.Location = new System.Drawing.Point(78, 26);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(62, 24);
            this.lbID.TabIndex = 25;
            this.lbID.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(185, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = ": تاريخ الفاتورة";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/mm/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDate.Location = new System.Drawing.Point(28, 80);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(141, 20);
            this.dtpDate.TabIndex = 277;
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(856, 32);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.ReadOnly = true;
            this.txtStoreName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStoreName.Size = new System.Drawing.Size(250, 20);
            this.txtStoreName.TabIndex = 0;
            this.txtStoreName.DoubleClick += new System.EventHandler(this.txtStoreName_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(1112, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = ": اسم المتجر  ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNewCategory);
            this.panel1.Controls.Add(this.cmbCategoryList);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTypeInvoice);
            this.panel1.Controls.Add(this.txtStoreID);
            this.panel1.Controls.Add(this.btnAddNewStore);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStoreName);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 117);
            this.panel1.TabIndex = 104;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_plus_64;
            this.btnAddNewCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewCategory.Location = new System.Drawing.Point(390, 70);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(40, 36);
            this.btnAddNewCategory.TabIndex = 282;
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(436, 79);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCategoryList.Size = new System.Drawing.Size(128, 21);
            this.cmbCategoryList.TabIndex = 281;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label10.Location = new System.Drawing.Point(579, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 24);
            this.label10.TabIndex = 280;
            this.label10.Text = ":تصنيف الفاتورة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(579, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 279;
            this.label2.Text = ": نوع الفاتورة ";
            // 
            // cbTypeInvoice
            // 
            this.cbTypeInvoice.FormattingEnabled = true;
            this.cbTypeInvoice.Items.AddRange(new object[] {
            "سريعة",
            "عادية"});
            this.cbTypeInvoice.Location = new System.Drawing.Point(436, 35);
            this.cbTypeInvoice.Name = "cbTypeInvoice";
            this.cbTypeInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbTypeInvoice.Size = new System.Drawing.Size(128, 21);
            this.cbTypeInvoice.TabIndex = 278;
            this.cbTypeInvoice.SelectedIndexChanged += new System.EventHandler(this.cbTypeInvoice_SelectedIndexChanged);
            // 
            // txtStoreID
            // 
            this.txtStoreID.Enabled = false;
            this.txtStoreID.Location = new System.Drawing.Point(775, 32);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(75, 20);
            this.txtStoreID.TabIndex = 100;
            this.txtStoreID.TabStop = false;
            // 
            // btnAddNewStore
            // 
            this.btnAddNewStore.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_plus_64;
            this.btnAddNewStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewStore.Location = new System.Drawing.Point(729, 23);
            this.btnAddNewStore.Name = "btnAddNewStore";
            this.btnAddNewStore.Size = new System.Drawing.Size(40, 36);
            this.btnAddNewStore.TabIndex = 20;
            this.btnAddNewStore.UseVisualStyleBackColor = true;
            this.btnAddNewStore.Click += new System.EventHandler(this.btnAddNewStore_Click);
            // 
            // dgvSubPurchase
            // 
            this.dgvSubPurchase.AllowUserToAddRows = false;
            this.dgvSubPurchase.AllowUserToDeleteRows = false;
            this.dgvSubPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubPurchase.ContextMenuStrip = this.cmsSubPurchase;
            this.dgvSubPurchase.Location = new System.Drawing.Point(12, 143);
            this.dgvSubPurchase.Name = "dgvSubPurchase";
            this.dgvSubPurchase.ReadOnly = true;
            this.dgvSubPurchase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSubPurchase.Size = new System.Drawing.Size(1244, 280);
            this.dgvSubPurchase.TabIndex = 7;
            this.dgvSubPurchase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmsSubPurchase
            // 
            this.cmsSubPurchase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.cmsSubPurchase.Name = "cmsSubPurchase";
            this.cmsSubPurchase.Size = new System.Drawing.Size(104, 48);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.dToolStripMenuItem.Text = "تعديل";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotalAfterTax);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTaxAmount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTotalBeforeTax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTotalAmount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(18, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 179);
            this.panel2.TabIndex = 355;
            // 
            // txtTotalAfterTax
            // 
            this.txtTotalAfterTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAfterTax.Location = new System.Drawing.Point(13, 148);
            this.txtTotalAfterTax.Name = "txtTotalAfterTax";
            this.txtTotalAfterTax.ReadOnly = true;
            this.txtTotalAfterTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAfterTax.Size = new System.Drawing.Size(161, 20);
            this.txtTotalAfterTax.TabIndex = 16;
            this.txtTotalAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAfterTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(180, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 115;
            this.label9.Text = ": الصافي";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxAmount.Location = new System.Drawing.Point(13, 113);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaxAmount.Size = new System.Drawing.Size(161, 20);
            this.txtTaxAmount.TabIndex = 14;
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(180, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 113;
            this.label8.Text = ": الضريبة";
            // 
            // txtTotalBeforeTax
            // 
            this.txtTotalBeforeTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalBeforeTax.Location = new System.Drawing.Point(12, 83);
            this.txtTotalBeforeTax.Name = "txtTotalBeforeTax";
            this.txtTotalBeforeTax.ReadOnly = true;
            this.txtTotalBeforeTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBeforeTax.Size = new System.Drawing.Size(161, 20);
            this.txtTotalBeforeTax.TabIndex = 12;
            this.txtTotalBeforeTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalBeforeTax.TextChanged += new System.EventHandler(this.txtTotalBeforeTax_TextChanged);
            this.txtTotalBeforeTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(179, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 111;
            this.label7.Text = ": الأجمالي  ";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.Location = new System.Drawing.Point(12, 52);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(161, 20);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(179, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = ": الخصم";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.Location = new System.Drawing.Point(13, 16);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(161, 20);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtTotalAmount.DoubleClick += new System.EventHandler(this.txtTotalAmount_DoubleClick);
            this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(180, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = ": المجموع";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbRecordCount);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(1045, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 48);
            this.panel3.TabIndex = 171;
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.AutoSize = true;
            this.lbRecordCount.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbRecordCount.Location = new System.Drawing.Point(52, 12);
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Size = new System.Drawing.Size(62, 24);
            this.lbRecordCount.TabIndex = 28;
            this.lbRecordCount.Text = "[????]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.Location = new System.Drawing.Point(120, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = ": عدد البنود ";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRecord.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddRecord.Location = new System.Drawing.Point(884, 440);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(142, 36);
            this.btnAddRecord.TabIndex = 283;
            this.btnAddRecord.Text = "أدراج بند";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_arrow_96__1_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(699, 606);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 47);
            this.btnNext.TabIndex = 357;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_arrow_96;
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.Enabled = false;
            this.btnprevious.Location = new System.Drawing.Point(570, 606);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(45, 47);
            this.btnprevious.TabIndex = 356;
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_cancel_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Location = new System.Drawing.Point(817, 606);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 47);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::HomeConsuption.Properties.Resources.icons8_save_48;
            this.btnSave.Location = new System.Drawing.Point(868, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTest.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTest.Location = new System.Drawing.Point(1101, 611);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(142, 36);
            this.btnTest.TabIndex = 359;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbIncludTax
            // 
            this.cbIncludTax.AutoSize = true;
            this.cbIncludTax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbIncludTax.Location = new System.Drawing.Point(296, 446);
            this.cbIncludTax.Name = "cbIncludTax";
            this.cbIncludTax.Size = new System.Drawing.Size(121, 23);
            this.cbIncludTax.TabIndex = 360;
            this.cbIncludTax.Text = "شامل الضريبة";
            this.cbIncludTax.UseVisualStyleBackColor = true;
            this.cbIncludTax.Visible = false;
            this.cbIncludTax.CheckedChanged += new System.EventHandler(this.cbIncludTax_CheckedChanged);
            // 
            // frmAddEditPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 665);
            this.Controls.Add(this.cbIncludTax);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSubPurchase);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmAddEditPurchase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اصدار فاتورة مشتريات";
            this.Load += new System.EventHandler(this.AddEditPurchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubPurchase)).EndInit();
            this.cmsSubPurchase.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewStore;
        private System.Windows.Forms.DataGridView dgvSubPurchase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalBeforeTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalAfterTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbRecordCount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTypeInvoice;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.ContextMenuStrip cmsSubPurchase;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox cbIncludTax;
    }
}