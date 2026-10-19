namespace DVLD
{
    partial class frmLocalDrivingLisenceApplicationInfo
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
            this.ctrlLocalDrivingLlisenceApplicationInfo = new DVLD.ctrlLocalDrivingLlisenceApplicationInfo();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLlisenceApplicationInfo
            // 
            this.ctrlLocalDrivingLlisenceApplicationInfo.Location = new System.Drawing.Point(12, 34);
            this.ctrlLocalDrivingLlisenceApplicationInfo.Name = "ctrlLocalDrivingLlisenceApplicationInfo";
            this.ctrlLocalDrivingLlisenceApplicationInfo.Size = new System.Drawing.Size(836, 496);
            this.ctrlLocalDrivingLlisenceApplicationInfo.TabIndex = 0;
            // 
            // frmLocalDrivingLisenceApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 536);
            this.Controls.Add(this.ctrlLocalDrivingLlisenceApplicationInfo);
            this.Name = "frmLocalDrivingLisenceApplicationInfo";
            this.Text = "Local Driving Lisence Application Info";
            this.Load += new System.EventHandler(this.frmLocalDrivingLisenceApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLocalDrivingLlisenceApplicationInfo ctrlLocalDrivingLlisenceApplicationInfo;
    }
}