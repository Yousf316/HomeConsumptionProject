namespace HomeConsuption
{
    partial class frmAddUpdateUsers
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
            this.tabctr1 = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.rjbtnNext = new CustomControls.RJControls.RJButton();
            this.ctrShowPeopleWithSearch1 = new HomeConsuption.ctrShowPeopleWithSearch();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjbtnSave = new CustomControls.RJControls.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.rjbtnCancel = new CustomControls.RJControls.RJButton();
            this.tabctr1.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctr1
            // 
            this.tabctr1.Controls.Add(this.tabPerson);
            this.tabctr1.Controls.Add(this.tabUser);
            this.tabctr1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabctr1.Location = new System.Drawing.Point(10, 84);
            this.tabctr1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabctr1.Name = "tabctr1";
            this.tabctr1.SelectedIndex = 0;
            this.tabctr1.Size = new System.Drawing.Size(779, 510);
            this.tabctr1.TabIndex = 0;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.rjbtnNext);
            this.tabPerson.Controls.Add(this.ctrShowPeopleWithSearch1);
            this.tabPerson.Font = new System.Drawing.Font("Tahoma", 7F);
            this.tabPerson.Location = new System.Drawing.Point(4, 25);
            this.tabPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPerson.Size = new System.Drawing.Size(771, 481);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Text = "الفرد";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // rjbtnNext
            // 
            this.rjbtnNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjbtnNext.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.rjbtnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnNext.BorderRadius = 5;
            this.rjbtnNext.BorderSize = 0;
            this.rjbtnNext.FlatAppearance.BorderSize = 0;
            this.rjbtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjbtnNext.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rjbtnNext.ForeColor = System.Drawing.Color.White;
            this.rjbtnNext.Location = new System.Drawing.Point(593, 423);
            this.rjbtnNext.Name = "rjbtnNext";
            this.rjbtnNext.Size = new System.Drawing.Size(161, 44);
            this.rjbtnNext.TabIndex = 9;
            this.rjbtnNext.Text = "التالي";
            this.rjbtnNext.TextColor = System.Drawing.Color.White;
            this.rjbtnNext.UseVisualStyleBackColor = false;
            this.rjbtnNext.Click += new System.EventHandler(this.rjbtnNext_Click);
            // 
            // ctrShowPeopleWithSearch1
            // 
            this.ctrShowPeopleWithSearch1.Location = new System.Drawing.Point(81, 22);
            this.ctrShowPeopleWithSearch1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrShowPeopleWithSearch1.Name = "ctrShowPeopleWithSearch1";
            this.ctrShowPeopleWithSearch1.Size = new System.Drawing.Size(556, 405);
            this.ctrShowPeopleWithSearch1.TabIndex = 2;
            this.ctrShowPeopleWithSearch1.OnButtonSetPerson += new System.Action<int>(this.ctrShowPeopleWithSearch1_OnButtonSet);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.linkLabel1);
            this.tabUser.Controls.Add(this.chkIsActive);
            this.tabUser.Controls.Add(this.lbUserID);
            this.tabUser.Controls.Add(this.label5);
            this.tabUser.Controls.Add(this.txtConfirmPassword);
            this.tabUser.Controls.Add(this.label3);
            this.tabUser.Controls.Add(this.txtPassword);
            this.tabUser.Controls.Add(this.txtUserName);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUser.Size = new System.Drawing.Size(771, 481);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "المستخدم";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(366, 362);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تحديث كلمة المرور";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(278, 361);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(60, 21);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "تفعيل";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbUserID.Location = new System.Drawing.Point(255, 124);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(37, 19);
            this.lbUserID.TabIndex = 10;
            this.lbUserID.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(131, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "رقم المستخدم:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(252, 295);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(160, 20);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(117, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاْكيد كلمة المرور:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtPassword.Location = new System.Drawing.Point(252, 245);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtUserName.Location = new System.Drawing.Point(252, 186);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(152, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة المرور:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(119, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم :";
            // 
            // rjbtnSave
            // 
            this.rjbtnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjbtnSave.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjbtnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnSave.BorderRadius = 5;
            this.rjbtnSave.BorderSize = 0;
            this.rjbtnSave.FlatAppearance.BorderSize = 0;
            this.rjbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjbtnSave.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rjbtnSave.ForeColor = System.Drawing.Color.White;
            this.rjbtnSave.Location = new System.Drawing.Point(607, 599);
            this.rjbtnSave.Name = "rjbtnSave";
            this.rjbtnSave.Size = new System.Drawing.Size(161, 47);
            this.rjbtnSave.TabIndex = 7;
            this.rjbtnSave.Text = "حفظ";
            this.rjbtnSave.TextColor = System.Drawing.Color.White;
            this.rjbtnSave.UseVisualStyleBackColor = false;
            this.rjbtnSave.Click += new System.EventHandler(this.rjbtnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(244, 53);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(236, 29);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "اضافة مسخدم جديد";
            // 
            // rjbtnCancel
            // 
            this.rjbtnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjbtnCancel.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjbtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnCancel.BorderRadius = 5;
            this.rjbtnCancel.BorderSize = 0;
            this.rjbtnCancel.FlatAppearance.BorderSize = 0;
            this.rjbtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjbtnCancel.Font = new System.Drawing.Font("Tahoma", 13F);
            this.rjbtnCancel.ForeColor = System.Drawing.Color.White;
            this.rjbtnCancel.Location = new System.Drawing.Point(392, 600);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(161, 47);
            this.rjbtnCancel.TabIndex = 8;
            this.rjbtnCancel.Text = "الغاء";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.rjbtnCancel_Click);
            // 
            // frmAddUpdateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 651);
            this.Controls.Add(this.rjbtnCancel);
            this.Controls.Add(this.rjbtnSave);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tabctr1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddUpdateUsers";
            this.Text = "frmAddUpdateUsers";
            this.Load += new System.EventHandler(this.frmAddUpdateUsers_Load);
            this.tabctr1.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabctr1;
        private System.Windows.Forms.TabPage tabPerson;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ctrShowPeopleWithSearch ctrShowPeopleWithSearch1;
        private CustomControls.RJControls.RJButton rjbtnCancel;
        private CustomControls.RJControls.RJButton rjbtnSave;
        private CustomControls.RJControls.RJButton rjbtnNext;
    }
}