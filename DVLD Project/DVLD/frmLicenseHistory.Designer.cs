namespace DVLD
{
    partial class frmLicenseHistory
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
            this.ctrlPersonInfo = new DVLDBusinessLayer.ctrlPersonInfo();
            this.ctrlDriverLicenses = new DVLD.ctrlDriverLicenses();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo
            // 
            this.ctrlPersonInfo.Location = new System.Drawing.Point(12, 3);
            this.ctrlPersonInfo.Name = "ctrlPersonInfo";
            this.ctrlPersonInfo.Size = new System.Drawing.Size(891, 400);
            this.ctrlPersonInfo.TabIndex = 0;
   
            // 
            // ctrlDriverLicenses
            // 
            this.ctrlDriverLicenses.Location = new System.Drawing.Point(12, 395);
            this.ctrlDriverLicenses.Name = "ctrlDriverLicenses";
            this.ctrlDriverLicenses.Size = new System.Drawing.Size(867, 281);
            this.ctrlDriverLicenses.TabIndex = 1;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 688);
            this.Controls.Add(this.ctrlDriverLicenses);
            this.Controls.Add(this.ctrlPersonInfo);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDBusinessLayer.ctrlPersonInfo ctrlPersonInfo;
        private ctrlDriverLicenses ctrlDriverLicenses;
    }
}