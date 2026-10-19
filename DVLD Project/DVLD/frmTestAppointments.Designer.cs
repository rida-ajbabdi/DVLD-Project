namespace DVLD
{
    partial class frmTestAppointments
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctrlLocalDrivingLlisenceApplicationInfo = new DVLD.ctrlLocalDrivingLlisenceApplicationInfo();
            this.dgvListTestAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageTestAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestAppointments)).BeginInit();
            this.cmsManageTestAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLlisenceApplicationInfo
            // 
            this.ctrlLocalDrivingLlisenceApplicationInfo.Location = new System.Drawing.Point(8, 32);
            this.ctrlLocalDrivingLlisenceApplicationInfo.Name = "ctrlLocalDrivingLlisenceApplicationInfo";
            this.ctrlLocalDrivingLlisenceApplicationInfo.Size = new System.Drawing.Size(833, 493);
            this.ctrlLocalDrivingLlisenceApplicationInfo.TabIndex = 0;
            // 
            // dgvListTestAppointments
            // 
            this.dgvListTestAppointments.AllowUserToAddRows = false;
            this.dgvListTestAppointments.AllowUserToDeleteRows = false;
            this.dgvListTestAppointments.AllowUserToOrderColumns = true;
            this.dgvListTestAppointments.AllowUserToResizeColumns = false;
            this.dgvListTestAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListTestAppointments.ContextMenuStrip = this.cmsManageTestAppointment;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTestAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListTestAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListTestAppointments.Location = new System.Drawing.Point(22, 559);
            this.dgvListTestAppointments.Name = "dgvListTestAppointments";
            this.dgvListTestAppointments.ReadOnly = true;
            this.dgvListTestAppointments.RowHeadersVisible = false;
            this.dgvListTestAppointments.Size = new System.Drawing.Size(809, 159);
            this.dgvListTestAppointments.TabIndex = 1;
            this.dgvListTestAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListTestAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListTestAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListTestAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListTestAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListTestAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListTestAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListTestAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListTestAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListTestAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListTestAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListTestAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListTestAppointments.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvListTestAppointments.ThemeStyle.ReadOnly = true;
            this.dgvListTestAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListTestAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListTestAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListTestAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListTestAppointments.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListTestAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListTestAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmsManageTestAppointment
            // 
            this.cmsManageTestAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiEdit,
            this.cmsiTakeTest});
            this.cmsManageTestAppointment.Name = "cmsManageTestAppointment";
            this.cmsManageTestAppointment.Size = new System.Drawing.Size(181, 70);
            // 
            // cmsiEdit
            // 
            this.cmsiEdit.Name = "cmsiEdit";
            this.cmsiEdit.Size = new System.Drawing.Size(180, 22);
            this.cmsiEdit.Text = "Edit";
            this.cmsiEdit.Click += new System.EventHandler(this.cmsiEdit_Click);
            // 
            // cmsiTakeTest
            // 
            this.cmsiTakeTest.Name = "cmsiTakeTest";
            this.cmsiTakeTest.Size = new System.Drawing.Size(180, 22);
            this.cmsiTakeTest.Text = "Take Test";
            this.cmsiTakeTest.Click += new System.EventHandler(this.cmsiTakeTest_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(781, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.Size = new System.Drawing.Size(38, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 742);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvListTestAppointments);
            this.Controls.Add(this.ctrlLocalDrivingLlisenceApplicationInfo);
            this.Name = "frmTestAppointments";
            this.Text = "frmTestAppointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestAppointments)).EndInit();
            this.cmsManageTestAppointment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLocalDrivingLlisenceApplicationInfo ctrlLocalDrivingLlisenceApplicationInfo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListTestAppointments;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private System.Windows.Forms.ContextMenuStrip cmsManageTestAppointment;
        private System.Windows.Forms.ToolStripMenuItem cmsiEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsiTakeTest;
    }
}