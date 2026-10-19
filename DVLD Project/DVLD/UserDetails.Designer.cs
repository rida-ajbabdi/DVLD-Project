namespace DVLD
{
    partial class UserDetails
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
            this.ctrlUserInfo = new DVLD.ctrlUserInfo();
            this.SuspendLayout();
            // 
            // ctrlUserInfo
            // 
            this.ctrlUserInfo.Location = new System.Drawing.Point(55, 12);
            this.ctrlUserInfo.Name = "ctrlUserInfo";
            this.ctrlUserInfo.Size = new System.Drawing.Size(957, 477);
            this.ctrlUserInfo.TabIndex = 0;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 537);
            this.Controls.Add(this.ctrlUserInfo);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.Load += new System.EventHandler(this.UserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserInfo ctrlUserInfo;
    }
}