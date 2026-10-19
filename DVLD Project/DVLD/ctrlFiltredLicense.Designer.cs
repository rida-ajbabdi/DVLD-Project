namespace DVLD
{
    partial class ctrlFiltredLicense
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
            this.ctrlDriverLicenseInfo = new DVLD.ctrlDriverLicenseInfo();
            this.txtLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfo
            // 
            this.ctrlDriverLicenseInfo.Location = new System.Drawing.Point(14, 54);
            this.ctrlDriverLicenseInfo.Name = "ctrlDriverLicenseInfo";
            this.ctrlDriverLicenseInfo.Size = new System.Drawing.Size(880, 384);
            this.ctrlDriverLicenseInfo.TabIndex = 0;
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.AutoRoundedCorners = true;
            this.txtLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseID.DefaultText = "";
            this.txtLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenseID.Location = new System.Drawing.Point(40, 14);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.PlaceholderText = "Enter License ID";
            this.txtLicenseID.SelectedText = "";
            this.txtLicenseID.Size = new System.Drawing.Size(611, 34);
            this.txtLicenseID.TabIndex = 1;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(677, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "guna2CircleButton1";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlFiltredLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLicenseID);
            this.Controls.Add(this.ctrlDriverLicenseInfo);
            this.Name = "ctrlFiltredLicense";
            this.Size = new System.Drawing.Size(910, 443);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtLicenseID;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
    }
}
