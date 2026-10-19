namespace DVLD
{
    partial class frmAddNewInternationalLicenseApplication
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
            this.dtpExpirationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpApplicationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpIssueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLocalLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreatedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInternationalLicenseApplicationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInternationalLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlFiltredLicense = new DVLD.ctrlFiltredLicense();
            this.SuspendLayout();
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Checked = true;
            this.dtpExpirationDate.Enabled = false;
            this.dtpExpirationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpirationDate.Location = new System.Drawing.Point(383, 575);
            this.dtpExpirationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpirationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(284, 29);
            this.dtpExpirationDate.TabIndex = 106;
            this.dtpExpirationDate.Value = new System.DateTime(2025, 12, 17, 16, 11, 3, 360);
            // 
            // dtpApplicationDate
            // 
            this.dtpApplicationDate.Checked = true;
            this.dtpApplicationDate.Enabled = false;
            this.dtpApplicationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpApplicationDate.Location = new System.Drawing.Point(48, 522);
            this.dtpApplicationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpApplicationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpApplicationDate.Name = "dtpApplicationDate";
            this.dtpApplicationDate.Size = new System.Drawing.Size(284, 29);
            this.dtpApplicationDate.TabIndex = 105;
            this.dtpApplicationDate.Value = new System.DateTime(2025, 12, 17, 16, 11, 3, 360);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Checked = true;
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpIssueDate.Location = new System.Drawing.Point(48, 575);
            this.dtpIssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(284, 29);
            this.dtpIssueDate.TabIndex = 104;
            this.dtpIssueDate.Value = new System.DateTime(2025, 12, 17, 16, 11, 3, 360);
            // 
            // txtLocalLicenseID
            // 
            this.txtLocalLicenseID.BorderRadius = 10;
            this.txtLocalLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalLicenseID.DefaultText = "";
            this.txtLocalLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocalLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocalLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocalLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocalLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocalLicenseID.Location = new System.Drawing.Point(383, 522);
            this.txtLocalLicenseID.Name = "txtLocalLicenseID";
            this.txtLocalLicenseID.PlaceholderText = "ID";
            this.txtLocalLicenseID.ReadOnly = true;
            this.txtLocalLicenseID.SelectedText = "";
            this.txtLocalLicenseID.Size = new System.Drawing.Size(284, 33);
            this.txtLocalLicenseID.TabIndex = 103;
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
            this.txtCreatedBy.Location = new System.Drawing.Point(383, 618);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PlaceholderText = "Enter Second Name";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.Size = new System.Drawing.Size(284, 33);
            this.txtCreatedBy.TabIndex = 102;
            // 
            // txtFees
            // 
            this.txtFees.BorderRadius = 10;
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.DefaultText = "";
            this.txtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.Location = new System.Drawing.Point(45, 618);
            this.txtFees.Name = "txtFees";
            this.txtFees.PlaceholderText = "Enter National No";
            this.txtFees.ReadOnly = true;
            this.txtFees.SelectedText = "";
            this.txtFees.Size = new System.Drawing.Size(284, 33);
            this.txtFees.TabIndex = 101;
            // 
            // txtInternationalLicenseApplicationID
            // 
            this.txtInternationalLicenseApplicationID.BorderRadius = 10;
            this.txtInternationalLicenseApplicationID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInternationalLicenseApplicationID.DefaultText = "";
            this.txtInternationalLicenseApplicationID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInternationalLicenseApplicationID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInternationalLicenseApplicationID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternationalLicenseApplicationID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternationalLicenseApplicationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInternationalLicenseApplicationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInternationalLicenseApplicationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInternationalLicenseApplicationID.Location = new System.Drawing.Point(48, 469);
            this.txtInternationalLicenseApplicationID.Name = "txtInternationalLicenseApplicationID";
            this.txtInternationalLicenseApplicationID.PlaceholderText = "Enter Second Name";
            this.txtInternationalLicenseApplicationID.ReadOnly = true;
            this.txtInternationalLicenseApplicationID.SelectedText = "";
            this.txtInternationalLicenseApplicationID.Size = new System.Drawing.Size(284, 33);
            this.txtInternationalLicenseApplicationID.TabIndex = 100;
            // 
            // txtInternationalLicenseID
            // 
            this.txtInternationalLicenseID.BorderRadius = 10;
            this.txtInternationalLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInternationalLicenseID.DefaultText = "";
            this.txtInternationalLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInternationalLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInternationalLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternationalLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternationalLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInternationalLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInternationalLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInternationalLicenseID.Location = new System.Drawing.Point(383, 469);
            this.txtInternationalLicenseID.Name = "txtInternationalLicenseID";
            this.txtInternationalLicenseID.PlaceholderText = "Enter National No";
            this.txtInternationalLicenseID.ReadOnly = true;
            this.txtInternationalLicenseID.SelectedText = "";
            this.txtInternationalLicenseID.Size = new System.Drawing.Size(284, 33);
            this.txtInternationalLicenseID.TabIndex = 99;
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
            this.btnSave.Location = new System.Drawing.Point(692, 663);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 107;
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
            this.btnClose.Location = new System.Drawing.Point(525, 663);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 39);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lkShowLicenseInfo
            // 
            this.lkShowLicenseInfo.AutoSize = true;
            this.lkShowLicenseInfo.Enabled = false;
            this.lkShowLicenseInfo.Location = new System.Drawing.Point(277, 675);
            this.lkShowLicenseInfo.Name = "lkShowLicenseInfo";
            this.lkShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lkShowLicenseInfo.TabIndex = 109;
            this.lkShowLicenseInfo.TabStop = true;
            this.lkShowLicenseInfo.Text = "Show License Info";
            this.lkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowLicenseInfo_LinkClicked);
            // 
            // lkShowLicenseHistory
            // 
            this.lkShowLicenseHistory.AutoSize = true;
            this.lkShowLicenseHistory.Location = new System.Drawing.Point(149, 675);
            this.lkShowLicenseHistory.Name = "lkShowLicenseHistory";
            this.lkShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.lkShowLicenseHistory.TabIndex = 110;
            this.lkShowLicenseHistory.TabStop = true;
            this.lkShowLicenseHistory.Text = "Show License History";
            this.lkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowLicenseHistory_LinkClicked);
            this.lkShowLicenseHistory.Click += new System.EventHandler(this.lkShowLicenseHistory_Click);
            // 
            // ctrlFiltredLicense
            // 
            this.ctrlFiltredLicense.Location = new System.Drawing.Point(6, 4);
            this.ctrlFiltredLicense.Name = "ctrlFiltredLicense";
            this.ctrlFiltredLicense.Size = new System.Drawing.Size(888, 445);
            this.ctrlFiltredLicense.TabIndex = 0;
            this.ctrlFiltredLicense.OnLicenseSelector += new System.Action<int>(this.ctrlFiltredLicense_OnLicenseSelector);
            // 
            // frmAddNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 714);
            this.Controls.Add(this.lkShowLicenseHistory);
            this.Controls.Add(this.lkShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.dtpApplicationDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.txtLocalLicenseID);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtInternationalLicenseApplicationID);
            this.Controls.Add(this.txtInternationalLicenseID);
            this.Controls.Add(this.ctrlFiltredLicense);
            this.Name = "frmAddNewInternationalLicenseApplication";
            this.Text = "New International License Application";
            this.Load += new System.EventHandler(this.frmAddNewInternationalLicenseApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFiltredLicense ctrlFiltredLicense;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpirationDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpApplicationDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIssueDate;
        private Guna.UI2.WinForms.Guna2TextBox txtLocalLicenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFees;
        private Guna.UI2.WinForms.Guna2TextBox txtInternationalLicenseApplicationID;
        private Guna.UI2.WinForms.Guna2TextBox txtInternationalLicenseID;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.LinkLabel lkShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lkShowLicenseHistory;
    }
}