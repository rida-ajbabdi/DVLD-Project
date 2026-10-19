namespace DVLD
{
    partial class ctrlDriverLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbDriverLicenses = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbLocal = new System.Windows.Forms.TabPage();
            this.tbInternational = new System.Windows.Forms.TabPage();
            this.dgvListInternationalDriverLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvListLocalDriverLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbDriverLicenses.SuspendLayout();
            this.tbLocal.SuspendLayout();
            this.tbInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalDriverLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLocalDriverLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDriverLicenses
            // 
            this.tbDriverLicenses.Controls.Add(this.tbLocal);
            this.tbDriverLicenses.Controls.Add(this.tbInternational);
            this.tbDriverLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDriverLicenses.ItemSize = new System.Drawing.Size(180, 40);
            this.tbDriverLicenses.Location = new System.Drawing.Point(0, 0);
            this.tbDriverLicenses.Name = "tbDriverLicenses";
            this.tbDriverLicenses.SelectedIndex = 0;
            this.tbDriverLicenses.Size = new System.Drawing.Size(908, 311);
            this.tbDriverLicenses.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbDriverLicenses.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbDriverLicenses.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbDriverLicenses.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbDriverLicenses.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbDriverLicenses.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbDriverLicenses.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbDriverLicenses.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbDriverLicenses.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbDriverLicenses.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbDriverLicenses.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbDriverLicenses.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbDriverLicenses.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbDriverLicenses.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbDriverLicenses.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbDriverLicenses.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbDriverLicenses.TabIndex = 0;
            this.tbDriverLicenses.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbDriverLicenses.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbLocal
            // 
            this.tbLocal.Controls.Add(this.dgvListLocalDriverLicenses);
            this.tbLocal.Location = new System.Drawing.Point(4, 44);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocal.Size = new System.Drawing.Size(900, 263);
            this.tbLocal.TabIndex = 0;
            this.tbLocal.Text = "Local";
            this.tbLocal.UseVisualStyleBackColor = true;
            // 
            // tbInternational
            // 
            this.tbInternational.Controls.Add(this.dgvListInternationalDriverLicenses);
            this.tbInternational.Location = new System.Drawing.Point(4, 44);
            this.tbInternational.Name = "tbInternational";
            this.tbInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternational.Size = new System.Drawing.Size(900, 263);
            this.tbInternational.TabIndex = 1;
            this.tbInternational.Text = "International";
            this.tbInternational.UseVisualStyleBackColor = true;
            // 
            // dgvListInternationalDriverLicenses
            // 
            this.dgvListInternationalDriverLicenses.AllowUserToAddRows = false;
            this.dgvListInternationalDriverLicenses.AllowUserToDeleteRows = false;
            this.dgvListInternationalDriverLicenses.AllowUserToOrderColumns = true;
            this.dgvListInternationalDriverLicenses.AllowUserToResizeColumns = false;
            this.dgvListInternationalDriverLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvListInternationalDriverLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListInternationalDriverLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListInternationalDriverLicenses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListInternationalDriverLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListInternationalDriverLicenses.Location = new System.Drawing.Point(60, 6);
            this.dgvListInternationalDriverLicenses.Name = "dgvListInternationalDriverLicenses";
            this.dgvListInternationalDriverLicenses.ReadOnly = true;
            this.dgvListInternationalDriverLicenses.RowHeadersVisible = false;
            this.dgvListInternationalDriverLicenses.Size = new System.Drawing.Size(666, 237);
            this.dgvListInternationalDriverLicenses.TabIndex = 8;
            this.dgvListInternationalDriverLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListInternationalDriverLicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListInternationalDriverLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListInternationalDriverLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListInternationalDriverLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListInternationalDriverLicenses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListInternationalDriverLicenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListInternationalDriverLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListInternationalDriverLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListInternationalDriverLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListInternationalDriverLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListInternationalDriverLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListInternationalDriverLicenses.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvListInternationalDriverLicenses.ThemeStyle.ReadOnly = true;
            this.dgvListInternationalDriverLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListInternationalDriverLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListInternationalDriverLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListInternationalDriverLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListInternationalDriverLicenses.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListInternationalDriverLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListInternationalDriverLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvListLocalDriverLicenses
            // 
            this.dgvListLocalDriverLicenses.AllowUserToAddRows = false;
            this.dgvListLocalDriverLicenses.AllowUserToDeleteRows = false;
            this.dgvListLocalDriverLicenses.AllowUserToOrderColumns = true;
            this.dgvListLocalDriverLicenses.AllowUserToResizeColumns = false;
            this.dgvListLocalDriverLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListLocalDriverLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListLocalDriverLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListLocalDriverLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListLocalDriverLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListLocalDriverLicenses.Location = new System.Drawing.Point(103, 6);
            this.dgvListLocalDriverLicenses.Name = "dgvListLocalDriverLicenses";
            this.dgvListLocalDriverLicenses.ReadOnly = true;
            this.dgvListLocalDriverLicenses.RowHeadersVisible = false;
            this.dgvListLocalDriverLicenses.Size = new System.Drawing.Size(666, 244);
            this.dgvListLocalDriverLicenses.TabIndex = 8;
            this.dgvListLocalDriverLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListLocalDriverLicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListLocalDriverLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListLocalDriverLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListLocalDriverLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListLocalDriverLicenses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListLocalDriverLicenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListLocalDriverLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListLocalDriverLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListLocalDriverLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListLocalDriverLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListLocalDriverLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListLocalDriverLicenses.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvListLocalDriverLicenses.ThemeStyle.ReadOnly = true;
            this.dgvListLocalDriverLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListLocalDriverLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListLocalDriverLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListLocalDriverLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListLocalDriverLicenses.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListLocalDriverLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListLocalDriverLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDriverLicenses);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(908, 311);
            this.tbDriverLicenses.ResumeLayout(false);
            this.tbLocal.ResumeLayout(false);
            this.tbInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalDriverLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLocalDriverLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbDriverLicenses;
        private System.Windows.Forms.TabPage tbLocal;
        private System.Windows.Forms.TabPage tbInternational;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListInternationalDriverLicenses;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListLocalDriverLicenses;
    }
}
