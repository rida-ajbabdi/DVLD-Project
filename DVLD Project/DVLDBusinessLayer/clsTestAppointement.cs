using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDBusinessLayer.clsApplication;
using static DVLDBusinessLayer.clsPerson;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBusinessLayer
{
    public class clsTestAppointement
    {
        public int TestAppointmentID { get; set; }
        public clsTestType.enTestType TestType { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public enum enTestApointmentResult { enExistActiveTestAppointment, enPassedTest , enRetakeTestAppointment, enNewTestAppointment }
        public enum enMode { Add, Update }
        public enMode Mode { get; set; }
        private clsTestAppointement(int TestAppointmentID, int LocalDrivingLicenseApplicationID , clsTestType.enTestType TestType, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestType = TestType;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.Mode = enMode.Update;
        }
        public clsTestAppointement()
        {
            this.TestAppointmentID = -1;
            this.TestType = clsTestType.enTestType.enNone;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = true;
            this.RetakeTestApplicationID = -1;
            this.Mode = enMode.Add;
        }

        public static DataTable GetTestAppointmentsList(int LocalDrivingLicenseApplicationID , clsTestType.enTestType TestType)
        {
            return clsTestsAppointmentsDataAccess.GetTestAppointmentsList(LocalDrivingLicenseApplicationID, (int)TestType);
        }
        public static bool IsExist(int LocalDrivingLicenseApplicationID , clsTestType.enTestType Test , bool IsLocked = false)
        {
            return clsTestsAppointmentsDataAccess.IsExist(LocalDrivingLicenseApplicationID, (int)Test , IsLocked);
        }
        public static bool IsExist(int TestAppointmentID)
        {
            return clsTestsAppointmentsDataAccess.IsExist(TestAppointmentID);
        }
        public static clsTestAppointement Find(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            int TestAppointmentID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            decimal PaidFees = 0;
            bool IsLocked = true;
            DateTime AppointmentDate = DateTime.Now;
            if (DVLDDataAccessLayer.clsTestsAppointmentsDataAccess.FindLastTestAppointment(LocalDrivingLicenseApplicationID, (int)TestTypeID, ref TestAppointmentID, ref AppointmentDate, ref PaidFees
             , ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                clsTestAppointement TestAppointment = new clsTestAppointement(TestAppointmentID, LocalDrivingLicenseApplicationID,  TestTypeID,    AppointmentDate,  PaidFees
             ,  CreatedByUserID,  IsLocked,  RetakeTestApplicationID);
                return TestAppointment;
            }
            return null;
        }
        public static clsTestAppointement Find(int TestAppointmentID)
        {
            int LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1 , TestTypeID =-1;
            decimal PaidFees = 0;
            bool IsLocked = true;
            DateTime AppointmentDate = DateTime.Now;
            if (DVLDDataAccessLayer.clsTestsAppointmentsDataAccess.Find( TestAppointmentID , ref LocalDrivingLicenseApplicationID, ref TestTypeID,  ref AppointmentDate, ref PaidFees
             , ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                clsTestAppointement TestAppointment = new clsTestAppointement(TestAppointmentID , LocalDrivingLicenseApplicationID, (clsTestType.enTestType) TestTypeID, AppointmentDate, PaidFees
             , CreatedByUserID, IsLocked, RetakeTestApplicationID);
                return TestAppointment;
            }
            return null;
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        this.PaidFees = clsTestType.Find(this.TestType).Fees;
                        this.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
                        this.IsLocked = false;
                        switch (AddNewTestAppointmentResult())
                        {
                            case enTestApointmentResult.enNewTestAppointment:
                                {
                                    int TestAppointmentID = -1;
                                    if (clsTestsAppointmentsDataAccess.AddNew(ref TestAppointmentID ,(int) TestType, LocalDrivingLicenseApplicationID , AppointmentDate , PaidFees , CreatedByUserID , IsLocked , RetakeTestApplicationID))
                                    {
                                        this.TestAppointmentID = TestAppointmentID;
                                        this.Mode = enMode.Update;
                                        return true;
                                    }
                                    break;
                                }
                            case enTestApointmentResult.enRetakeTestAppointment:
                                {
                                    clsApplication Application = new clsApplication();
                                    Application.ApplicationPersonID =clsApplication.Find( clsLocalDrivingLicenseApplication.Find( this.LocalDrivingLicenseApplicationID).ApplicationID).ApplicationPersonID;
                                    Application.ApplicationDate = DateTime.Now;
                                    Application.ApplicationTypeID = clsApplicationType.enApplicationType.enRetakeTest;
                                    Application.ApplicationStatus = enStatus.Completed;
                                    Application.LastStatusDate = DateTime.Now;
                                    Application.PaidFees = clsApplicationType.Find(clsApplicationType.enApplicationType.enRetakeTest).Fees;
                                    Application.CreatedByUserID = this.CreatedByUserID;
                                    if (Application.Save())
                                    {
                                        int TestAppointmentID = -1;
                                        this.RetakeTestApplicationID = Application.ApplicationID;
                                        if (clsTestsAppointmentsDataAccess.AddNew(ref TestAppointmentID, (int)TestType, LocalDrivingLicenseApplicationID, AppointmentDate,PaidFees , CreatedByUserID, IsLocked, RetakeTestApplicationID))
                                        {
                                            this.TestAppointmentID = TestAppointmentID;
                                            this.Mode = enMode.Update;
                                            return true;
                                        }
                                    }
                                    break;

                                }
                            default: { return false; }
                        }
                    
                        //if (!clsTestAppointment.IsExistByPersonID(PersonID))
                        //{
         
                        return false;
                        //}
                        //return false;
                    }
                case enMode.Update:
                    {
                        if (IsLocked)
                            return false;
                        return clsTestsAppointmentsDataAccess.Update( TestAppointmentID, (int)TestType , LocalDrivingLicenseApplicationID ,AppointmentDate , PaidFees , CreatedByUserID,IsLocked , RetakeTestApplicationID);

                    }
                default: return false;
            }
        }
        public static enTestApointmentResult AddNewTestAppointmentResult(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            clsTestAppointement TestAppointment = new clsTestAppointement();
            if ((TestAppointment = clsTestAppointement.Find(LocalDrivingLicenseApplicationID, TestType)) == null)
                return enTestApointmentResult.enNewTestAppointment;
            if (!TestAppointment.IsLocked)
                return enTestApointmentResult.enExistActiveTestAppointment;
            clsTest Test = new clsTest();
            if ((Test = clsTest.Find(TestAppointment.TestAppointmentID)).TestResult == false)
                return enTestApointmentResult.enRetakeTestAppointment;
            return enTestApointmentResult.enPassedTest;
        }
        public enTestApointmentResult AddNewTestAppointmentResult()
        {
            return AddNewTestAppointmentResult(this.LocalDrivingLicenseApplicationID, (clsTestType.enTestType)this.TestType);
        }
        public static bool Lock(int TestAppointmentID)
        {
            return clsTestsAppointmentsDataAccess.LockTestAppointment(TestAppointmentID);
        }
        public static DateTime TestAppointmentDateMinValue(int LocalDrivingLicenseApplictionID, clsTestType.enTestType TestType)
        {
            DateTime LastTestAppointmentDate = clsTestsDataAccess.LastTestDateOrDefault(LocalDrivingLicenseApplictionID, (int)TestType).AddMinutes(10);
            DateTime Now = DateTime.Now;
            return (LastTestAppointmentDate>Now)?LastTestAppointmentDate : Now;
        }
    }
}
