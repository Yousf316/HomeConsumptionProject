namespace HomeConsuption.Tools
{
    partial class frmTotalAmountwithTax
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalAfterTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPricewithTax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotalAfterTax);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTaxAmount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTotalAmount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(21, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 128);
            this.panel2.TabIndex = 356;
            // 
            // txtTotalAfterTax
            // 
            this.txtTotalAfterTax.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalAfterTax.Location = new System.Drawing.Point(13, 89);
            this.txtTotalAfterTax.Name = "txtTotalAfterTax";
            this.txtTotalAfterTax.ReadOnly = true;
            this.txtTotalAfterTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAfterTax.Size = new System.Drawing.Size(161, 20);
            this.txtTotalAfterTax.TabIndex = 16;
            this.txtTotalAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(180, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 115;
            this.label9.Text = ": الصافي";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTaxAmount.Location = new System.Drawing.Point(13, 54);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaxAmount.Size = new System.Drawing.Size(161, 20);
            this.txtTaxAmount.TabIndex = 14;
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(180, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 113;
            this.label8.Text = ": الضريبة";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalAmount.Location = new System.Drawing.Point(13, 16);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(161, 20);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(180, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "المجموع غير شامل الضريبة";
            // 
            // txtPricewithTax
            // 
            this.txtPricewithTax.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPricewithTax.Location = new System.Drawing.Point(34, 34);
            this.txtPricewithTax.Name = "txtPricewithTax";
            this.txtPricewithTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPricewithTax.Size = new System.Drawing.Size(161, 20);
            this.txtPricewithTax.TabIndex = 116;
            this.txtPricewithTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPricewithTax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPricewithTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(201, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 117;
            this.label1.Text = ": المجوع شامل الضريبة";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_cancel_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(142, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 47);
            this.btnCancel.TabIndex = 358;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Image = global::HomeConsuption.Properties.Resources.icons8_check_96;
            this.btnSave.Location = new System.Drawing.Point(214, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 47);
            this.btnSave.TabIndex = 357;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTotalAmountwithTax
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(401, 308);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPricewithTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTotalAmountwithTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المجموع شامل الضريبة";
            this.Load += new System.EventHandler(this.frmTotalAmountwithTax_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalAfterTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPricewithTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}