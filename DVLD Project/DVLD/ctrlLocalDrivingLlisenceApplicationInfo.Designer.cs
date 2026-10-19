namespace DVLD
{
    partial class ctrlLocalDrivingLlisenceApplicationInfo
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLisenceClass = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbPassedTestCount = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.gbLocalDriverLisenceApplication = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblPassedTest = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbApplicaitonInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ctrlApplicationInfo = new DVLD.ctrlApplicationInfo();
            this.gbLocalDriverLisenceApplication.SuspendLayout();
            this.gbApplicaitonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 10;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(26, 12);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "ID";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(347, 38);
            this.txtID.TabIndex = 110;
            // 
            // txtLisenceClass
            // 
            this.txtLisenceClass.BorderRadius = 10;
            this.txtLisenceClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLisenceClass.DefaultText = "";
            this.txtLisenceClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLisenceClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLisenceClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLisenceClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLisenceClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLisenceClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLisenceClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLisenceClass.Location = new System.Drawing.Point(440, 12);
            this.txtLisenceClass.Name = "txtLisenceClass";
            this.txtLisenceClass.PlaceholderText = "Lisence Class";
            this.txtLisenceClass.ReadOnly = true;
            this.txtLisenceClass.SelectedText = "";
            this.txtLisenceClass.Size = new System.Drawing.Size(347, 38);
            this.txtLisenceClass.TabIndex = 108;
            // 
            // pbPassedTestCount
            // 
            this.pbPassedTestCount.AutoRoundedCorners = true;
            this.pbPassedTestCount.Location = new System.Drawing.Point(34, 61);
            this.pbPassedTestCount.Maximum = 3;
            this.pbPassedTestCount.Name = "pbPassedTestCount";
            this.pbPassedTestCount.ProgressColor2 = System.Drawing.Color.Green;
            this.pbPassedTestCount.Size = new System.Drawing.Size(215, 30);
            this.pbPassedTestCount.TabIndex = 111;
            this.pbPassedTestCount.Text = "0";
            this.pbPassedTestCount.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.pbPassedTestCount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // gbLocalDriverLisenceApplication
            // 
            this.gbLocalDriverLisenceApplication.BackColor = System.Drawing.Color.Transparent;
            this.gbLocalDriverLisenceApplication.Controls.Add(this.lblPassedTest);
            this.gbLocalDriverLisenceApplication.Controls.Add(this.pbPassedTestCount);
            this.gbLocalDriverLisenceApplication.Controls.Add(this.txtID);
            this.gbLocalDriverLisenceApplication.Controls.Add(this.txtLisenceClass);
            this.gbLocalDriverLisenceApplication.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbLocalDriverLisenceApplication.FillColor = System.Drawing.Color.Transparent;
            this.gbLocalDriverLisenceApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbLocalDriverLisenceApplication.ForeColor = System.Drawing.Color.Transparent;
            this.gbLocalDriverLisenceApplication.Location = new System.Drawing.Point(16, 373);
            this.gbLocalDriverLisenceApplication.Name = "gbLocalDriverLisenceApplication";
            this.gbLocalDriverLisenceApplication.Size = new System.Drawing.Size(808, 112);
            this.gbLocalDriverLisenceApplication.TabIndex = 112;
            // 
            // lblPassedTest
            // 
            this.lblPassedTest.AutoSize = false;
            this.lblPassedTest.BackColor = System.Drawing.Color.Transparent;
            this.lblPassedTest.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTest.ForeColor = System.Drawing.Color.Green;
            this.lblPassedTest.Location = new System.Drawing.Point(265, 61);
            this.lblPassedTest.Name = "lblPassedTest";
            this.lblPassedTest.Size = new System.Drawing.Size(61, 30);
            this.lblPassedTest.TabIndex = 112;
            this.lblPassedTest.Text = "0 / 3";
            // 
            // gbApplicaitonInfo
            // 
            this.gbApplicaitonInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbApplicaitonInfo.Controls.Add(this.ctrlApplicationInfo);
            this.gbApplicaitonInfo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbApplicaitonInfo.FillColor = System.Drawing.Color.Transparent;
            this.gbApplicaitonInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbApplicaitonInfo.ForeColor = System.Drawing.Color.Transparent;
            this.gbApplicaitonInfo.Location = new System.Drawing.Point(16, 11);
            this.gbApplicaitonInfo.Name = "gbApplicaitonInfo";
            this.gbApplicaitonInfo.Size = new System.Drawing.Size(808, 356);
            this.gbApplicaitonInfo.TabIndex = 113;
            // 
            // ctrlApplicationInfo
            // 
            this.ctrlApplicationInfo.Location = new System.Drawing.Point(9, 11);
            this.ctrlApplicationInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlApplicationInfo.Name = "ctrlApplicationInfo";
            this.ctrlApplicationInfo.Size = new System.Drawing.Size(795, 342);
            this.ctrlApplicationInfo.TabIndex = 114;
            // 
            // ctrlLocalDrivingLlisenceApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbApplicaitonInfo);
            this.Controls.Add(this.gbLocalDriverLisenceApplication);
            this.Name = "ctrlLocalDrivingLlisenceApplicationInfo";
            this.Size = new System.Drawing.Size(847, 505);
            this.gbLocalDriverLisenceApplication.ResumeLayout(false);
            this.gbApplicaitonInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2TextBox txtLisenceClass;
        private Guna.UI2.WinForms.Guna2ProgressBar pbPassedTestCount;
        private Guna.UI2.WinForms.Guna2GroupBox gbLocalDriverLisenceApplication;
        private Guna.UI2.WinForms.Guna2GroupBox gbApplicaitonInfo;
        private ctrlApplicationInfo ctrlApplicationInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPassedTest;
    }
}
