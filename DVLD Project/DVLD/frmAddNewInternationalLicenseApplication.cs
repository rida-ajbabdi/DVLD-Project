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
    public partial class frmAddNewInternationalLicenseApplication : Form
    {
        clsInternationalLicense InternationalLicense = new clsInternationalLicense();
        public frmAddNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmAddNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            FillInternaionalLicenseApplicationInfo();
        }
        private void FillInternaionalLicenseApplicationInfo()
        {
            dtpApplicationDate.Value = DateTime.Now;
            dtpIssueDate.Value = DateTime.Now;
            dtpExpirationDate.Value = dtpIssueDate.Value.AddYears(clsDVLDBusinessSettings.DefaultValidityLengthForInternationalLicense);
            txtFees.Text = clsApplicationType.Find(clsApplicationType.enApplicationType.enNewInternationalLicense).Fees.ToString();
            txtCreatedBy.Text = clsDVLDBusinessSettings.CurrentUser.UserName;
        }
        private void ctrlFiltredLicense_OnLicenseSelector(int ID)
        {
            clsLicense License = new clsLicense();
            if ((License = clsLicense.Find(ID)) != null)
            {
                this.InternationalLicense.IssuedUsingLocalLicenseID = License.LicenseID;
                this.InternationalLicense.DriverID = License.DriverID;
                txtLocalLicenseID.Text = ID.ToString();
                int ActiveInternationalLicenseID = -1;
                clsLicense.enAddInternationalLicenseResult Result = License.AddInternationalLicenseResult(ref ActiveInternationalLicenseID);
                switch (Result)
                {
                    case clsLicense.enAddInternationalLicenseResult.Allowed:
                        {
                            btnSave.Enabled = true;
                            break;
                        }
                    case clsLicense.enAddInternationalLicenseResult.enNot3Class:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"This License Class = {License.LicenseClass} Is Not In 3 Class , Please Selecte Anther License !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case clsLicense.enAddInternationalLicenseResult.enHasActiveInternationalLicense:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"This Person Has Already A Active Interantional License With ID ={ActiveInternationalLicenseID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case clsLicense.enAddInternationalLicenseResult.enDateExpirationErreur:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"Date Of License {License.ExpirationDate} Is Expired", "Expired Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case clsLicense.enAddInternationalLicenseResult.enIsDaitianedLicense:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show("This License Is Locked , Please  Release Detain License Or Select Active License  Try Again ", "License Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsInternationalLicense InternationalLicense = new clsInternationalLicense(this.InternationalLicense.IssuedUsingLocalLicenseID);
            if(InternationalLicense.Save())
            {
                this.InternationalLicense = InternationalLicense;
                lkShowLicenseInfo.Enabled = true;
                btnSave.Enabled = false;
                txtInternationalLicenseApplicationID.Text = InternationalLicense.ApplicationID.ToString();
                txtInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
                MessageBox.Show("Sucess", $"Saved Sucessfully With ID {InternationalLicense.InternationalLicenseID}", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            clsLicense License = clsLicense.Find(InternationalLicense.IssuedUsingLocalLicenseID);
            if(License != null)
            {
                clsDriver Driver = clsDriver.Find(License.DriverID);
                if(Driver!= null)
                {
                    frmLicenseHistory frm = new frmLicenseHistory(Driver.PersonID);
                    frm.ShowDialog();
                }
            } 
        }

        private void lkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(InternationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }

        private void lkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
