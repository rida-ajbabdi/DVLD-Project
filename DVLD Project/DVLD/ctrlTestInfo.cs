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
    public partial class ctrlTestInfo : UserControl
    {
        public ctrlTestInfo()
        {
            InitializeComponent();
        }
        private void _LoadLocalDrivingLicenseInfo(int LocalDrivingLicenseApplicationID , clsTestType.enTestType TestType)
        {
            if(LocalDrivingLicenseApplicationID != -1)
            {
                clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                if((LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID))!=null)
                {
                    clsApplication Application = clsApplication.Find(LocalDrivingLicenseApplication.ApplicationID);
                    txtLocalDrivingLisenceApplicationID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                    txtFullName.Text = clsPerson.Find(Application.ApplicationPersonID).FullName();
                    txtLicenseClass.Text = clsLicenseClasse.Find(LocalDrivingLicenseApplication.LicenseClassID).LisenceClassName;
                    dtpDate.MinDate = clsTestAppointement.TestAppointmentDateMinValue(LocalDrivingLicenseApplicationID , TestType);
                    dtpDate.Value = dtpDate.MinDate;
                }
                else
                {
                    MessageBox.Show($"The Local Driving License With ID = {LocalDrivingLicenseApplicationID} Is Not Found !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Please Selecte A Driving License From The List !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _LoadTestTypeInfo(clsTestType.enTestType TestTypeID)
        {
            if (TestTypeID != clsTestType.enTestType.enNone)
            {
                clsTestType TestType = new clsTestType();
                if ((TestType = clsTestType.Find( TestTypeID)) != null)
                {
                    lblTestTytle.Text = TestType.Title;
                    txtFees.Text = TestType.Fees.ToString();
                }
                else
                {
                    MessageBox.Show($"The Test Type With ID = {TestTypeID} Is Not Found !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Invalid Test Type Please Select A Valid One !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _LoadTestTypeInfo(clsTestType.enTestType TestTypeID , decimal PaidFees)
        {
            if (TestTypeID != clsTestType.enTestType.enNone)
            {
                clsTestType TestType = new clsTestType();
                if ((TestType = clsTestType.Find(TestTypeID)) != null)
                {
                    lblTestTytle.Text = TestType.Title;
                    txtFees.Text = PaidFees.ToString();
                }
                else
                {
                    MessageBox.Show($"The Test Type With ID = {TestTypeID} Is Not Found !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Invalid Test Type Please Select A Valid One !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadTestInfo(int LocalDrivingLicenseApplicationID , clsTestType.enTestType TestType)
        {
            _LoadLocalDrivingLicenseInfo(LocalDrivingLicenseApplicationID , TestType);
            _LoadTestTypeInfo(TestType);
        }
        public void LoadTestInfo(int TestAppointmentID)
        {
            clsTestAppointement TestAppointment = new clsTestAppointement();
            if((TestAppointment = clsTestAppointement.Find(TestAppointmentID))!=null)
            {
                LoadTestInfo(TestAppointment);
            }
            else
            {
                MessageBox.Show("Test Appointment Is Not Found" , "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        public void LoadTestInfo(clsTestAppointement TestAppointment)
        { 
            _LoadLocalDrivingLicenseInfo(TestAppointment.LocalDrivingLicenseApplicationID , (clsTestType.enTestType)TestAppointment.TestType);
            _LoadTestTypeInfo((clsTestType.enTestType) TestAppointment.TestType , TestAppointment.PaidFees);
            dtpDate.Enabled = (!TestAppointment.IsLocked);
        }
        public DateTime GetAppointmentDate()
        {
            return dtpDate.Value;
        }
        public void ReadOnly()
        {
            dtpDate.Enabled = false;
        }
    }
}
