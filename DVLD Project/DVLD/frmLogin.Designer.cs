namespace DVLD
{
    partial class frmLogin
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
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblRemenber = new System.Windows.Forms.Label();
            this.chkRemenber = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lnkForgotPassoword = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTimer.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.label2);
            this.pnlTimer.Controls.Add(this.label1);
            this.pnlTimer.Location = new System.Drawing.Point(407, 84);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(258, 37);
            this.pnlTimer.TabIndex = 13;
            this.pnlTimer.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(123, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "30 s ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wait for ";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblRemenber);
            this.pnlLogin.Controls.Add(this.chkRemenber);
            this.pnlLogin.Controls.Add(this.lnkForgotPassoword);
            this.pnlLogin.Controls.Add(this.linkLabel1);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUserName);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(360, 127);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(346, 240);
            this.pnlLogin.TabIndex = 12;
            // 
            // lblRemenber
            // 
            this.lblRemenber.AutoSize = true;
            this.lblRemenber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemenber.ForeColor = System.Drawing.Color.Gray;
            this.lblRemenber.Location = new System.Drawing.Point(76, 116);
            this.lblRemenber.Name = "lblRemenber";
            this.lblRemenber.Size = new System.Drawing.Size(70, 17);
            this.lblRemenber.TabIndex = 7;
            this.lblRemenber.Text = "Remenber";
            // 
            // chkRemenber
            // 
            this.chkRemenber.Animated = true;
            this.chkRemenber.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkRemenber.CheckedState.BorderRadius = 2;
            this.chkRemenber.CheckedState.BorderThickness = 0;
            this.chkRemenber.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkRemenber.Location = new System.Drawing.Point(52, 116);
            this.chkRemenber.Name = "chkRemenber";
            this.chkRemenber.Size = new System.Drawing.Size(18, 17);
            this.chkRemenber.TabIndex = 6;
            this.chkRemenber.Text = "Remember";
            this.chkRemenber.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRemenber.UncheckedState.BorderRadius = 2;
            this.chkRemenber.UncheckedState.BorderThickness = 0;
            this.chkRemenber.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lnkForgotPassoword
            // 
            this.lnkForgotPassoword.AutoSize = true;
            this.lnkForgotPassoword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkForgotPassoword.LinkColor = System.Drawing.Color.Gray;
            this.lnkForgotPassoword.Location = new System.Drawing.Point(114, 203);
            this.lnkForgotPassoword.Name = "lnkForgotPassoword";
            this.lnkForgotPassoword.Size = new System.Drawing.Size(101, 13);
            this.lnkForgotPassoword.TabIndex = 5;
            this.lnkForgotPassoword.TabStop = true;
            this.lnkForgotPassoword.Text = "Forgot Passoword ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(124, 216);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(52, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter Passoword";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(253, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "";
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
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
            this.txtUserName.Location = new System.Drawing.Point(52, 18);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "Enter User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(253, 28);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Tag = "";
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderRadius = 13;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(52, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(242, 38);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "30";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblRemenber;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkRemenber;
        private System.Windows.Forms.LinkLabel lnkForgotPassoword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}