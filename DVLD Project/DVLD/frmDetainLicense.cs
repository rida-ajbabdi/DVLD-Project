using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private clsDetainedLicense DetainedLicense = new clsDetainedLicense();


        private void FillDetainedLicenseInfo()
        {
            dtpDetainDate.Value = DateTime.Now;
            txtFineFees.Text = "";
            txtCreatedBy.Text = clsDVLDBusinessSettings.CurrentUser.UserName;
        }
        private void FillDetainedLicenseInfo(clsDetainedLicense DetainedLicense)
        {
            txtDetainID.Text = (DetainedLicense.DetainID != -1) ? DetainedLicense.DetainID.ToString() : "******";
            txtLicenseID.Text = (DetainedLicense.LicenseID != -1) ? DetainedLicense.LicenseID.ToString() : "******";
            dtpDetainDate.Value = DetainedLicense.DetainDate;
            txtFineFees.Text = DetainedLicense.FineFees.ToString();
            txtCreatedBy.Text = clsDVLDBusinessSettings.CurrentUser.UserName;
        }
        private void ctrlFiltredLicense_OnLicenseSelector(int ID)
        {
            clsLicense License = new clsLicense();
            if ((License = clsLicense.Find(ID)) != null)
            {
                txtLicenseID.Text = ID.ToString();
                this.DetainedLicense = new clsDetainedLicense();
                //
                this.DetainedLicense.LicenseID = License.LicenseID;
                this.DetainedLicense.DetainDate = DateTime.Now;
                this.DetainedLicense.FineFees = 0;
                this.DetainedLicense.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
                this.DetainedLicense.IsReleased = false;
                this.DetainedLicense.ReleaseDate = DateTime.MinValue;
                this.DetainedLicense.ReleasedByUserID = -1;
                this.DetainedLicense.ReleaseApplicationID = -1;
                //
                FillDetainedLicenseInfo(this.DetainedLicense);
                clsLicense.enDetainLicenseResult Result = License.DetainLicenseResult();
                switch (Result)
                {
                    case clsLicense.enDetainLicenseResult.Allowed:
                        {
                            btnSave.Enabled = true;
                            break;
                        }
                    case clsLicense.enDetainLicenseResult.enNotActiveLicense:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"This License With ID {DetainedLicense.LicenseID} Is Not Active , You Should Select A Active License !", "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case clsLicense.enDetainLicenseResult.enIsDaitianedLicense:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"This License Is Locked Because It Already Detain ! , You Should Release Detain First And Try Again !", "License Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal FineFees = 0;
            if(decimal.TryParse(txtFineFees.Text , out FineFees))
            {
                DetainedLicense.FineFees = FineFees;
            }
            if (DetainedLicense.Save())
            {
                FillDetainedLicenseInfo(DetainedLicense);
                lkShowLicenseInfo.Enabled = true;
                btnSave.Enabled = false;
                MessageBox.Show( $"Saved Sucessfully With ID {DetainedLicense.DetainID}", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gbDatainLicenseApplication_Click(object sender, EventArgs e)
        {

        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            FillDetainedLicenseInfo();
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DriverInput = e.KeyChar;
            if (!int.TryParse(DriverInput.ToString(), out _) && DriverInput != 46 && DriverInput != 8)
            {
                e.Handled = true;
            }
        }


    }
}
