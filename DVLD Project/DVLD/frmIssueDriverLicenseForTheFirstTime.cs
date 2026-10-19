using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using  DVLDBusinessLayer;
using static DVLDBusinessLayer.clsLicense;

namespace DVLD
{
    public partial class frmIssueDriverLicenseForTheFirstTime : Form
    {
        private int LocalDrivingLicenseApplicationID;
        private clsLicense License = new clsLicense();
        public frmIssueDriverLicenseForTheFirstTime(int LocalDrivingLisenceApplicationID)
        {
            InitializeComponent();
            this.LocalDrivingLicenseApplicationID = LocalDrivingLisenceApplicationID;
            License.ApplicationID = -1;
            License.DriverID = -1;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            if ((LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID)) != null)
            {
                License.LicenseID = -1;
                License.ApplicationID = LocalDrivingLicenseApplication.ApplicationID;
                License.LicenseClass = LocalDrivingLicenseApplication.LicenseClassID;
                License.IssueDate = DateTime.Now;
                clsLicenseClasse LicenseClass = clsLicenseClasse.Find(License.LicenseClass);
                License.ExpirationDate = License.IssueDate.AddYears(LicenseClass.DefaultValidityLength);
                License.Notes = "";
                License.PaidFees = LicenseClass.ClassFees;
                License.IsActive = true;
                License.IssueReason = enIssueReason.FirstTime;
                License.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            License.Notes = txtNotes.Text;
            if (License.Save())
            {
                MessageBox.Show($"License Saved Sucessfully With ID = {License.LicenseID}", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save Fail !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIssueDriverLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLlisenceApplicationInfo.LoadLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            txtLicenseClassFees.Text = clsLicenseClasse.Find( License.LicenseClass).ClassFees.ToString();
            txtNotes.Text = License.Notes.ToString();
        }
    }
}
