namespace HomeConsuption.DataBases
{
    partial class frmDataBaseList
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDBs = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمتجرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBs)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label2.Location = new System.Drawing.Point(266, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "قائمة قواعد البيانات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(486, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = ": الأسم المستعار";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(172, 216);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(306, 24);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvDBs
            // 
            this.dgvDBs.AllowUserToAddRows = false;
            this.dgvDBs.AllowUserToDeleteRows = false;
            this.dgvDBs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBs.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDBs.Location = new System.Drawing.Point(57, 281);
            this.dgvDBs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDBs.Name = "dgvDBs";
            this.dgvDBs.ReadOnly = true;
            this.dgvDBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDBs.RowHeadersWidth = 51;
            this.dgvDBs.Size = new System.Drawing.Size(652, 340);
            this.dgvDBs.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفالمتجرToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفالمتجرToolStripMenuItem
            // 
            this.حذفالمتجرToolStripMenuItem.Name = "حذفالمتجرToolStripMenuItem";
            this.حذفالمتجرToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.حذفالمتجرToolStripMenuItem.Text = "حذف";
            this.حذفالمتجرToolStripMenuItem.Click += new System.EventHandler(this.حذفالمتجرToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeConsuption.Properties.Resources.dedicated_hosting;
            this.pictureBox1.Location = new System.Drawing.Point(338, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_plus_64;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.Location = new System.Drawing.Point(120, 203);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(46, 45);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmDataBaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDBs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDataBaseList";
            this.Text = "قائمة قواعد البيانات";
            this.Load += new System.EventHandler(this.frmDataBaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBs)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDBs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالمتجرToolStripMenuItem;
    }
}