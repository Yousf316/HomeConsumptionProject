namespace HomeConsuption.Product
{
    partial class frmAddEditeProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductArabicName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtProductEngName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkAddImage = new System.Windows.Forms.LinkLabel();
            this.lnkRemoveImage = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddNewCat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(623, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "المجموعة";
            // 
            // txtProductArabicName
            // 
            this.txtProductArabicName.Location = new System.Drawing.Point(370, 147);
            this.txtProductArabicName.Name = "txtProductArabicName";
            this.txtProductArabicName.Size = new System.Drawing.Size(193, 20);
            this.txtProductArabicName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(583, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم المنتج (العربي)";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(466, 41);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(151, 21);
            this.cmbCategories.TabIndex = 4;
            // 
            // txtProductEngName
            // 
            this.txtProductEngName.Location = new System.Drawing.Point(370, 204);
            this.txtProductEngName.Name = "txtProductEngName";
            this.txtProductEngName.Size = new System.Drawing.Size(193, 20);
            this.txtProductEngName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(600, 204);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "أسم المنتج (EN)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(424, 261);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(600, 261);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "سعر الشراء :";
            // 
            // lnkAddImage
            // 
            this.lnkAddImage.AutoSize = true;
            this.lnkAddImage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lnkAddImage.Location = new System.Drawing.Point(95, 282);
            this.lnkAddImage.Name = "lnkAddImage";
            this.lnkAddImage.Size = new System.Drawing.Size(84, 19);
            this.lnkAddImage.TabIndex = 10;
            this.lnkAddImage.TabStop = true;
            this.lnkAddImage.Text = "أضافة صورة";
            this.lnkAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddImage_LinkClicked);
            // 
            // lnkRemoveImage
            // 
            this.lnkRemoveImage.AutoSize = true;
            this.lnkRemoveImage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lnkRemoveImage.Location = new System.Drawing.Point(95, 313);
            this.lnkRemoveImage.Name = "lnkRemoveImage";
            this.lnkRemoveImage.Size = new System.Drawing.Size(90, 19);
            this.lnkRemoveImage.TabIndex = 11;
            this.lnkRemoveImage.TabStop = true;
            this.lnkRemoveImage.Text = "حذف الصورة";
            this.lnkRemoveImage.Visible = false;
            this.lnkRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRemoveImage_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(157, 37);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "رقم المنتج :";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lbID.Location = new System.Drawing.Point(82, 38);
            this.lbID.Name = "lbID";
            this.lbID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbID.Size = new System.Drawing.Size(69, 22);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "[?????]";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddNewCat
            // 
            this.btnAddNewCat.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_plus_64;
            this.btnAddNewCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewCat.Location = new System.Drawing.Point(420, 33);
            this.btnAddNewCat.Name = "btnAddNewCat";
            this.btnAddNewCat.Size = new System.Drawing.Size(40, 36);
            this.btnAddNewCat.TabIndex = 21;
            this.btnAddNewCat.UseVisualStyleBackColor = true;
            this.btnAddNewCat.Click += new System.EventHandler(this.btnAddNewCat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_cancel_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Location = new System.Drawing.Point(324, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 47);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::HomeConsuption.Properties.Resources.icons8_save_48;
            this.btnSave.Location = new System.Drawing.Point(407, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 47);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picProductImage
            // 
            this.picProductImage.Image = global::HomeConsuption.Properties.Resources.icons8_product_96;
            this.picProductImage.Location = new System.Drawing.Point(31, 112);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(221, 156);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProductImage.TabIndex = 9;
            this.picProductImage.TabStop = false;
            // 
            // frmAddEditeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 452);
            this.Controls.Add(this.btnAddNewCat);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lnkRemoveImage);
            this.Controls.Add(this.lnkAddImage);
            this.Controls.Add(this.picProductImage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductEngName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.txtProductArabicName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditeProduct";
            this.Text = "أدراج منتج جديد";
            this.Load += new System.EventHandler(this.frmAddEditeProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductArabicName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtProductEngName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.LinkLabel lnkAddImage;
        private System.Windows.Forms.LinkLabel lnkRemoveImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnAddNewCat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}