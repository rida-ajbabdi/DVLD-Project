namespace DVLD
{
    partial class ctrlUserInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlPersonInfo = new DVLDBusinessLayer.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Is Active";
            // 
            // chkIsActive
            // 
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 2;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(100, 444);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(20, 20);
            this.chkIsActive.TabIndex = 79;
            this.chkIsActive.Text = "guna2CustomCheckBox1";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 2;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
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
            this.txtUserName.Location = new System.Drawing.Point(465, 393);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "Enter UserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(298, 33);
            this.txtUserName.TabIndex = 78;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderRadius = 10;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Location = new System.Drawing.Point(100, 393);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderText = "Enter User ID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(298, 33);
            this.txtUserID.TabIndex = 77;
            // 
            // ctrlPersonInfo
            // 
            this.ctrlPersonInfo.Location = new System.Drawing.Point(58, 0);
            this.ctrlPersonInfo.Name = "ctrlPersonInfo";
            this.ctrlPersonInfo.Size = new System.Drawing.Size(901, 377);
            this.ctrlPersonInfo.TabIndex = 76;
            // 
            // ctrlUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.ctrlPersonInfo);
            this.Name = "ctrlUserInfo";
            this.Size = new System.Drawing.Size(1033, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private DVLDBusinessLayer.ctrlPersonInfo ctrlPersonInfo;
    }
}
