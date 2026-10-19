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
    public partial class ctrlLocalDrivingLlisenceApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
        public ctrlLocalDrivingLlisenceApplicationInfo()
        {
            InitializeComponent();
        }
        private void FillLocalDrivingLicenseApplicationInfo(clsLocalDrivingLicenseApplication Application)
        {
            txtID.Text = Application.LocalDrivingLicenseApplicationID.ToString();
            txtLisenceClass.Text = clsLicenseClasse.Find(Application.LicenseClassID).LisenceClassName;
            int PassedTest = Application.PassedTest();
            pbPassedTestCount.Value = PassedTest;
            lblPassedTest.Text = PassedTest.ToString() + " / 3";
        }
        public void LoadLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            if(LocalDrivingLicenseApplicationID != -1)
            {
                clsLocalDrivingLicenseApplication Applicaiton = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
                if(Applicaiton != null)
                {
                    FillLocalDrivingLicenseApplicationInfo(Applicaiton);
                    ctrlApplicationInfo.LoadApplicationInfo(Applicaiton.ApplicationID);

                }
                else
                {
                    MessageBox.Show($"Local Driving Lisence With ID = {LocalDrivingLicenseApplicationID} Not Found" , "Wrong" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
            }
        }
    }
}
