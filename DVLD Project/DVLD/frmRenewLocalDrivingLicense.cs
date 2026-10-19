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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        clsLicense NewLicense = new clsLicense();
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();

        }

        private void FillRenewLocalDrivingLicenseApplicationInfo()
        {
            dtpApplicationDate.Value = DateTime.Now;
            dtpIssueDate.Value = DateTime.Now;
            txtApplicationFees.Text = clsApplicationType.Find(clsApplicationType.enApplicationType.enRenewLicsense).Fees.ToString();
            txtCreatedBy.Text = clsDVLDBusinessSettings.CurrentUser.UserName;
        }
        private void FillRenewLocalDrivingLicenseApplicationInfo(clsLicense NewLicense)
        {
            txtNewLocalDrivingLicenseApplicationID.Text = (NewLicense.ApplicationID != -1) ? NewLicense.ApplicationID.ToString() : "******";
            dtpIssueDate.Value = NewLicense.IssueDate;
            dtpExpirationDate.Value = NewLicense.ExpirationDate;
            txtLicenseFees.Text = NewLicense.PaidFees.ToString();
            txtRenewedLicenseID.Text = (NewLicense.LicenseID != -1) ? NewLicense.LicenseID.ToString() : "******";
            dtpExpirationDate.Value = NewLicense.ExpirationDate;
            txtTotalFees.Text = (NewLicense.PaidFees + decimal.Parse(txtApplicationFees.Text)).ToString();
            txtNotes.Text = NewLicense.Notes;
        }
        private void ctrlFiltredLicense_OnLicenseSelector(int ID)
        {
            clsLicense License = new clsLicense();
            if ((License = clsLicense.Find(ID)) != null)
            {
                txtOldLicenseID.Text = ID.ToString();
                this.NewLicense.DriverID = License.DriverID;
                this.NewLicense.LicenseClass = License.LicenseClass;
                this.NewLicense.IssueDate = DateTime.Now;
                clsLicenseClasse LicenseClass = clsLicenseClasse.Find(NewLicense.LicenseClass);
                this.NewLicense.ExpirationDate = dtpIssueDate.Value.AddYears(LicenseClass.DefaultValidityLength);
                this.NewLicense.PaidFees = LicenseClass.ClassFees;
                this.NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
                this.NewLicense.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
                FillRenewLocalDrivingLicenseApplicationInfo(NewLicense);
                clsLicense.enRenewLocalDrivingLicenseResult Result = License.RenewLocalDrivingLicenseResult();
                switch (Result)
                {
                    case clsLicense.enRenewLocalDrivingLicenseResult.Allowed:
                        {
                            btnSave.Enabled = true;
                            break;
                        }
                    case clsLicense.enRenewLocalDrivingLicenseResult.enIsNotExpired:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"This License Will Be Expired In {License.ExpirationDate} ", "Expired Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case clsLicense.enRenewLocalDrivingLicenseResult.enIsDaitianedLicense:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show("This License Is Locked , Please Renew This License First And Try Again ", "License Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (NewLicense.Save())
            {
                FillRenewLocalDrivingLicenseApplicationInfo(NewLicense);
                lkShowLicenseInfo.Enabled = true;
                btnSave.Enabled = false;
                MessageBox.Show("Sucess", $"Saved Sucessfully With ID {NewLicense.LicenseID}", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            frmLicenseInfo frm = new frmLicenseInfo(NewLicense.ApplicationID);
            frm.ShowDialog();
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            FillRenewLocalDrivingLicenseApplicationInfo();
        }

        private void lkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense License = clsLicense.Find(NewLicense.LicenseID);
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
    }

}

