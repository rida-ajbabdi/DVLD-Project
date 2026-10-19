namespace DVLD
{
    partial class frmNewLocalDrivingLicenseApplication
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
            this.tbNewLocalDrivingLicenseApplication = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlFiltredPerson = new DVLD.ctrlFiltredPerson();
            this.tbApplicationInfo = new System.Windows.Forms.TabPage();
            this.dtpApplicationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbLisenceClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApplicationFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreatedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtCancel = new Guna.UI2.WinForms.Guna2Button();
            this.tbNewLocalDrivingLicenseApplication.SuspendLayout();
            this.tbPersonalInfo.SuspendLayout();
            this.tbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewLocalDrivingLicenseApplication
            // 
            this.tbNewLocalDrivingLicenseApplication.Controls.Add(this.tbPersonalInfo);
            this.tbNewLocalDrivingLicenseApplication.Controls.Add(this.tbApplicationInfo);
            this.tbNewLocalDrivingLicenseApplication.ItemSize = new System.Drawing.Size(180, 40);
            this.tbNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(4, 1);
            this.tbNewLocalDrivingLicenseApplication.Name = "tbNewLocalDrivingLicenseApplication";
            this.tbNewLocalDrivingLicenseApplication.SelectedIndex = 0;
            this.tbNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(1018, 562);
            this.tbNewLocalDrivingLicenseApplication.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbNewLocalDrivingLicenseApplication.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbNewLocalDrivingLicenseApplication.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbNewLocalDrivingLicenseApplication.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbNewLocalDrivingLicenseApplication.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbNewLocalDrivingLicenseApplication.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbNewLocalDrivingLicenseApplication.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbNewLocalDrivingLicenseApplication.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbNewLocalDrivingLicenseApplication.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbNewLocalDrivingLicenseApplication.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbNewLocalDrivingLicenseApplication.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbNewLocalDrivingLicenseApplication.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbNewLocalDrivingLicenseApplication.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbNewLocalDrivingLicenseApplication.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbNewLocalDrivingLicenseApplication.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbNewLocalDrivingLicenseApplication.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbNewLocalDrivingLicenseApplication.TabIndex = 0;
            this.tbNewLocalDrivingLicenseApplication.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbNewLocalDrivingLicenseApplication.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbPersonalInfo
            // 
            this.tbPersonalInfo.Controls.Add(this.btnNext);
            this.tbPersonalInfo.Controls.Add(this.ctrlFiltredPerson);
            this.tbPersonalInfo.Location = new System.Drawing.Point(4, 44);
            this.tbPersonalInfo.Name = "tbPersonalInfo";
            this.tbPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonalInfo.Size = new System.Drawing.Size(1010, 514);
            this.tbPersonalInfo.TabIndex = 0;
            this.tbPersonalInfo.Text = "Personal Info";
            this.tbPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(814, 465);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(158, 40);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFiltredPerson
            // 
            this.ctrlFiltredPerson.Location = new System.Drawing.Point(6, 6);
            this.ctrlFiltredPerson.Name = "ctrlFiltredPerson";
            this.ctrlFiltredPerson.Size = new System.Drawing.Size(1001, 454);
            this.ctrlFiltredPerson.TabIndex = 0;
            this.ctrlFiltredPerson.OnPerson_Selector += new System.Action<DVLDBusinessLayer.clsPerson>(this.ctrlFiltredPerson_OnPerson_Selector);
            // 
            // tbApplicationInfo
            // 
            this.tbApplicationInfo.Controls.Add(this.dtpApplicationDate);
            this.tbApplicationInfo.Controls.Add(this.cbLisenceClass);
            this.tbApplicationInfo.Controls.Add(this.txtID);
            this.tbApplicationInfo.Controls.Add(this.txtApplicationFees);
            this.tbApplicationInfo.Controls.Add(this.txtCreatedBy);
            this.tbApplicationInfo.Location = new System.Drawing.Point(4, 44);
            this.tbApplicationInfo.Name = "tbApplicationInfo";
            this.tbApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbApplicationInfo.Size = new System.Drawing.Size(1010, 514);
            this.tbApplicationInfo.TabIndex = 1;
            this.tbApplicationInfo.Text = "Application Info";
            this.tbApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // dtpApplicationDate
            // 
            this.dtpApplicationDate.AutoRoundedCorners = true;
            this.dtpApplicationDate.Checked = true;
            this.dtpApplicationDate.Enabled = false;
            this.dtpApplicationDate.FillColor = System.Drawing.Color.RoyalBlue;
            this.dtpApplicationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpApplicationDate.Location = new System.Drawing.Point(185, 116);
            this.dtpApplicationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpApplicationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpApplicationDate.Name = "dtpApplicationDate";
            this.dtpApplicationDate.Size = new System.Drawing.Size(298, 33);
            this.dtpApplicationDate.TabIndex = 76;
            this.dtpApplicationDate.Value = new System.DateTime(2025, 11, 22, 23, 13, 41, 275);
            // 
            // cbLisenceClass
            // 
            this.cbLisenceClass.AutoRoundedCorners = true;
            this.cbLisenceClass.BackColor = System.Drawing.Color.Transparent;
            this.cbLisenceClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLisenceClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLisenceClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLisenceClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLisenceClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLisenceClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLisenceClass.ItemHeight = 30;
            this.cbLisenceClass.Items.AddRange(new object[] {
            "None",
            "_Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbLisenceClass.Location = new System.Drawing.Point(185, 177);
            this.cbLisenceClass.Name = "cbLisenceClass";
            this.cbLisenceClass.Size = new System.Drawing.Size(298, 36);
            this.cbLisenceClass.StartIndex = 0;
            this.cbLisenceClass.TabIndex = 75;
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 10;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "********";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(185, 46);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "ID";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(298, 33);
            this.txtID.TabIndex = 74;
            // 
            // txtApplicationFees
            // 
            this.txtApplicationFees.BorderRadius = 10;
            this.txtApplicationFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApplicationFees.DefaultText = "";
            this.txtApplicationFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApplicationFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApplicationFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApplicationFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApplicationFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApplicationFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApplicationFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApplicationFees.Location = new System.Drawing.Point(185, 253);
            this.txtApplicationFees.Name = "txtApplicationFees";
            this.txtApplicationFees.PlaceholderText = "Enter Application Fees";
            this.txtApplicationFees.ReadOnly = true;
            this.txtApplicationFees.SelectedText = "";
            this.txtApplicationFees.Size = new System.Drawing.Size(298, 33);
            this.txtApplicationFees.TabIndex = 73;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BorderRadius = 10;
            this.txtCreatedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreatedBy.DefaultText = "";
            this.txtCreatedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreatedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreatedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreatedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreatedBy.Location = new System.Drawing.Point(185, 322);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PlaceholderText = "Created By";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.Size = new System.Drawing.Size(298, 33);
            this.txtCreatedBy.TabIndex = 72;
            // 
            // txtSave
            // 
            this.txtSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSave.ForeColor = System.Drawing.Color.White;
            this.txtSave.Location = new System.Drawing.Point(822, 579);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(158, 40);
            this.txtSave.TabIndex = 7;
            this.txtSave.Text = "Save";
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // txtCancel
            // 
            this.txtCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCancel.ForeColor = System.Drawing.Color.White;
            this.txtCancel.Location = new System.Drawing.Point(614, 579);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(158, 40);
            this.txtCancel.TabIndex = 8;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // frmNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 631);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.tbNewLocalDrivingLicenseApplication);
            this.Name = "frmNewLocalDrivingLicenseApplication";
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenseApplication_Load);
            this.tbNewLocalDrivingLicenseApplication.ResumeLayout(false);
            this.tbPersonalInfo.ResumeLayout(false);
            this.tbApplicationInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbNewLocalDrivingLicenseApplication;
        private System.Windows.Forms.TabPage tbPersonalInfo;
        private System.Windows.Forms.TabPage tbApplicationInfo;
        private ctrlFiltredPerson ctrlFiltredPerson;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2ComboBox cbLisenceClass;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2TextBox txtApplicationFees;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedBy;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpApplicationDate;
        private Guna.UI2.WinForms.Guna2Button txtSave;
        private Guna.UI2.WinForms.Guna2Button txtCancel;
    }
}