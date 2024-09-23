namespace HomeConsuption.Product
{
    partial class frmProductList
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
            this.lbPageSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.بطاقةمعلوماتالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPageSize
            // 
            this.lbPageSize.AutoSize = true;
            this.lbPageSize.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbPageSize.Location = new System.Drawing.Point(27, 738);
            this.lbPageSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPageSize.Name = "lbPageSize";
            this.lbPageSize.Size = new System.Drawing.Size(62, 24);
            this.lbPageSize.TabIndex = 371;
            this.lbPageSize.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(96, 738);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 370;
            this.label2.Text = ": عدد الصفحات";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 309);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 367;
            this.comboBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 309);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 24);
            this.textBox1.TabIndex = 366;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(326, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 51);
            this.label1.TabIndex = 364;
            this.label1.Text = "أدارة المنتجات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 341);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(884, 366);
            this.dataGridView1.TabIndex = 363;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بطاقةمعلوماتالمنتجToolStripMenuItem,
            this.تعديلمToolStripMenuItem,
            this.حذفالمنتجToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 76);
            // 
            // بطاقةمعلوماتالمنتجToolStripMenuItem
            // 
            this.بطاقةمعلوماتالمنتجToolStripMenuItem.Name = "بطاقةمعلوماتالمنتجToolStripMenuItem";
            this.بطاقةمعلوماتالمنتجToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.بطاقةمعلوماتالمنتجToolStripMenuItem.Text = "بطاقة بيانات المنتج";
            // 
            // تعديلمToolStripMenuItem
            // 
            this.تعديلمToolStripMenuItem.Name = "تعديلمToolStripMenuItem";
            this.تعديلمToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.تعديلمToolStripMenuItem.Text = "تعديل بيانات المنتج";
            this.تعديلمToolStripMenuItem.Click += new System.EventHandler(this.تعديلمToolStripMenuItem_Click);
            // 
            // حذفالمنتجToolStripMenuItem
            // 
            this.حذفالمنتجToolStripMenuItem.Name = "حذفالمنتجToolStripMenuItem";
            this.حذفالمنتجToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.حذفالمنتجToolStripMenuItem.Text = "حذف المنتج";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::HomeConsuption.Properties.Resources.icons8_product_64;
            this.button1.Location = new System.Drawing.Point(792, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 81);
            this.button1.TabIndex = 372;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_arrow_96__1_;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Location = new System.Drawing.Point(534, 724);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 58);
            this.btnNext.TabIndex = 369;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = global::HomeConsuption.Properties.Resources.icons8_arrow_96;
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.Location = new System.Drawing.Point(376, 724);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(52, 58);
            this.btnprevious.TabIndex = 368;
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeConsuption.Properties.Resources.icons8_product_64;
            this.pictureBox1.Location = new System.Drawing.Point(376, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 365;
            this.pictureBox1.TabStop = false;
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 804);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPageSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProductList";
            this.Text = "قائمة المنتجات";
            this.Load += new System.EventHandler(this.frmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPageSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem بطاقةمعلوماتالمنتجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالمنتجToolStripMenuItem;
    }
}