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
    public partial class frmReplacementForDamagedOrLostLicense : Form
    {
        public frmReplacementForDamagedOrLostLicense()
        {
            InitializeComponent();
        }
        clsLicense ReplacedLicense = new clsLicense();


        private void FillReplacementForDamagedOrLostLicenseInfo()
        {
            dtpApplicationDate.Value = DateTime.Now;
            clsApplicationType.enApplicationType ApplicationType = (rbLostLicense.Checked) ? clsApplicationType.enApplicationType.enReplacementForLostLicsense : clsApplicationType.enApplicationType.enReplacementForDamagedLicsense; 
            txtApplicationFees.Text = clsApplicationType.Find(ApplicationType).Fees.ToString();
            txtCreatedBy.Text = clsDVLDBusinessSettings.CurrentUser.UserName;
        }
        private void FillReplacementForDamagedOrLostLicenseInfo(clsLicense ReplacedLicense)
        {
            txtReplacedLicenseApplicationID.Text = (ReplacedLicense.ApplicationID != -1) ? ReplacedLicense.ApplicationID.ToString() : "******";
            txtReplacedLicenseID.Text = (ReplacedLicense.LicenseID != -1) ? ReplacedLicense.LicenseID.ToString() : "******";
        }
        private void ctrlFiltredLicense_OnLicenseSelector(int ID)
        {
            clsLicense OldLicense = new clsLicense();
            if ((OldLicense = clsLicense.Find(ID)) != null)
            {
                txtOldLicenseID.Text = ID.ToString();
                this.ReplacedLicense = new clsLicense();
                this.ReplacedLicense.DriverID = OldLicense.DriverID;
                this.ReplacedLicense.LicenseClass = OldLicense.LicenseClass;
                this.ReplacedLicense.IssueDate = DateTime.Now;
                clsLicenseClasse LicenseClass = clsLicenseClasse.Find(ReplacedLicense.LicenseClass);
                this.ReplacedLicense.ExpirationDate = OldLicense.ExpirationDate;
                this.ReplacedLicense.PaidFees =0;
                this.ReplacedLicense.IssueReason = (rbLostLicense.Checked) ? clsLicense.enIssueReason.ReplacementForLost: clsLicense.enIssueReason.ReplacementForDamaged;
                this.ReplacedLicense.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
                FillReplacementForDamagedOrLostLicenseInfo(ReplacedLicense);
                clsLicense.enReplacementLicenseResult Result = OldLicense.ReplacementLicenseResult();
                switch (Result)
                {
                    case clsLicense.enReplacementLicenseResult.Allowed:
                        {
                            btnSave.Enabled = true;
                            break;
                        }
                    case clsLicense.enReplacementLicenseResult.enIsExpired:
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show($"This License Is Expired In {OldLicense.ExpirationDate} You Should First Renew This Lecense", "Expired Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case clsLicense.enReplacementLicenseResult.enIsDaitianedLicense:
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
            if (ReplacedLicense.Save())
            {
                FillReplacementForDamagedOrLostLicenseInfo(ReplacedLicense);
                lkShowLicenseInfo.Enabled = true;
                btnSave.Enabled = false;
                MessageBox.Show("Sucess", $"Saved Sucessfully With ID {ReplacedLicense.LicenseID}", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            clsLicense License = clsLicense.Find(ReplacedLicense.LicenseID);
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

        private void lkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(ReplacedLicense.ApplicationID);
            frm.ShowDialog();
        }

        private void frmReplacementForDamagedOrLostLicense_Load(object sender, EventArgs e)
        {
            FillReplacementForDamagedOrLostLicenseInfo();
        }

        private void rbReplacementFor_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLostLicense.Checked)
            {
                this.ReplacedLicense.IssueReason = clsLicense.enIssueReason.ReplacementForLost;
                txtApplicationFees.Text = clsApplicationType.Find(clsApplicationType.enApplicationType.enReplacementForLostLicsense).Fees.ToString();
                return;
            }
            if(rbDamagedLicense.Checked)
            {
                this.ReplacedLicense.IssueReason = clsLicense.enIssueReason.ReplacementForDamaged;
                txtApplicationFees.Text = clsApplicationType.Find(clsApplicationType.enApplicationType.enReplacementForDamagedLicsense).Fees.ToString();
                return;
            }

        }

        private void lkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense License = clsLicense.Find(ReplacedLicense.LicenseID);
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
