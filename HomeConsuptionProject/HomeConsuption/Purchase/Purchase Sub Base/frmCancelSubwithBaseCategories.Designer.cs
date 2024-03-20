namespace HomeConsuption.Purchase.Purchase_Sub_Base
{
    partial class frmCancelSubwithBaseCategories
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
            this.cmbSubCategories = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSubCategories
            // 
            this.cmbSubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategories.FormattingEnabled = true;
            this.cmbSubCategories.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSubCategories.Location = new System.Drawing.Point(103, 151);
            this.cmbSubCategories.Name = "cmbSubCategories";
            this.cmbSubCategories.Size = new System.Drawing.Size(139, 21);
            this.cmbSubCategories.TabIndex = 44;
            this.cmbSubCategories.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategories_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbCategory.Location = new System.Drawing.Point(271, 71);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(104, 24);
            this.lbCategory.TabIndex = 43;
            this.lbCategory.Text = ": المجموعة";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(103, 71);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(139, 21);
            this.cmbCategories.TabIndex = 42;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(271, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = ": صنف فرعي";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_cancel_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Location = new System.Drawing.Point(156, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 47);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::HomeConsuption.Properties.Resources.icons8_save_48;
            this.btnSave.Location = new System.Drawing.Point(244, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 47);
            this.btnSave.TabIndex = 40;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCancelSubwithBaseCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 321);
            this.Controls.Add(this.cmbSubCategories);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCancelSubwithBaseCategories";
            this.Text = "الغاء ربط صنف فرعي بمجموعة";
            this.Load += new System.EventHandler(this.frmCancelSubwithBaseCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSubCategories;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}