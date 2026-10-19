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
    public partial class frmScheduleTest : Form
    {
        public enum enTestMode { enNewTest, enRetakeTest }
        public enum enMode { enUpdate , enAddNew}
        private enTestMode TestMode;
        private enMode Mode;
        private clsTestAppointement TestAppointment = new clsTestAppointement();
        public frmScheduleTest(int LocalDrivingLicenseApplication, clsTestType.enTestType TestType, enTestMode Mode)
        {
            InitializeComponent();
            TestAppointment.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplication;
            TestAppointment.TestType = TestType;
            this.TestMode = Mode;
            this.Mode = enMode.enAddNew;
        }
        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();
            clsTestAppointement TestAppointment = new clsTestAppointement();
            if ((TestAppointment = clsTestAppointement.Find(TestAppointmentID)) != null)
            {
                this.TestAppointment = TestAppointment;
                TestMode = (TestAppointment.RetakeTestApplicationID != -1) ? enTestMode.enRetakeTest :  enTestMode.enNewTest;
                this.Mode = enMode.enUpdate;
            }
        }
        private void _LoadRetakTestInfo()
        {

            //if( (TestMode ==enTestMode.enNewTest || (TestAppointment.Mode ==clsTestAppointement.enMode.Update && TestAppointment.RetakeTestApplicationID==-1)))
            //{
            //    gbRetackTest.Visible = false;
            //    return;
            //}
            //if(TestMode ==enTestMode.enRetakeTest) 
            //{
            //    decimal ApplicationTypeFees = clsApplicationType.FindByApplicationID(7).Fees;
            //    txtRetakTestFees.Text = ApplicationTypeFees.ToString();
            //    txtTotal.Text = (ApplicationTypeFees + TestAppointment.PaidFees).ToString();
            //    txtRetakTestID.Text = (TestAppointment.RetakeTestApplicationID != -1) ? TestAppointment.RetakeTestApplicationID.ToString() : "********";
            //    return;
            //}
            decimal TestTypeFees = 0;
            switch (Mode)
            {
                case (enMode.enAddNew):
                    {
                        TestTypeFees = clsTestType.Find(TestAppointment.TestType).Fees;
                        break;
                    }
                case (enMode.enUpdate):
                    {
                        TestTypeFees = TestAppointment.PaidFees;
                        break;
                    }
            }
            
            switch (TestMode)

            {
                
                case enTestMode.enRetakeTest:
                    {
                        decimal ApplicationTypeFees = clsApplicationType.Find(clsApplicationType.enApplicationType.enRetakeTest).Fees;
                        txtRetakTestFees.Text = ApplicationTypeFees.ToString();
                        txtTotal.Text = (ApplicationTypeFees + TestTypeFees).ToString();
                        txtRetakTestID.Text = (TestAppointment.RetakeTestApplicationID !=-1)? TestAppointment.RetakeTestApplicationID.ToString() : txtRetakTestID.Text = "********"; ;
                        gbRetackTest.Visible = true;

                        break;
                    }
                    case enTestMode.enNewTest:
                    {
                        txtRetakTestID.Text = "********";
                        gbRetackTest.Visible = false;
                        break;
                    }
            }


        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            //if(TestAppointment.Mode == clsTestAppointement.enMode.Update)
            //    ctrlTestInfo.LoadTestInfo(TestAppointment);
            //else
            //    ctrlTestInfo.LoadTestInfo(TestAppointment.LocalDrivingLicenseApplicationID, (clsTestType.enTestTypeType)TestAppointment.TestType);
            //_LoadRetakTestInfo();
            switch (Mode)
            {
                case (enMode.enAddNew):
                    {
                        ctrlTestInfo.LoadTestInfo(TestAppointment.LocalDrivingLicenseApplicationID, (clsTestType.enTestType)TestAppointment.TestType);
                        break;
                    }
                case (enMode.enUpdate):
                    {
                        ctrlTestInfo.LoadTestInfo(TestAppointment);
                        break;
                    }
            }
            _LoadRetakTestInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TestAppointment.AppointmentDate = ctrlTestInfo.GetAppointmentDate();
            if (TestAppointment.Save())
            {
                if(TestAppointment.RetakeTestApplicationID !=-1)
                {
                    txtRetakTestFees.Text = TestAppointment.RetakeTestApplicationID.ToString();
                    Mode = enMode.enUpdate;
                }
                MessageBox.Show("Save Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save Failed", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void ctrlTestInfo_Load(object sender, EventArgs e)
        {

        }
    }
}