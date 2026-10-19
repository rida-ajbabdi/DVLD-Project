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
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            clsInternationalLicense InternationalLicense = new clsInternationalLicense();
            if ((InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID)) == null)
            {
                MessageBox.Show($"License With Application ID {InternationalLicenseID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadInternationalLicenseInfo(InternationalLicense);
        }
        public void LoadInternationalLicenseInfo(clsInternationalLicense InternationalLicense)
        {
            clsApplication Application = new clsApplication();
            if ((Application = clsApplication.Find(InternationalLicense.ApplicationID)) == null)
            {
                MessageBox.Show($"Application With ID {InternationalLicense.ApplicationID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsPerson Person = new clsPerson();
            if ((Person = clsPerson.Find(Application.ApplicationPersonID)) == null)
            {
                MessageBox.Show($"_Person With ID {Application.ApplicationPersonID} Is Not Found !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFullName.Text = Person.FullName();
            txtLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            txtInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            txtApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            txtNationalNo.Text = Person.NationalNo;
            txtGender.Text = Person.Gender.ToString();
            dtpIssueDate.Value = InternationalLicense.IssueDate;
            txtIsActive.Text = (InternationalLicense.IsActive) ? "Yes" : "No";
            dtpDateOfBirth.Value = Person.DateOfBirth;
            txtDriverID.Text = InternationalLicense.DriverID.ToString();
            dtpExpirationDate.Value = InternationalLicense.ExpirationDate;
            if (Person.ImagePath != "")
                pctrImage.ImageLocation = Person.ImagePath;
        }

        private void ctrlInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

