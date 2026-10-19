namespace DVLD
{
    partial class frmInternationalLicenseInfo
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
            this.ctrlInternationalLicenseInfo = new DVLD.ctrlInternationalLicenseInfo();
            this.SuspendLayout();
            // 
            // ctrlInternationalLicenseInfo
            // 
            this.ctrlInternationalLicenseInfo.Location = new System.Drawing.Point(33, 7);
            this.ctrlInternationalLicenseInfo.Name = "ctrlInternationalLicenseInfo";
            this.ctrlInternationalLicenseInfo.Size = new System.Drawing.Size(735, 431);
            this.ctrlInternationalLicenseInfo.TabIndex = 0;
            // 
            // frmInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlInternationalLicenseInfo);
            this.Name = "frmInternationalLicenseInfo";
            this.Text = "frmInternationalLicenseInfo";
            this.Load += new System.EventHandler(this.frmInternationalLicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlInternationalLicenseInfo ctrlInternationalLicenseInfo;
    }
}