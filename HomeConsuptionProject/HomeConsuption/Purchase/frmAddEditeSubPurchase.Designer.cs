﻿namespace HomeConsuption.Purchase
{
    partial class frmAddEditeSubPurchase
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
            this.txtProdouctID = new System.Windows.Forms.TextBox();
            this.txtProdouctName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbIncludTax = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.rjbtnChooseProduct = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // txtProdouctID
            // 
            this.txtProdouctID.Enabled = false;
            this.txtProdouctID.Location = new System.Drawing.Point(360, 232);
            this.txtProdouctID.Name = "txtProdouctID";
            this.txtProdouctID.Size = new System.Drawing.Size(80, 20);
            this.txtProdouctID.TabIndex = 1;
            // 
            // txtProdouctName
            // 
            this.txtProdouctName.Enabled = false;
            this.txtProdouctName.Location = new System.Drawing.Point(213, 232);
            this.txtProdouctName.Name = "txtProdouctName";
            this.txtProdouctName.Size = new System.Drawing.Size(135, 20);
            this.txtProdouctName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(240, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "أسم المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(368, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "رقم المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(437, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = " : الوصف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(535, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "الكمية";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(510, 326);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(107, 20);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantityAndPrice_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Location = new System.Drawing.Point(373, 326);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(102, 20);
            this.txtPricePerUnit.TabIndex = 5;
            this.txtPricePerUnit.TextChanged += new System.EventHandler(this.txtQuantityAndPrice_TextChanged);
            this.txtPricePerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(285, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "المجموع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.Location = new System.Drawing.Point(487, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label8.Location = new System.Drawing.Point(185, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = ": رقم البند";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label9.Location = new System.Drawing.Point(118, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(258, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "معلومات البند";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(243, 420);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(166, 67);
            this.rtbDescription.TabIndex = 16;
            this.rtbDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label11.Location = new System.Drawing.Point(374, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "سعر الحبة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label12.Location = new System.Drawing.Point(118, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "الحجم";
            this.label12.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_cancel_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Location = new System.Drawing.Point(249, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 47);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::HomeConsuption.Properties.Resources.icons8_save_48;
            this.btnSave.Location = new System.Drawing.Point(357, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 47);
            this.btnSave.TabIndex = 18;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbIncludTax
            // 
            this.cbIncludTax.AutoSize = true;
            this.cbIncludTax.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbIncludTax.Location = new System.Drawing.Point(380, 368);
            this.cbIncludTax.Name = "cbIncludTax";
            this.cbIncludTax.Size = new System.Drawing.Size(95, 18);
            this.cbIncludTax.TabIndex = 361;
            this.cbIncludTax.Text = "شامل الضريبة";
            this.cbIncludTax.UseVisualStyleBackColor = true;
            this.cbIncludTax.CheckedChanged += new System.EventHandler(this.cbIncludTax_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label13.Location = new System.Drawing.Point(177, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 362;
            this.label13.Text = "الضريبة";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label15.Location = new System.Drawing.Point(66, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 18);
            this.label15.TabIndex = 364;
            this.label15.Text = "الصافي";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(262, 326);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(102, 20);
            this.txtTotal.TabIndex = 365;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(154, 326);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(102, 20);
            this.txtTax.TabIndex = 366;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(46, 326);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(102, 20);
            this.txtNet.TabIndex = 367;
            // 
            // rjbtnChooseProduct
            // 
            this.rjbtnChooseProduct.BackColor = System.Drawing.Color.DarkCyan;
            this.rjbtnChooseProduct.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.rjbtnChooseProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnChooseProduct.BorderRadius = 10;
            this.rjbtnChooseProduct.BorderSize = 0;
            this.rjbtnChooseProduct.FlatAppearance.BorderSize = 0;
            this.rjbtnChooseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnChooseProduct.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rjbtnChooseProduct.ForeColor = System.Drawing.Color.White;
            this.rjbtnChooseProduct.Location = new System.Drawing.Point(354, 119);
            this.rjbtnChooseProduct.Name = "rjbtnChooseProduct";
            this.rjbtnChooseProduct.Size = new System.Drawing.Size(121, 29);
            this.rjbtnChooseProduct.TabIndex = 368;
            this.rjbtnChooseProduct.Text = "المنتج";
            this.rjbtnChooseProduct.TextColor = System.Drawing.Color.White;
            this.rjbtnChooseProduct.UseVisualStyleBackColor = false;
            this.rjbtnChooseProduct.Click += new System.EventHandler(this.rjbtnChooseProduct_Click);
            // 
            // frmAddEditeSubPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 592);
            this.Controls.Add(this.rjbtnChooseProduct);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbIncludTax);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdouctName);
            this.Controls.Add(this.txtProdouctID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditeSubPurchase";
            this.Text = "أدراج بند";
            this.Load += new System.EventHandler(this.frmAddEditeSubPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProdouctID;
        private System.Windows.Forms.TextBox txtProdouctName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbIncludTax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtNet;
        private CustomControls.RJControls.RJButton rjbtnChooseProduct;
    }
}