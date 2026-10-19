using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLDBusinessLayer
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public clsApplicationType.enApplicationType ApplicationTypeID { get; set; }
        public enStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public enum enMode { Add, Update }
        public enum enStatus { New = 1, Cancelled = 2, Completed = 3 }
        public enMode Mode { get; set; }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = clsApplicationType.enApplicationType.enNone;
            this.ApplicationStatus = enStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
            this.Mode = enMode.Add;
        }
        public clsApplication(int ApplicationPersonID, clsApplicationType.enApplicationType ApplicationTypeID)
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = enStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = clsApplicationType.Find(ApplicationTypeID).Fees;
            this.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
            this.Mode = enMode.Add;
        }
        private clsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, clsApplicationType.enApplicationType ApplicationTypeID, enStatus ApplicationStatus
             , DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.Mode = enMode.Update;
        }
        //public static DataTable GetApplicationsList()
        //{
        //    return DVLDDataAccessLayer.clsApplicationsDataAccess.GetApplicationsList();
        //}
        //public static DataTable GetFilteredApplicationsList(string ColumnName, string Value)
        //{
        //    return DVLDDataAccessLayer.clsApplicationsDataAccess.GetFilteredApplicationsList(ColumnName, Value);
        //}
        //public static DataTable GetFilteredApplicationsListByApplicationID(int ApplicationID)
        //{
        //    return DVLDDataAccessLayer.clsApplicationsDataAccess.GetFilteredApplicationsListByApplicationID(ApplicationID);
        //}
        //public static DataTable GetFilteredApplicationsList(enStatus Status)
        //{
        //    return DVLDDataAccessLayer.clsApplicationsDataAccess.GetFilteredApplicationsList(Status);
        //}
        //public static DataTable GetFilteredApplicationsListByPersonID(int PersonID)
        //{
        //    return DVLDDataAccessLayer.clsApplicationsDataAccess.GetFilteredApplicationsListByPersonID(PersonID);
        //}
        public static clsApplication Find(int ApplicationID)
        {
            int ApplicationPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
            byte ApplicationStatus = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            if (DVLDDataAccessLayer.clsApplicationsDataAccess.FindApplication( ApplicationID, ref  ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus
             , ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                clsApplication Application = new clsApplication(ApplicationID, ApplicationPersonID, ApplicationDate, (clsApplicationType.enApplicationType) ApplicationTypeID,(enStatus) ApplicationStatus,
                    LastStatusDate, PaidFees, CreatedByUserID);
                return Application;
            }
            return null;
        }
        public static clsApplication Find(int ApplicationPersonID, int ApplicationTypeID , int LicenseClassID)
        {
            int ApplicationID = -1, CreatedByUserID = -1;
            int ApplicationStatus = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            if (DVLDDataAccessLayer.clsApplicationsDataAccess.FindApplication(ApplicationPersonID, ApplicationTypeID, LicenseClassID , ref ApplicationID, ref ApplicationDate, ref ApplicationStatus
             , ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                clsApplication Application = new clsApplication(ApplicationID, ApplicationPersonID, ApplicationDate, (clsApplicationType.enApplicationType)ApplicationTypeID, (enStatus)ApplicationStatus,
                    LastStatusDate, PaidFees, CreatedByUserID);
                return Application;
            }
            return null;
        }
        //public static clsApplication FindByPersonID(int ApplicationPersonID)
        //{
        //    int ApplicationID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
        //    DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
        //    enStatus ApplicationStatus = enStatus.New;
        //    double PaidFees = 0;
        //    if (DVLDDataAccessLayer.clsApplicationsDataAccess.FindApplication(int ApplicationPersonID, ref int ApplicationID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref enStatus ApplicationStatus
        //     , ref DateTime LastStatusDate, ref double PaidFees, ref int CreatedByUserID))
        //    {
        //        clsApplication Application = new clsApplication(this.ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
        //            LastStatusDate, PaidFees, CreatedByUserID);
        //        return Application;
        //    }
        //    return null;
        //}

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        int ApplicationID = -1;
                        //if (!clsApplication.IsExistByPersonID(PersonID))
                        //{
                        if (clsApplicationsDataAccess.AddNew(ref ApplicationID , ApplicationPersonID, ApplicationDate, (int)ApplicationTypeID, (byte) ApplicationStatus,
                          LastStatusDate, PaidFees, CreatedByUserID))
                                {
                            this.ApplicationPersonID = ApplicationPersonID;
                            this.ApplicationID = ApplicationID;
                            this.Mode = enMode.Update;
                            return true;
                        }
                        return false;
                        //}
                        //return false;
                    }
                case enMode.Update:
                    {

                        return clsApplicationsDataAccess.Update(ApplicationID, ApplicationPersonID, ApplicationDate, (int)ApplicationTypeID, (byte) ApplicationStatus,
                              LastStatusDate, PaidFees, CreatedByUserID);

                    }
                default: return false;
            }
        }
        public static bool Delete(int ApplicationID)
        {
            return clsApplicationsDataAccess.Delete(ApplicationID);
        }
        public static bool DeleteByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            if(clsLocalDrivingLicenseApplication.Delete(LocalDrivingLicenseApplicationID))
            {
                if ((LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID)) != null)
                {
                    return Delete(LocalDrivingLicenseApplication.ApplicationID);
                }
                return false;
            }
            return false;
        }
        //public static bool IsExist(int ApplicationID)
        //{
        //    return clsApplicationsDataAccess.IsExistApplication(ApplicationID);
        //}
        //public static bool IsExistByPersonID(int ApplicationPersonID)
        //{
        //    return clsApplicationsDataAccess.IsExistApplicationByPersonID(ApplicationPersonID);
        //}
        public  static bool Cancel(int ApplicationID)
        {
            clsApplication Application = new clsApplication();
            if ((Application=clsApplication.Find(ApplicationID))!=null)
            {
                Application.ApplicationStatus = clsApplication.enStatus.Cancelled;
                Application.LastStatusDate = DateTime.Now;
                return Application.Save();
            }
            return false;
        }
        public static bool CancelByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            if((LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID))!=null)
            {
                return Cancel(LocalDrivingLicenseApplication.ApplicationID);
            }
            return false;
        }

    }

}
