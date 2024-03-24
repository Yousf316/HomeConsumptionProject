namespace HomeConsuption.People
{
    partial class frmAddUpdatePerson
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
            this.ctrAddPerson1 = new HomeConsuption.ctrAddPerson();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrAddPerson1
            // 
            this.ctrAddPerson1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ctrAddPerson1.Location = new System.Drawing.Point(9, 150);
            this.ctrAddPerson1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrAddPerson1.Name = "ctrAddPerson1";
            this.ctrAddPerson1.Size = new System.Drawing.Size(750, 405);
            this.ctrAddPerson1.TabIndex = 0;
            this.ctrAddPerson1.DataBack += new HomeConsuption.ctrAddPerson.DataBackEventHandler(this.ctrAddPerson1_DataBack);
            this.ctrAddPerson1.OnCloseButton += new System.Action<bool>(this.ctrAddPerson1_OnCloseButton_1);
            this.ctrAddPerson1.OnSaveButton += new System.Action<bool>(this.ctrAddPerson1_OnSaveButton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeConsuption.Properties.Resources.person_man;
            this.pictureBox1.Location = new System.Drawing.Point(294, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(278, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "أدراج شخص جديد";
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrAddPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddUpdatePerson";
            this.Text = "أدراج شخص جديد";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrAddPerson ctrAddPerson1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}