namespace DVLD
{
    partial class frmTakeTest
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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtTestID = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbTestinfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbResult = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFail = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbPass = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbTestinfo.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTestInfo
            // 
            this.ctrlTestInfo.Location = new System.Drawing.Point(16, 30);
            this.ctrlTestInfo.Name = "ctrlTestInfo";
            this.ctrlTestInfo.Size = new System.Drawing.Size(397, 406);
            this.ctrlTestInfo.TabIndex = 0;
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
            this.btnSave.Location = new System.Drawing.Point(292, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTestID
            // 
            this.txtTestID.BorderRadius = 10;
            this.txtTestID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTestID.DefaultText = "";
            this.txtTestID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTestID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTestID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTestID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTestID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTestID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTestID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTestID.Location = new System.Drawing.Point(46, 384);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.PlaceholderText = "Enter Test ID";
            this.txtTestID.ReadOnly = true;
            this.txtTestID.SelectedText = "";
            this.txtTestID.Size = new System.Drawing.Size(298, 33);
            this.txtTestID.TabIndex = 71;
            // 
            // gbTestinfo
            // 
            this.gbTestinfo.BackColor = System.Drawing.Color.Transparent;
            this.gbTestinfo.BorderColor = System.Drawing.Color.Transparent;
            this.gbTestinfo.Controls.Add(this.label4);
            this.gbTestinfo.Controls.Add(this.label3);
            this.gbTestinfo.Controls.Add(this.gbResult);
            this.gbTestinfo.Controls.Add(this.txtNote);
            this.gbTestinfo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbTestinfo.FillColor = System.Drawing.Color.Transparent;
            this.gbTestinfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbTestinfo.ForeColor = System.Drawing.Color.Transparent;
            this.gbTestinfo.Location = new System.Drawing.Point(16, 442);
            this.gbTestinfo.Name = "gbTestinfo";
            this.gbTestinfo.Size = new System.Drawing.Size(362, 150);
            this.gbTestinfo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result";
            // 
            // gbResult
            // 
            this.gbResult.BackColor = System.Drawing.Color.Transparent;
            this.gbResult.BorderColor = System.Drawing.Color.Transparent;
            this.gbResult.Controls.Add(this.label2);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Controls.Add(this.rbFail);
            this.gbResult.Controls.Add(this.rbPass);
            this.gbResult.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbResult.FillColor = System.Drawing.Color.Transparent;
            this.gbResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbResult.ForeColor = System.Drawing.Color.Transparent;
            this.gbResult.Location = new System.Drawing.Point(42, 0);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(177, 43);
            this.gbResult.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pass";
            // 
            // rbFail
            // 
            this.rbFail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFail.CheckedState.BorderThickness = 0;
            this.rbFail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFail.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFail.Location = new System.Drawing.Point(91, 11);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(20, 20);
            this.rbFail.TabIndex = 7;
            this.rbFail.Text = "guna2CustomRadioButton2";
            this.rbFail.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFail.UncheckedState.BorderThickness = 2;
            this.rbFail.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFail.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbPass
            // 
            this.rbPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPass.CheckedState.BorderThickness = 0;
            this.rbPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPass.Location = new System.Drawing.Point(31, 11);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(20, 20);
            this.rbPass.TabIndex = 6;
            this.rbPass.Text = "guna2CustomRadioButton1";
            this.rbPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPass.UncheckedState.BorderThickness = 2;
            this.rbPass.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPass.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtNote
            // 
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(58, 56);
            this.txtNote.Name = "txtNote";
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(301, 91);
            this.txtNote.TabIndex = 9;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 630);
            this.Controls.Add(this.gbTestinfo);
            this.Controls.Add(this.txtTestID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlTestInfo);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.gbTestinfo.ResumeLayout(false);
            this.gbTestinfo.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTestInfo ctrlTestInfo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtTestID;
        private Guna.UI2.WinForms.Guna2GroupBox gbTestinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox gbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbFail;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
    }
}