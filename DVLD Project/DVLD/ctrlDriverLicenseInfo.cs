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
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadDriverLicenseInfoByApplicationID(int AppicationID)
        {
            clsLicense License = new clsLicense();
            if ((License = clsLicense.FindByApplicationID(AppicationID)) == null)
            {
                MessageBox.Show($"License With Application ID {AppicationID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDriverLicenseInfo(License);
        }
        public void LoadDriverLicenseInfo(clsLicense License)
        {
            clsApplication Application = new clsApplication();
            if ((Application = clsApplication.Find(License.ApplicationID)) == null)
            {
                MessageBox.Show($"Application With ID {Application.ApplicationPersonID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsPerson Person = new clsPerson();
            if ((Person = clsPerson.Find(Application.ApplicationPersonID)) == null)
            {
                MessageBox.Show($"_Person With ID {Application.ApplicationPersonID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtLicenseClass.Text = clsLicenseClasse.Find(License.LicenseClass).LisenceClassName;
            txtFullName.Text = Person.FullName();
            txtLicenseID.Text = License.LicenseID.ToString();
            txtNationalNo.Text = Person.NationalNo;
            txtGender.Text = Person.Gender.ToString();
            dtpIssueDate.Value = License.IssueDate;
            txtIssueReason.Text = License.IssueReason.ToString();
            txtNotes.Text = (License.Notes == "") ? "No Notes" : License.Notes;
            txtIsActive.Text = (License.IsActive) ? "Yes" : "No";
            dtpDateOfBirth.Value = Person.DateOfBirth;
            txtDriverID.Text = License.DriverID.ToString();
            dtpExpirationDate.Value = License.ExpirationDate;
            txtIsDetained.Text = (License.IsDetainedLicense()) ? "Yes" : "No";
            if (Person.ImagePath != "")
                pctrImage.ImageLocation = Person.ImagePath;
        }
        public void LoadDriverLicenseInfo(int LicenseID)
        {
            clsLicense License = new clsLicense();
            if ((License = clsLicense.Find(LicenseID)) == null)
            {
                MessageBox.Show($"License With Application ID {LicenseID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDriverLicenseInfo(License);
        }
        public void LoadDriverLicenseInfoByLocalDrivingLicenseID(int LocalDrivingLicenseID)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicense = new clsLocalDrivingLicenseApplication();
            if ((LocalDrivingLicense = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseID)) == null)
            {
                MessageBox.Show($"Local Driving License With ID {LocalDrivingLicenseID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDriverLicenseInfoByApplicationID(LocalDrivingLicense.ApplicationID);
        }

    }
}
    

