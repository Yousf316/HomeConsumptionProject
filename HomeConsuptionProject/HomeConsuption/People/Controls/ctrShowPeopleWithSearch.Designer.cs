namespace HomeConsuption
{
    partial class ctrShowPeopleWithSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSearchPerson = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsearchen = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFinds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrShowPerson1 = new HomeConsuption.ctrShowPerson();
            this.pnlSearchPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchPerson
            // 
            this.pnlSearchPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchPerson.Controls.Add(this.button2);
            this.pnlSearchPerson.Controls.Add(this.btnsearchen);
            this.pnlSearchPerson.Controls.Add(this.txtSearch);
            this.pnlSearchPerson.Controls.Add(this.cmbFinds);
            this.pnlSearchPerson.Controls.Add(this.label1);
            this.pnlSearchPerson.Location = new System.Drawing.Point(3, 6);
            this.pnlSearchPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearchPerson.Name = "pnlSearchPerson";
            this.pnlSearchPerson.Size = new System.Drawing.Size(632, 97);
            this.pnlSearchPerson.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::HomeConsuption.Properties.Resources.person_manAddPerson;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(550, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 54);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsearchen
            // 
            this.btnsearchen.BackgroundImage = global::HomeConsuption.Properties.Resources.person_mansearch;
            this.btnsearchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsearchen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsearchen.Location = new System.Drawing.Point(483, 29);
            this.btnsearchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearchen.Name = "btnsearchen";
            this.btnsearchen.Size = new System.Drawing.Size(63, 54);
            this.btnsearchen.TabIndex = 2;
            this.btnsearchen.UseVisualStyleBackColor = true;
            this.btnsearchen.Click += new System.EventHandler(this.btnSearch);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(258, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbFinds
            // 
            this.cmbFinds.FormattingEnabled = true;
            this.cmbFinds.Items.AddRange(new object[] {
            "PersonID"});
            this.cmbFinds.Location = new System.Drawing.Point(115, 47);
            this.cmbFinds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFinds.Name = "cmbFinds";
            this.cmbFinds.Size = new System.Drawing.Size(139, 21);
            this.cmbFinds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter By:";
            // 
            // ctrShowPerson1
            // 
            this.ctrShowPerson1.Location = new System.Drawing.Point(3, 105);
            this.ctrShowPerson1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrShowPerson1.Name = "ctrShowPerson1";
            this.ctrShowPerson1.obPerson = null;
            this.ctrShowPerson1.Size = new System.Drawing.Size(449, 358);
            this.ctrShowPerson1.TabIndex = 2;
            // 
            // ctrShowPeopleWithSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrShowPerson1);
            this.Controls.Add(this.pnlSearchPerson);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ctrShowPeopleWithSearch";
            this.Size = new System.Drawing.Size(643, 463);
            this.Load += new System.EventHandler(this.ctrShowPeopleWithSearch_Load);
            this.pnlSearchPerson.ResumeLayout(false);
            this.pnlSearchPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSearchPerson;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearchen;
        private System.Windows.Forms.Button button2;
        private ctrShowPerson ctrShowPerson1;
    }
}
