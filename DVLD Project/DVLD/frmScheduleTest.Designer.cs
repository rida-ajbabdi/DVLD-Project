namespace DVLD
{
    partial class frmScheduleTest
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
            this.ctrlTestInfo = new DVLD.ctrlTestInfo();
            this.gbRetackTest = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRetakTestID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRetakTestFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbRetackTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTestInfo
            // 
            this.ctrlTestInfo.Location = new System.Drawing.Point(26, 14);
            this.ctrlTestInfo.Name = "ctrlTestInfo";
            this.ctrlTestInfo.Size = new System.Drawing.Size(392, 372);
            this.ctrlTestInfo.TabIndex = 0;
            this.ctrlTestInfo.Load += new System.EventHandler(this.ctrlTestInfo_Load);
            // 
            // gbRetackTest
            // 
            this.gbRetackTest.BackColor = System.Drawing.Color.Transparent;
            this.gbRetackTest.BorderRadius = 20;
            this.gbRetackTest.Controls.Add(this.txtTotal);
            this.gbRetackTest.Controls.Add(this.txtRetakTestID);
            this.gbRetackTest.Controls.Add(this.txtRetakTestFees);
            this.gbRetackTest.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbRetackTest.FillColor = System.Drawing.Color.Transparent;
            this.gbRetackTest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbRetackTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbRetackTest.Location = new System.Drawing.Point(26, 392);
            this.gbRetackTest.Name = "gbRetackTest";
            this.gbRetackTest.Size = new System.Drawing.Size(362, 196);
            this.gbRetackTest.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderRadius = 10;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(48, 129);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "Enter Second Name";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(265, 33);
            this.txtTotal.TabIndex = 78;
            // 
            // txtRetakTestID
            // 
            this.txtRetakTestID.BorderRadius = 10;
            this.txtRetakTestID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetakTestID.DefaultText = "";
            this.txtRetakTestID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRetakTestID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRetakTestID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetakTestID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetakTestID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRetakTestID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRetakTestID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRetakTestID.Location = new System.Drawing.Point(48, 26);
            this.txtRetakTestID.Name = "txtRetakTestID";
            this.txtRetakTestID.PlaceholderText = "ID";
            this.txtRetakTestID.ReadOnly = true;
            this.txtRetakTestID.SelectedText = "";
            this.txtRetakTestID.Size = new System.Drawing.Size(265, 33);
            this.txtRetakTestID.TabIndex = 77;
            // 
            // txtRetakTestFees
            // 
            this.txtRetakTestFees.BorderRadius = 10;
            this.txtRetakTestFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetakTestFees.DefaultText = "";
            this.txtRetakTestFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRetakTestFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRetakTestFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetakTestFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetakTestFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRetakTestFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRetakTestFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRetakTestFees.Location = new System.Drawing.Point(48, 78);
            this.txtRetakTestFees.Name = "txtRetakTestFees";
            this.txtRetakTestFees.PlaceholderText = "Enter Second Name";
            this.txtRetakTestFees.SelectedText = "";
            this.txtRetakTestFees.Size = new System.Drawing.Size(265, 33);
            this.txtRetakTestFees.TabIndex = 76;
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(237, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 690);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbRetackTest);
            this.Controls.Add(this.ctrlTestInfo);
            this.Name = "frmScheduleTest";
            this.Text = "frmScheduleTest";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.gbRetackTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTestInfo ctrlTestInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbRetackTest;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtRetakTestID;
        private Guna.UI2.WinForms.Guna2TextBox txtRetakTestFees;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}