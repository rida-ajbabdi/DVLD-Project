using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
namespace DVLD
{
    public partial class frmReleaseDetainedLicense : Form
    {
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        clsDetainedLicense DetainedLicense = new clsDetainedLicense();
        private void FillReleaseDetainedLicenseApplicationInfo()
        {
            txtApplicationFees.Text = clsApplicationType.Find(clsApplicationType.enApplicationType.enReleaseDetainedLicsense).Fees.ToString();
        }
        private void FillReleaseDetainedLicenseApplicationInfo(clsDetainedLicense DetainedLicense)
        {
            txtDetainID.Text = (DetainedLicense.DetainID != -1) ? DetainedLicense.DetainID.ToString() : "******";
            dtpDetainDate.Value = (DetainedLicense.DetainDate != DateTime.MinValue) ? DetainedLicense.DetainDate : DateTime.Now;
            txtLicenseID.Text = DetainedLicense.LicenseID.ToString();
            txtCreatedBy.Text = clsUser.Find( DetainedLicense.CreatedByUserID).UserName;
            txtFineFees.Text = DetainedLicense.FineFees.ToString();
            txtTotalFees.Text = (DetainedLicense.FineFees + decimal.Parse(txtApplicationFees.Text)).ToString();
            txtApplicationID.Text = (DetainedLicense.ReleaseApplicationID != -1) ? DetainedLicense.ReleaseApplicationID.ToString() : "******";
        }
        private void ctrlFiltredLicense_OnLicenseSelector(int ID)
        {
            if ((DetainedLicense = clsDetainedLicense.FindLastDetainedLicense(ID)) != null)
            {
                DetainedLicense.ReleaseDate = DateTime.Now;
                DetainedLicense.ReleasedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
                FillReleaseDetainedLicenseApplicationInfo(DetainedLicense);
                clsDetainedLicense.enReleaseDetainedLicenseResult Result = DetainedLicense.ReleaseDetainedLicenseResult();
                switch (Result)
                {
                    case clsDetainedLicense.enReleaseDetainedLicenseResult.Allowed:
                        {
                            btnSave.Enabled = true;
                            break;
                        }
                    case clsDetainedLicense.enReleaseDetainedLicenseResult.enIsNotDaitianedLicense:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"This License Is Not Detained ! , Please Choose Another One . ", "Not Detained License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DetainedLicense.Release())
            {
                FillReleaseDetainedLicenseApplicationInfo(DetainedLicense);
                lkShowLicenseInfo.Enabled = true;
                btnSave.Enabled = false;
                MessageBox.Show( $"Saved Sucessfully With Application ID {DetainedLicense.ReleaseApplicationID}", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "Saved Fail , Please Try Again ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkShowLicenseHistory_Click(object sender, EventArgs e)
        {

        }

        private void lkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense License = clsLicense.Find(DetainedLicense.LicenseID);
            if (License != null) 
            {
                frmLicenseInfo frm = new frmLicenseInfo(License.ApplicationID);
                frm.ShowDialog();
            }
        }

        
        private void lkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense License = clsLicense.Find(DetainedLicense.LicenseID);
            if (License != null)
            {
                clsDriver Driver = clsDriver.Find(License.DriverID);
                if (Driver != null)
                {
                    frmLicenseHistory frm = new frmLicenseHistory(Driver.PersonID);
                    frm.ShowDialog();
                }
            }
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            FillReleaseDetainedLicenseApplicationInfo();
        }
    }
}
