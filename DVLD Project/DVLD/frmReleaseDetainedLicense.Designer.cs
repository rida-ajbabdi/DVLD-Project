namespace DVLD
{
    partial class frmReleaseDetainedLicense
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
            this.lkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlFiltredLicense = new DVLD.ctrlFiltredLicense();
            this.gbReleaseDatainLicenseApplication = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtApplicationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApplicationFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDetainDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFineFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDetainID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreatedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbReleaseDatainLicenseApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lkShowLicenseHistory
            // 
            this.lkShowLicenseHistory.AutoSize = true;
            this.lkShowLicenseHistory.Location = new System.Drawing.Point(164, 704);
            this.lkShowLicenseHistory.Name = "lkShowLicenseHistory";
            this.lkShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.lkShowLicenseHistory.TabIndex = 121;
            this.lkShowLicenseHistory.TabStop = true;
            this.lkShowLicenseHistory.Text = "Show License History";
            this.lkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowLicenseHistory_LinkClicked);
            // 
            // lkShowLicenseInfo
            // 
            this.lkShowLicenseInfo.AutoSize = true;
            this.lkShowLicenseInfo.Enabled = false;
            this.lkShowLicenseInfo.Location = new System.Drawing.Point(292, 704);
            this.lkShowLicenseInfo.Name = "lkShowLicenseInfo";
            this.lkShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lkShowLicenseInfo.TabIndex = 120;
            this.lkShowLicenseInfo.TabStop = true;
            this.lkShowLicenseInfo.Text = "Show License Info";
            this.lkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowLicenseInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(540, 692);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 39);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(707, 692);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlFiltredLicense
            // 
            this.ctrlFiltredLicense.Location = new System.Drawing.Point(17, 3);
            this.ctrlFiltredLicense.Name = "ctrlFiltredLicense";
            this.ctrlFiltredLicense.Size = new System.Drawing.Size(900, 440);
            this.ctrlFiltredLicense.TabIndex = 116;
            this.ctrlFiltredLicense.OnLicenseSelector += new System.Action<int>(this.ctrlFiltredLicense_OnLicenseSelector);
            // 
            // gbReleaseDatainLicenseApplication
            // 
            this.gbReleaseDatainLicenseApplication.BackColor = System.Drawing.Color.Transparent;
            this.gbReleaseDatainLicenseApplication.BorderColor = System.Drawing.Color.Transparent;
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.txtApplicationID);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.txtApplicationFees);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.txtTotalFees);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.label2);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.dtpDetainDate);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.txtFineFees);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.txtLicenseID);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.txtDetainID);
            this.gbReleaseDatainLicenseApplication.Controls.Add(this.txtCreatedBy);
            this.gbReleaseDatainLicenseApplication.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbReleaseDatainLicenseApplication.FillColor = System.Drawing.Color.Transparent;
            this.gbReleaseDatainLicenseApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbReleaseDatainLicenseApplication.ForeColor = System.Drawing.Color.Transparent;
            this.gbReleaseDatainLicenseApplication.Location = new System.Drawing.Point(12, 449);
            this.gbReleaseDatainLicenseApplication.Name = "gbReleaseDatainLicenseApplication";
            this.gbReleaseDatainLicenseApplication.Size = new System.Drawing.Size(900, 212);
            this.gbReleaseDatainLicenseApplication.TabIndex = 122;
            // 
            // txtApplicationID
            // 
            this.txtApplicationID.BorderRadius = 10;
            this.txtApplicationID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApplicationID.DefaultText = "";
            this.txtApplicationID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApplicationID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApplicationID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApplicationID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApplicationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApplicationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApplicationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApplicationID.Location = new System.Drawing.Point(393, 179);
            this.txtApplicationID.Name = "txtApplicationID";
            this.txtApplicationID.PlaceholderText = "Application ID";
            this.txtApplicationID.ReadOnly = true;
            this.txtApplicationID.SelectedText = "";
            this.txtApplicationID.Size = new System.Drawing.Size(298, 33);
            this.txtApplicationID.TabIndex = 125;
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
            this.txtApplicationFees.Location = new System.Drawing.Point(44, 124);
            this.txtApplicationFees.Name = "txtApplicationFees";
            this.txtApplicationFees.PlaceholderText = "Application Fees";
            this.txtApplicationFees.ReadOnly = true;
            this.txtApplicationFees.SelectedText = "";
            this.txtApplicationFees.Size = new System.Drawing.Size(298, 33);
            this.txtApplicationFees.TabIndex = 124;
            // 
            // txtTotalFees
            // 
            this.txtTotalFees.BorderRadius = 10;
            this.txtTotalFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalFees.DefaultText = "";
            this.txtTotalFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalFees.Location = new System.Drawing.Point(44, 177);
            this.txtTotalFees.Name = "txtTotalFees";
            this.txtTotalFees.PlaceholderText = "Total Fees";
            this.txtTotalFees.ReadOnly = true;
            this.txtTotalFees.SelectedText = "";
            this.txtTotalFees.Size = new System.Drawing.Size(298, 33);
            this.txtTotalFees.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 116;
            this.label2.Text = "Notes";
            // 
            // dtpDetainDate
            // 
            this.dtpDetainDate.Checked = true;
            this.dtpDetainDate.Enabled = false;
            this.dtpDetainDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDetainDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDetainDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDetainDate.Location = new System.Drawing.Point(44, 73);
            this.dtpDetainDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDetainDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDetainDate.Name = "dtpDetainDate";
            this.dtpDetainDate.Size = new System.Drawing.Size(298, 33);
            this.dtpDetainDate.TabIndex = 111;
            this.dtpDetainDate.Value = new System.DateTime(2025, 12, 17, 16, 11, 3, 360);
            // 
            // txtFineFees
            // 
            this.txtFineFees.BorderRadius = 10;
            this.txtFineFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFineFees.DefaultText = "";
            this.txtFineFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFineFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFineFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFineFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFineFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFineFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFineFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFineFees.Location = new System.Drawing.Point(393, 124);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.PlaceholderText = "Fine Fees";
            this.txtFineFees.SelectedText = "";
            this.txtFineFees.Size = new System.Drawing.Size(298, 33);
            this.txtFineFees.TabIndex = 122;
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.BorderRadius = 10;
            this.txtLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseID.DefaultText = "";
            this.txtLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenseID.Location = new System.Drawing.Point(393, 22);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.PlaceholderText = "License ID";
            this.txtLicenseID.ReadOnly = true;
            this.txtLicenseID.SelectedText = "";
            this.txtLicenseID.Size = new System.Drawing.Size(298, 33);
            this.txtLicenseID.TabIndex = 107;
            // 
            // txtDetainID
            // 
            this.txtDetainID.BorderRadius = 10;
            this.txtDetainID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetainID.DefaultText = "";
            this.txtDetainID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetainID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetainID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetainID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetainID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetainID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDetainID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetainID.Location = new System.Drawing.Point(44, 22);
            this.txtDetainID.Name = "txtDetainID";
            this.txtDetainID.PlaceholderText = "Detain ID";
            this.txtDetainID.ReadOnly = true;
            this.txtDetainID.SelectedText = "";
            this.txtDetainID.Size = new System.Drawing.Size(298, 33);
            this.txtDetainID.TabIndex = 104;
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
            this.txtCreatedBy.Location = new System.Drawing.Point(393, 73);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PlaceholderText = "Created By";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.Size = new System.Drawing.Size(298, 33);
            this.txtCreatedBy.TabIndex = 103;
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 776);
            this.Controls.Add(this.gbReleaseDatainLicenseApplication);
            this.Controls.Add(this.lkShowLicenseHistory);
            this.Controls.Add(this.lkShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlFiltredLicense);
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "frmReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.gbReleaseDatainLicenseApplication.ResumeLayout(false);
            this.gbReleaseDatainLicenseApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lkShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private ctrlFiltredLicense ctrlFiltredLicense;
        private Guna.UI2.WinForms.Guna2GroupBox gbReleaseDatainLicenseApplication;
        private Guna.UI2.WinForms.Guna2TextBox txtApplicationID;
        private Guna.UI2.WinForms.Guna2TextBox txtApplicationFees;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalFees;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDetainDate;
        private Guna.UI2.WinForms.Guna2TextBox txtFineFees;
        private Guna.UI2.WinForms.Guna2TextBox txtLicenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtDetainID;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedBy;
    }
}