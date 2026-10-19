namespace DVLD
{
    partial class ctrlFiltredPerson
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
            this.ctrlPersonInfo = new DVLDBusinessLayer.ctrlPersonInfo();
            this.gbFilterBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSesrch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbFilterPersonBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo
            // 
            this.ctrlPersonInfo.Location = new System.Drawing.Point(118, 75);
            this.ctrlPersonInfo.Name = "ctrlPersonInfo";
            this.ctrlPersonInfo.Size = new System.Drawing.Size(880, 372);
            this.ctrlPersonInfo.TabIndex = 12;
            this.ctrlPersonInfo.OnPersonSelector += new System.Action<DVLDBusinessLayer.clsPerson>(this.ctrlPersonInfo_OnPersonSelector);
            // 
            // gbFilterBy
            // 
            this.gbFilterBy.BorderColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.Controls.Add(this.btnAdd);
            this.gbFilterBy.Controls.Add(this.btnSesrch);
            this.gbFilterBy.Controls.Add(this.cbFilterPersonBy);
            this.gbFilterBy.Controls.Add(this.txtFilter);
            this.gbFilterBy.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.FillColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFilterBy.ForeColor = System.Drawing.Color.Transparent;
            this.gbFilterBy.Location = new System.Drawing.Point(151, 15);
            this.gbFilterBy.Name = "gbFilterBy";
            this.gbFilterBy.Size = new System.Drawing.Size(703, 54);
            this.gbFilterBy.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(645, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.Size = new System.Drawing.Size(33, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSesrch
            // 
            this.btnSesrch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSesrch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSesrch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSesrch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSesrch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSesrch.ForeColor = System.Drawing.Color.White;
            this.btnSesrch.Location = new System.Drawing.Point(586, 14);
            this.btnSesrch.Name = "btnSesrch";
            this.btnSesrch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSesrch.Size = new System.Drawing.Size(33, 35);
            this.btnSesrch.TabIndex = 7;
            this.btnSesrch.Text = "Search";
            this.btnSesrch.Click += new System.EventHandler(this.btnSesrch_Click);
            // 
            // cbFilterPersonBy
            // 
            this.cbFilterPersonBy.AutoRoundedCorners = true;
            this.cbFilterPersonBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterPersonBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterPersonBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPersonBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterPersonBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterPersonBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterPersonBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterPersonBy.ItemHeight = 30;
            this.cbFilterPersonBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No"});
            this.cbFilterPersonBy.Location = new System.Drawing.Point(20, 14);
            this.cbFilterPersonBy.Name = "cbFilterPersonBy";
            this.cbFilterPersonBy.Size = new System.Drawing.Size(149, 36);
            this.cbFilterPersonBy.TabIndex = 6;
            this.cbFilterPersonBy.SelectedValueChanged += new System.EventHandler(this.cbFilterPersonBy_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.AutoRoundedCorners = true;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Location = new System.Drawing.Point(200, 14);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(360, 32);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.Visible = false;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // ctrlFiltredPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonInfo);
            this.Controls.Add(this.gbFilterBy);
            this.Name = "ctrlFiltredPerson";
            this.Size = new System.Drawing.Size(1116, 490);
            this.Load += new System.EventHandler(this.ctrlFiltredPerson_Load);
            this.gbFilterBy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DVLDBusinessLayer.ctrlPersonInfo ctrlPersonInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilterBy;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnSesrch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterPersonBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
    }
}
