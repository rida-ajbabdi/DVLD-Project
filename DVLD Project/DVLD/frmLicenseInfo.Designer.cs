namespace DVLD
{
    partial class frmLicenseInfo
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
            this.ctrlDriverLicenseInfo = new DVLD.ctrlDriverLicenseInfo();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfo
            // 
            this.ctrlDriverLicenseInfo.Location = new System.Drawing.Point(10, 2);
            this.ctrlDriverLicenseInfo.Name = "ctrlDriverLicenseInfo";
            this.ctrlDriverLicenseInfo.Size = new System.Drawing.Size(871, 414);
            this.ctrlDriverLicenseInfo.TabIndex = 0;
            // 
            // frmLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 425);
            this.Controls.Add(this.ctrlDriverLicenseInfo);
            this.Name = "frmLicenseInfo";
            this.Text = "frmLicenseInfo";
            this.Load += new System.EventHandler(this.frmLicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo;
    }
}