namespace DVLD
{
    partial class frmReplacementForDamagedOrLostLicense
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
            this.gbRemplacementLicenseApplication = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpApplicationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtReplacedLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApplicationFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtReplacedLicenseApplicationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreatedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlFiltredLicense = new DVLD.ctrlFiltredLicense();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbLostLicense = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbDamagedLicense = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.gbRemplacementLicenseApplication.SuspendLayout();
            this.gbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lkShowLicenseHistory
            // 
            this.lkShowLicenseHistory.AutoSize = true;
            this.lkShowLicenseHistory.Location = new System.Drawing.Point(138, 193);
            this.lkShowLicenseHistory.Name = "lkShowLicenseHistory";
            this.lkShowLicenseHistory.Size = new System.Drawing.Size(119, 15);
            this.lkShowLicenseHistory.TabIndex = 121;
            this.lkShowLicenseHistory.TabStop = true;
            this.lkShowLicenseHistory.Text = "Show License History";
            this.lkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowLicenseHistory_LinkClicked);
            // 
            // lkShowLicenseInfo
            // 
            this.lkShowLicenseInfo.AutoSize = true;
            this.lkShowLicenseInfo.Enabled = false;
            this.lkShowLicenseInfo.Location = new System.Drawing.Point(266, 193);
            this.lkShowLicenseInfo.Name = "lkShowLicenseInfo";
            this.lkShowLicenseInfo.Size = new System.Drawing.Size(102, 15);
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
            this.btnClose.Location = new System.Drawing.Point(514, 181);
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
            this.btnSave.Location = new System.Drawing.Point(681, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbRemplacementLicenseApplication
            // 
            this.gbRemplacementLicenseApplication.BackColor = System.Drawing.Color.Transparent;
            this.gbRemplacementLicenseApplication.BorderColor = System.Drawing.Color.Transparent;
            this.gbRemplacementLicenseApplication.Controls.Add(this.lkShowLicenseHistory);
            this.gbRemplacementLicenseApplication.Controls.Add(this.label1);
            this.gbRemplacementLicenseApplication.Controls.Add(this.lkShowLicenseInfo);
            this.gbRemplacementLicenseApplication.Controls.Add(this.dtpApplicationDate);
            this.gbRemplacementLicenseApplication.Controls.Add(this.btnClose);
            this.gbRemplacementLicenseApplication.Controls.Add(this.btnSave);
            this.gbRemplacementLicenseApplication.Controls.Add(this.txtReplacedLicenseID);
            this.gbRemplacementLicenseApplication.Controls.Add(this.txtOldLicenseID);
            this.gbRemplacementLicenseApplication.Controls.Add(this.txtApplicationFees);
            this.gbRemplacementLicenseApplication.Controls.Add(this.txtReplacedLicenseApplicationID);
            this.gbRemplacementLicenseApplication.Controls.Add(this.txtCreatedBy);
            this.gbRemplacementLicenseApplication.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbRemplacementLicenseApplication.FillColor = System.Drawing.Color.Transparent;
            this.gbRemplacementLicenseApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbRemplacementLicenseApplication.ForeColor = System.Drawing.Color.Transparent;
            this.gbRemplacementLicenseApplication.Location = new System.Drawing.Point(14, 434);
            this.gbRemplacementLicenseApplication.Name = "gbRemplacementLicenseApplication";
            this.gbRemplacementLicenseApplication.Size = new System.Drawing.Size(900, 262);
            this.gbRemplacementLicenseApplication.TabIndex = 117;
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
            // txtReplacedLicenseID
            // 
            this.txtReplacedLicenseID.BorderRadius = 10;
            this.txtReplacedLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplacedLicenseID.DefaultText = "";
            this.txtReplacedLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReplacedLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReplacedLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReplacedLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReplacedLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReplacedLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReplacedLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReplacedLicenseID.Location = new System.Drawing.Point(372, 8);
            this.txtReplacedLicenseID.Name = "txtReplacedLicenseID";
            this.txtReplacedLicenseID.PlaceholderText = "ID";
            this.txtReplacedLicenseID.ReadOnly = true;
            this.txtReplacedLicenseID.SelectedText = "";
            this.txtReplacedLicenseID.Size = new System.Drawing.Size(298, 33);
            this.txtReplacedLicenseID.TabIndex = 107;
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
            this.txtApplicationFees.Location = new System.Drawing.Point(34, 120);
            this.txtApplicationFees.Name = "txtApplicationFees";
            this.txtApplicationFees.PlaceholderText = "Enter National No";
            this.txtApplicationFees.ReadOnly = true;
            this.txtApplicationFees.SelectedText = "";
            this.txtApplicationFees.Size = new System.Drawing.Size(298, 33);
            this.txtApplicationFees.TabIndex = 105;
            // 
            // txtReplacedLicenseApplicationID
            // 
            this.txtReplacedLicenseApplicationID.BorderRadius = 10;
            this.txtReplacedLicenseApplicationID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplacedLicenseApplicationID.DefaultText = "";
            this.txtReplacedLicenseApplicationID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReplacedLicenseApplicationID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReplacedLicenseApplicationID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReplacedLicenseApplicationID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReplacedLicenseApplicationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReplacedLicenseApplicationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReplacedLicenseApplicationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReplacedLicenseApplicationID.Location = new System.Drawing.Point(34, 8);
            this.txtReplacedLicenseApplicationID.Name = "txtReplacedLicenseApplicationID";
            this.txtReplacedLicenseApplicationID.PlaceholderText = "ID";
            this.txtReplacedLicenseApplicationID.ReadOnly = true;
            this.txtReplacedLicenseApplicationID.SelectedText = "";
            this.txtReplacedLicenseApplicationID.Size = new System.Drawing.Size(298, 33);
            this.txtReplacedLicenseApplicationID.TabIndex = 104;
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
            // ctrlFiltredLicense
            // 
            this.ctrlFiltredLicense.Location = new System.Drawing.Point(17, 3);
            this.ctrlFiltredLicense.Name = "ctrlFiltredLicense";
            this.ctrlFiltredLicense.Size = new System.Drawing.Size(900, 440);
            this.ctrlFiltredLicense.TabIndex = 116;
            this.ctrlFiltredLicense.OnLicenseSelector += new System.Action<int>(this.ctrlFiltredLicense_OnLicenseSelector);
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.BackColor = System.Drawing.Color.Transparent;
            this.gbReplacementFor.Controls.Add(this.label3);
            this.gbReplacementFor.Controls.Add(this.label2);
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Location = new System.Drawing.Point(740, 12);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(178, 76);
            this.gbReplacementFor.TabIndex = 120;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Lost License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Damaged License";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLostLicense.CheckedState.BorderThickness = 0;
            this.rbLostLicense.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLostLicense.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLostLicense.Location = new System.Drawing.Point(29, 44);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(18, 24);
            this.rbLostLicense.TabIndex = 121;
            this.rbLostLicense.Text = "guna2CustomRadioButton2";
            this.rbLostLicense.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLostLicense.UncheckedState.BorderThickness = 2;
            this.rbLostLicense.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLostLicense.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbReplacementFor_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDamagedLicense.CheckedState.BorderThickness = 0;
            this.rbDamagedLicense.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDamagedLicense.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDamagedLicense.Location = new System.Drawing.Point(29, 14);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(18, 24);
            this.rbDamagedLicense.TabIndex = 120;
            this.rbDamagedLicense.Text = "guna2CustomRadioButton1";
            this.rbDamagedLicense.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDamagedLicense.UncheckedState.BorderThickness = 2;
            this.rbDamagedLicense.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDamagedLicense.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbReplacementFor_CheckedChanged);
            // 
            // frmReplacementForDamagedOrLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 673);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.gbRemplacementLicenseApplication);
            this.Controls.Add(this.ctrlFiltredLicense);
            this.Name = "frmReplacementForDamagedOrLostLicense";
            this.Text = "frmReplacementForDamagedOrLostLicense";
            this.Load += new System.EventHandler(this.frmReplacementForDamagedOrLostLicense_Load);
            this.gbRemplacementLicenseApplication.ResumeLayout(false);
            this.gbRemplacementLicenseApplication.PerformLayout();
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lkShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2GroupBox gbRemplacementLicenseApplication;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpApplicationDate;
        private Guna.UI2.WinForms.Guna2TextBox txtReplacedLicenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtOldLicenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtApplicationFees;
        private Guna.UI2.WinForms.Guna2TextBox txtReplacedLicenseApplicationID;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedBy;
        private ctrlFiltredLicense ctrlFiltredLicense;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbLostLicense;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbDamagedLicense;
    }
}