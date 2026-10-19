using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDBusinessLayer.clsTestAppointement;

namespace DVLDBusinessLayer
{
    public enum enAddNewLocalDrivingLicenseResult { enHasActiveApplication , enHasLicense}
    public class clsLocalDrivingLicenseApplication
    {
        public int LocalDrivingLicenseApplicationID {  get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public enum enMode { Add, Update }
        public enMode Mode { get; set; }
        
        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID ,int ApplicationID , int ApplicationClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = ApplicationClassID;
            this.Mode = enMode.Update;
        }
        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
        }
        static public DataTable GetLocalDrivingLicenseApplicationsList()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetLocalDrivingLicenseApplicationsList();
        }
        static public DataTable GetFilteredLocalDrivingLisenceApplicationsList(clsApplication.enStatus Status)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetFilteredLocalDrivingLisenceApplicationsList((byte)Status);
        }
        static public DataTable GetFilteredLocalDrivingLisenceApplicationsList(int LocalDrivingLisenceApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetFilteredLocalDrivingLisenceApplicationsList(LocalDrivingLisenceApplicationID);
        }
        static public DataTable GetFilteredLocalDrivingLisenceApplicationsList(string ColumnName, string Value)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetFilteredLocalDrivingLisenceApplicationsList(ColumnName ,Value);
        }

        public static clsLocalDrivingLicenseApplication Find(int ApplicationPersonID, int LicenseClassID, clsApplication.enStatus ApplicationStatus)
        {
            int LocalDrivingLicenseApplicationID=-1, ApplicationID = -1;
            if (clsLocalDrivingLicenseApplicationsDataAccess.Find(ApplicationPersonID , LicenseClassID  ,  (int)ApplicationStatus , ref LocalDrivingLicenseApplicationID , ref ApplicationID ))
            {
                clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID , LicenseClassID);
                return LocalDrivingLicenseApplication;
            }
            return null;
        }
        //public static clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationPersonID, int LicenseClassID)
        //{
        //    int LocalDrivingLicenseApplicationID = -1, ApplicationID = -1, ApplicationStatus = -1;
        //    if (clsApplication.FindByApplicationID(ApplicationPersonID, LicenseClassID, ref LocalDrivingLicenseApplicationID, ref ApplicationID, ref ApplicationStatus))
        //    {
        //        clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
        //        return LocalDrivingLicenseApplication;
        //    }
        //    return null;
        //}
        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;
            if (clsLocalDrivingLicenseApplicationsDataAccess.Find(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID , LicenseClassID);
                return LocalDrivingLicenseApplication;
            }
            return null;
        }
        public bool Save(int PersonID)
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        int LocalDriverLicenseApplicationID = -1;
                        clsLocalDrivingLicenseApplication NewApplication = clsLocalDrivingLicenseApplication.Find(PersonID, LicenseClassID, clsApplication.enStatus.New);
                        if (NewApplication != null)
                            return false;

                        clsApplication Application = new clsApplication();
                        Application.PaidFees = clsApplicationType.Find(clsApplicationType.enApplicationType.enNewLocalLicense).Fees;
                        Application.ApplicationPersonID = PersonID;
                        Application.ApplicationTypeID = clsApplicationType.enApplicationType.enNewLocalLicense;
                        if (Application.Save())
                        { 
                            if(clsLocalDrivingLicenseApplicationsDataAccess.AddNew(ref LocalDriverLicenseApplicationID , Application.ApplicationID , LicenseClassID))
                            {
                                this.LocalDrivingLicenseApplicationID = LocalDriverLicenseApplicationID;
                                this.ApplicationID = Application.ApplicationID;
                                this.LicenseClassID = LicenseClassID;
                                this.Mode = enMode.Update;
                                return true;
                            }
                            return false;
                        }
                        return false;
                    }

                case enMode.Update:
                    {

                        return clsLocalDrivingLicenseApplicationsDataAccess.Update(LocalDrivingLicenseApplicationID, LicenseClassID);

                    }
                default: return false;
            }
        }

        public static int PassedTest(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.PassedTestCount(LocalDrivingLicenseApplicationID);
        }
        public int PassedTest()
        {
            return clsLocalDrivingLicenseApplication.PassedTest(this.LocalDrivingLicenseApplicationID);
        }
        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.Delete(LocalDrivingLicenseApplicationID);
        }
        //public static enTestApointmentResult AddNewLocalDrivingLicenseApplicationResult(int PersonID, clsTestType.enTestTypeType TestType , ref int ApplicationID)
        //{
        //    clsLocalDrivingLicenseApplication NewApplication = new clsLocalDrivingLicenseApplication();
        //    if ((NewApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(PersonID, (int)TestType, clsApplication.enStatus.New)) == null)
        //    {

        //    }
        //}
    }
}
