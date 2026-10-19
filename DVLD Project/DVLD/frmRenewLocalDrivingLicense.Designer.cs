namespace DVLD
{
    partial class frmRenewLocalDrivingLicense
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
            this.gbRenewApplication = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpApplicationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpExpirationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpIssueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTotalFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRenewedLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApplicationFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewLocalDrivingLicenseApplicationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreatedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLicenseFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.lkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlFiltredLicense = new DVLD.ctrlFiltredLicense();
            this.gbRenewApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRenewApplication
            // 
            this.gbRenewApplication.BackColor = System.Drawing.Color.Transparent;
            this.gbRenewApplication.BorderColor = System.Drawing.Color.Transparent;
            this.gbRenewApplication.Controls.Add(this.label1);
            this.gbRenewApplication.Controls.Add(this.dtpApplicationDate);
            this.gbRenewApplication.Controls.Add(this.dtpExpirationDate);
            this.gbRenewApplication.Controls.Add(this.dtpIssueDate);
            this.gbRenewApplication.Controls.Add(this.txtTotalFees);
            this.gbRenewApplication.Controls.Add(this.txtRenewedLicenseID);
            this.gbRenewApplication.Controls.Add(this.txtOldLicenseID);
            this.gbRenewApplication.Controls.Add(this.txtApplicationFees);
            this.gbRenewApplication.Controls.Add(this.txtNewLocalDrivingLicenseApplicationID);
            this.gbRenewApplication.Controls.Add(this.txtCreatedBy);
            this.gbRenewApplication.Controls.Add(this.txtLicenseFees);
            this.gbRenewApplication.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbRenewApplication.FillColor = System.Drawing.Color.Transparent;
            this.gbRenewApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbRenewApplication.ForeColor = System.Drawing.Color.Transparent;
            this.gbRenewApplication.Location = new System.Drawing.Point(0, 428);
            this.gbRenewApplication.Name = "gbRenewApplication";
            this.gbRenewApplication.Size = new System.Drawing.Size(900, 262);
            this.gbRenewApplication.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 116;
            this.label1.Text = "Notes";
            // 
            // dtpApplicationDate
            // 
            this.dtpApplicationDate.Checked = true;
            this.dtpApplicationDate.Enabled = false;
            this.dtpApplicationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.dtpApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpApplicationDate.Location = new System.Drawing.Point(34, 65);
            this.dtpApplicationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpApplicationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpApplicationDate.Name = "dtpApplicationDate";
            this.dtpApplicationDate.Size = new System.Drawing.Size(298, 33);
            this.dtpApplicationDate.TabIndex = 111;
            this.dtpApplicationDate.Value = new System.DateTime(2025, 12, 17, 16, 11, 3, 360);
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpExpirationDate.Checked = true;
            this.dtpExpirationDate.Enabled = false;
            this.dtpExpirationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpirationDate.Location = new System.Drawing.Point(372, 169);
            this.dtpExpirationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpirationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(298, 33);
            this.dtpExpirationDate.TabIndex = 110;
            this.dtpExpirationDate.Value = new System.DateTime(2025, 12, 17, 16, 11, 3, 360);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Checked = true;
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpIssueDate.ForeColor = System.Drawing.Color.Black;
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpIssueDate.Location = new System.Drawing.Point(34, 120);
            this.dtpIssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(298, 33);
            this.dtpIssueDate.TabIndex = 109;
            this.dtpIssueDate.Value = new System.DateTime(2025, 12, 17, 16, 11, 3, 360);
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
            this.txtTotalFees.Location = new System.Drawing.Point(372, 222);
            this.txtTotalFees.Name = "txtTotalFees";
            this.txtTotalFees.PlaceholderText = "Enter Last Name";
            this.txtTotalFees.ReadOnly = true;
            this.txtTotalFees.SelectedText = "";
            this.txtTotalFees.Size = new System.Drawing.Size(298, 33);
            this.txtTotalFees.TabIndex = 108;
            // 
            // txtRenewedLicenseID
            // 
            this.txtRenewedLicenseID.BorderRadius = 10;
            this.txtRenewedLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRenewedLicenseID.DefaultText = "";
            this.txtRenewedLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRenewedLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRenewedLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRenewedLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRenewedLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRenewedLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRenewedLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRenewedLicenseID.Location = new System.Drawing.Point(372, 8);
            this.txtRenewedLicenseID.Name = "txtRenewedLicenseID";
            this.txtRenewedLicenseID.PlaceholderText = "ID";
            this.txtRenewedLicenseID.ReadOnly = true;
            this.txtRenewedLicenseID.SelectedText = "";
            this.txtRenewedLicenseID.Size = new System.Drawing.Size(298, 33);
            this.txtRenewedLicenseID.TabIndex = 107;
            // 
            // txtOldLicenseID
            // 
            this.txtOldLicenseID.BorderRadius = 10;
            this.txtOldLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldLicenseID.DefaultText = "";
            this.txtOldLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldLicenseID.Location = new System.Drawing.Point(372, 65);
            this.txtOldLicenseID.Name = "txtOldLicenseID";
            this.txtOldLicenseID.PlaceholderText = "Enter Second Name";
            this.txtOldLicenseID.ReadOnly = true;
            this.txtOldLicenseID.SelectedText = "";
            this.txtOldLicenseID.Size = new System.Drawing.Size(298, 33);
            this.txtOldLicenseID.TabIndex = 106;
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
            this.txtApplicationFees.Location = new System.Drawing.Point(34, 165);
            this.txtApplicationFees.Name = "txtApplicationFees";
            this.txtApplicationFees.PlaceholderText = "Enter National No";
            this.txtApplicationFees.ReadOnly = true;
            this.txtApplicationFees.SelectedText = "";
            this.txtApplicationFees.Size = new System.Drawing.Size(298, 33);
            this.txtApplicationFees.TabIndex = 105;
            // 
            // txtNewLocalDrivingLicenseApplicationID
            // 
            this.txtNewLocalDrivingLicenseApplicationID.BorderRadius = 10;
            this.txtNewLocalDrivingLicenseApplicationID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewLocalDrivingLicenseApplicationID.DefaultText = "";
            this.txtNewLocalDrivingLicenseApplicationID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewLocalDrivingLicenseApplicationID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewLocalDrivingLicenseApplicationID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewLocalDrivingLicenseApplicationID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewLocalDrivingLicenseApplicationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewLocalDrivingLicenseApplicationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewLocalDrivingLicenseApplicationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewLocalDrivingLicenseApplicationID.Location = new System.Drawing.Point(34, 8);
            this.txtNewLocalDrivingLicenseApplicationID.Name = "txtNewLocalDrivingLicenseApplicationID";
            this.txtNewLocalDrivingLicenseApplicationID.PlaceholderText = "ID";
            this.txtNewLocalDrivingLicenseApplicationID.ReadOnly = true;
            this.txtNewLocalDrivingLicenseApplicationID.SelectedText = "";
            this.txtNewLocalDrivingLicenseApplicationID.Size = new System.Drawing.Size(298, 33);
            this.txtNewLocalDrivingLicenseApplicationID.TabIndex = 104;
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
            this.txtCreatedBy.Location = new System.Drawing.Point(372, 120);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PlaceholderText = "Enter Last Name";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.Size = new System.Drawing.Size(298, 33);
            this.txtCreatedBy.TabIndex = 103;
            // 
            // txtLicenseFees
            // 
            this.txtLicenseFees.BorderRadius = 10;
            this.txtLicenseFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseFees.DefaultText = "";
            this.txtLicenseFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicenseFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicenseFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenseFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenseFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenseFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicenseFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenseFees.Location = new System.Drawing.Point(34, 222);
            this.txtLicenseFees.Name = "txtLicenseFees";
            this.txtLicenseFees.PlaceholderText = "Enter Third Name";
            this.txtLicenseFees.ReadOnly = true;
            this.txtLicenseFees.SelectedText = "";
            this.txtLicenseFees.Size = new System.Drawing.Size(298, 33);
            this.txtLicenseFees.TabIndex = 100;
            // 
            // lkShowLicenseHistory
            // 
            this.lkShowLicenseHistory.AutoSize = true;
            this.lkShowLicenseHistory.Location = new System.Drawing.Point(138, 760);
            this.lkShowLicenseHistory.Name = "lkShowLicenseHistory";
            this.lkShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.lkShowLicenseHistory.TabIndex = 114;
            this.lkShowLicenseHistory.TabStop = true;
            this.lkShowLicenseHistory.Text = "Show License History";
            this.lkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowLicenseHistory_LinkClicked);
            // 
            // lkShowLicenseInfo
            // 
            this.lkShowLicenseInfo.AutoSize = true;
            this.lkShowLicenseInfo.Enabled = false;
            this.lkShowLicenseInfo.Location = new System.Drawing.Point(266, 760);
            this.lkShowLicenseInfo.Name = "lkShowLicenseInfo";
            this.lkShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lkShowLicenseInfo.TabIndex = 113;
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
            this.btnClose.Location = new System.Drawing.Point(514, 748);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 39);
            this.btnClose.TabIndex = 112;
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
            this.btnSave.Location = new System.Drawing.Point(681, 748);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 20;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(34, 708);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Enter Yout Notes ...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(633, 34);
            this.txtNotes.TabIndex = 115;
            // 
            // ctrlFiltredLicense
            // 
            this.ctrlFiltredLicense.Location = new System.Drawing.Point(3, -3);
            this.ctrlFiltredLicense.Name = "ctrlFiltredLicense";
            this.ctrlFiltredLicense.Size = new System.Drawing.Size(900, 440);
            this.ctrlFiltredLicense.TabIndex = 0;
            this.ctrlFiltredLicense.OnLicenseSelector += new System.Action<int>(this.ctrlFiltredLicense_OnLicenseSelector);
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 796);
            this.Controls.Add(this.lkShowLicenseHistory);
            this.Controls.Add(this.lkShowLicenseInfo);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbRenewApplication);
            this.Controls.Add(this.ctrlFiltredLicense);
            this.Name = "frmRenewLocalDrivingLicense";
            this.Text = "frmRenewLocalDrivingLicense";
            this.Load += new System.EventHandler(this.frmRenewLocalDrivingLicense_Load);
            this.gbRenewApplication.ResumeLayout(false);
            this.gbRenewApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFiltredLicense ctrlFiltredLicense;
        private Guna.UI2.WinForms.Guna2GroupBox gbRenewApplication;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpApplicationDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpirationDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIssueDate;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalFees;
        private Guna.UI2.WinForms.Guna2TextBox txtRenewedLicenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtOldLicenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtApplicationFees;
        private Guna.UI2.WinForms.Guna2TextBox txtNewLocalDrivingLicenseApplicationID;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedBy;
        private Guna.UI2.WinForms.Guna2TextBox txtLicenseFees;
        private System.Windows.Forms.LinkLabel lkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lkShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
    }
}