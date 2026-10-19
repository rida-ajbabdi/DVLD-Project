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
    public partial class frmTestAppointments : Form
    {
        clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
        clsTestType.enTestType TestType = clsTestType.enTestType.enNone;
        public frmTestAppointments(clsTestType.enTestType TypeTest , int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this.TestType = TypeTest;
            clsLocalDrivingLicenseApplication Application = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            if ( Application != null)
                this.LocalDrivingLicenseApplication = Application;
        }
        private void _RefreshListTestAppointments(int LocalDrivingLicenseApplicationID , clsTestType.enTestType TestType)
        {
            dgvListTestAppointments.DataSource = clsTestAppointement.GetTestAppointmentsList(LocalDrivingLicenseApplicationID , TestType);
        }
        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLlisenceApplicationInfo.LoadLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            _RefreshListTestAppointments(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsTestAppointement.enTestApointmentResult Result = clsTestAppointement.AddNewTestAppointmentResult(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType);
            switch(Result)
            {
                case clsTestAppointement.enTestApointmentResult.enPassedTest:
                {
                        MessageBox.Show("This _Person Is Already Pass This Test !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                case clsTestAppointement.enTestApointmentResult.enNewTestAppointment:
                { 
                    frmScheduleTest frm = new frmScheduleTest(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID , TestType , frmScheduleTest.enTestMode.enNewTest);
                        frm.ShowDialog();
                        _RefreshListTestAppointments(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType);
                        break;
                }
                case clsTestAppointement.enTestApointmentResult.enRetakeTestAppointment:
                {
                        frmScheduleTest frm = new frmScheduleTest(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType, frmScheduleTest.enTestMode.enRetakeTest);
                        frm.ShowDialog();
                        _RefreshListTestAppointments(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType);
                        break;
                }
                case clsTestAppointement.enTestApointmentResult.enExistActiveTestAppointment:
                {
                        MessageBox.Show("This Local Driving License Application Has Already An Active Appointment !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                default:
                { break; }
            }
        }

        private void cmsiEdit_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListTestAppointments.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                frmScheduleTest frm = new frmScheduleTest(ID);
                frm.ShowDialog();
                _RefreshListTestAppointments(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType);
            }

            else
            {
                MessageBox.Show("Invalid ID , Please Select A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsiTakeTest_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListTestAppointments.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                frmTakeTest frm = new frmTakeTest(ID);
                frm.ShowDialog();
                _RefreshListTestAppointments(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType);
            }

            else
            {
                MessageBox.Show("Invalid ID , Please Select A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
