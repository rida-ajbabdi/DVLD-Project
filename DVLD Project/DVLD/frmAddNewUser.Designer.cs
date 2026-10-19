namespace DVLD
{
    partial class frmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUser));
            this.tbAddNewUser = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlFiltredPerson = new DVLD.ctrlFiltredPerson();
            this.gbFilterBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbUserInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ValidProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbAddNewUser.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAddNewUser
            // 
            this.tbAddNewUser.Controls.Add(this.tbPersonInfo);
            this.tbAddNewUser.Controls.Add(this.tbUserInfo);
            this.tbAddNewUser.ItemSize = new System.Drawing.Size(180, 40);
            this.tbAddNewUser.Location = new System.Drawing.Point(0, 0);
            this.tbAddNewUser.Name = "tbAddNewUser";
            this.tbAddNewUser.SelectedIndex = 0;
            this.tbAddNewUser.Size = new System.Drawing.Size(1130, 515);
            this.tbAddNewUser.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbAddNewUser.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbAddNewUser.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbAddNewUser.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbAddNewUser.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbAddNewUser.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbAddNewUser.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbAddNewUser.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbAddNewUser.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbAddNewUser.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbAddNewUser.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbAddNewUser.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbAddNewUser.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbAddNewUser.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbAddNewUser.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbAddNewUser.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbAddNewUser.TabIndex = 0;
            this.tbAddNewUser.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbAddNewUser.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Controls.Add(this.ctrlFiltredPerson);
            this.tbPersonInfo.Controls.Add(this.gbFilterBy);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(1122, 467);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "tabPage1";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(913, 424);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(158, 40);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFiltredPerson
            // 
            this.ctrlFiltredPerson.Location = new System.Drawing.Point(64, -16);
            this.ctrlFiltredPerson.Name = "ctrlFiltredPerson";
            this.ctrlFiltredPerson.Size = new System.Drawing.Size(1007, 477);
            this.ctrlFiltredPerson.TabIndex = 11;
            this.ctrlFiltredPerson.OnPerson_Selector += new System.Action<DVLDBusinessLayer.clsPerson>(this.ctrlFiltredPerson_OnPerson_Selector);
            // 
            // gbFilterBy
            // 
            this.gbFilterBy.BorderColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.FillColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFilterBy.ForeColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.Location = new System.Drawing.Point(188, 0);
            this.gbFilterBy.Name = "gbFilterBy";
            this.gbFilterBy.Size = new System.Drawing.Size(703, 54);
            this.gbFilterBy.TabIndex = 8;
            // 
            // tbUserInfo
            // 
            this.tbUserInfo.Controls.Add(this.label1);
            this.tbUserInfo.Controls.Add(this.chkIsActive);
            this.tbUserInfo.Controls.Add(this.txtUserID);
            this.tbUserInfo.Controls.Add(this.txtUserName);
            this.tbUserInfo.Controls.Add(this.txtPassword);
            this.tbUserInfo.Controls.Add(this.txtConfirmPassword);
            this.tbUserInfo.Location = new System.Drawing.Point(4, 44);
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserInfo.Size = new System.Drawing.Size(1122, 467);
            this.tbUserInfo.TabIndex = 1;
            this.tbUserInfo.Text = "tabPage2";
            this.tbUserInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Is Active";
            // 
            // chkIsActive
            // 
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 2;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Location = new System.Drawing.Point(103, 284);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(20, 20);
            this.chkIsActive.TabIndex = 73;
            this.chkIsActive.Text = "guna2CustomCheckBox1";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 2;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtUserID
            // 
            this.txtUserID.BorderRadius = 10;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "********";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Location = new System.Drawing.Point(103, 67);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderText = "ID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(298, 33);
            this.txtUserID.TabIndex = 69;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(103, 119);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "Enter User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(298, 33);
            this.txtUserName.TabIndex = 70;
            this.txtUserName.TextChanged += new System.EventHandler(this.UserInfo_Changed);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(103, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(298, 33);
            this.txtPassword.TabIndex = 71;
            this.txtPassword.TextChanged += new System.EventHandler(this.UserInfo_Changed);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 10;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(103, 223);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(298, 33);
            this.txtConfirmPassword.TabIndex = 72;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.UserInfo_Changed);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassoword_Validating);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(881, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(633, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ValidProvider
            // 
            this.ValidProvider.ContainerControl = this;
            this.ValidProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidProvider.Icon")));
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAddNewUser);
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tbAddNewUser.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbUserInfo.ResumeLayout(false);
            this.tbUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbAddNewUser;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkIsActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ValidProvider;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilterBy;
        private ctrlFiltredPerson ctrlFiltredPerson;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}