using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusinessLayer.clsApplication;

namespace DVLDBusinessLayer
{
    public class clsLicense
    {
        public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4 }
        public enum enMode { enAddNew, enUpdate }
        public enMode Mode { get; set; }
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public enum enAddInternationalLicenseResult { enDateExpirationErreur , enNot3Class , enHasActiveInternationalLicense , enIsDaitianedLicense , Allowed}
        public enum enRenewLocalDrivingLicenseResult { enIsNotExpired , enIsDaitianedLicense, Allowed }
        public enum enReplacementLicenseResult { enIsExpired, enIsDaitianedLicense, Allowed }
        public enum enDetainLicenseResult { enNotActiveLicense, enIsDaitianedLicense, Allowed }
        
        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive,
            enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.Mode = enMode.enUpdate;
        }
        public clsLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive,

           enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = -1;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.Mode = enMode.enAddNew;
        }
        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = clsLicense.enIssueReason.FirstTime;
            this.CreatedByUserID = -1;
            this.Mode = enMode.enAddNew;
        }



        public bool Save()
        {

            switch (this.Mode)
            {
                case enMode.enAddNew:
                    {
                        switch(IssueReason)
                        {
                            case enIssueReason.FirstTime:
                                {
                                    clsApplication Application = clsApplication.Find(this.ApplicationID);
                                    Application.ApplicationStatus = clsApplication.enStatus.Completed;
                                    Application.LastStatusDate = DateTime.Now;
                                    if (!Application.Save()) return false;
                                    int PersonID = Application.ApplicationPersonID;
                                    clsDriver Driver = new clsDriver();
                                    if ((Driver = clsDriver.FindByPersonID(PersonID)) == null)
                                    {
                                        Driver = new clsDriver();
                                        Driver.CreatedDate = DateTime.Now;
                                        Driver.CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
                                        Driver.PersonID = PersonID;
                                        if (!Driver.Save()) return false;   
                                    }
                                    this.DriverID = Driver.DriverID;
                                    break;
                                }
                            case enIssueReason.Renew:
                                {
                                    clsDriver Driver = clsDriver.Find(this.DriverID);
                                    if (Driver == null) return false;
                                    clsApplication Application = new clsApplication(Driver.PersonID, clsApplicationType.enApplicationType.enRenewLicsense);
                                    if (!Application.Save()) return false;
                                    this.ApplicationID = Application.ApplicationID;
                                    if(!DisactivateLicense(true))return false;
                                    break;
                                }
                            case enIssueReason.ReplacementForLost:
                                {
                                    clsDriver Driver = clsDriver.Find(this.DriverID);
                                    if (Driver == null) return false;
                                    clsApplication Application = new clsApplication(Driver.PersonID, clsApplicationType.enApplicationType.enReplacementForLostLicsense);
                                    if (!Application.Save()) return false;
                                    this.ApplicationID = Application.ApplicationID;
                                    if (!DisactivateLicense()) return false;
                                    break;
                                }
                            case enIssueReason.ReplacementForDamaged:
                                {
                                    clsDriver Driver = clsDriver.Find(this.DriverID);
                                    if (Driver == null) return false;
                                    clsApplication Application = new clsApplication(Driver.PersonID, clsApplicationType.enApplicationType.enReplacementForDamagedLicsense);
                                    if (!Application.Save()) return false;
                                    this.ApplicationID = Application.ApplicationID;
                                    if (!DisactivateLicense()) return false;
                                    break;
                                }
                        }
                        int LicenseID = -1;
                        if (clsLicensesDataAccess.AddNew( ref LicenseID,  ApplicationID,  DriverID,  LicenseClass,  IssueDate,  ExpirationDate,  Notes,  PaidFees,  IsActive, (int) IssueReason,  CreatedByUserID))
                        {  
                            this.LicenseID = LicenseID;
                            this.Mode = enMode.enUpdate;
                            return true;
                        }
                        return false;
                    }
                //case :
                //    {

                //        return clsApplicationsDataAccess.Update(ApplicationPersonID, ApplicationID, ApplicationDate, ApplicationTypeID, (byte)ApplicationStatus,
                //              LastStatusDate, PaidFees, CreatedByUserID);

                //    }
                default: return false;
            }
        }
        public static bool IsExist(int ApplicationID , int LicenseClassID)
        {
            return clsLicensesDataAccess.IsExistLicense(ApplicationID , LicenseClassID);
        }
        public static bool IsExist(int LocalDrivingLicenseApplicatoinID)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicatoinID);

            return clsLicense.IsExist(LocalDrivingLicenseApplication.ApplicationID , LocalDrivingLicenseApplication.LicenseClassID);
        }
        static public DataTable GetDriverLicensesListByPersonID(int PersonID)
        {
            return clsLicensesDataAccess.GetDriverLicensesListByPersonID(PersonID);
        }
        static public DataTable GetDriverLicensesListByDriverID(int Driver)
        {
            return clsLicensesDataAccess.GetDriverLicensesListByDriverID(Driver);
        }
        public static clsLicense FindByApplicationID(int ApplicationID)
        {
            int LicenseID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1, IssueReason = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            if (DVLDDataAccessLayer.clsLicensesDataAccess.FindLicenseByApplicationID(ApplicationID,  ref LicenseID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                clsLicense License = new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,(clsLicense.enIssueReason) IssueReason, CreatedByUserID);
                return License;
            }
            return null;
        }
        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1, IssueReason = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            if (DVLDDataAccessLayer.clsLicensesDataAccess.FindLicense(LicenseID , ref ApplicationID ,  ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                clsLicense License = new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (clsLicense.enIssueReason)IssueReason, CreatedByUserID);
                return License;
            }
            return null;
        }

        public enAddInternationalLicenseResult AddInternationalLicenseResult(ref int ActiveInternationalLicense)
        {
            if (LicenseClass != 3)
                return enAddInternationalLicenseResult.enNot3Class;
            if (ExpirationDate < DateTime.Now)
                return enAddInternationalLicenseResult.enDateExpirationErreur;
            if (!IsActive)
                return enAddInternationalLicenseResult.enIsDaitianedLicense;
            clsInternationalLicense InternationalLicense = clsInternationalLicense.FindByDriverID(DriverID);
            if (InternationalLicense !=null)
            {
                ActiveInternationalLicense = InternationalLicense.InternationalLicenseID;
                return enAddInternationalLicenseResult.enHasActiveInternationalLicense;
            }
            return enAddInternationalLicenseResult.Allowed;
                

        }
        public enRenewLocalDrivingLicenseResult RenewLocalDrivingLicenseResult()
        {
            
            if (!IsActive)
                return enRenewLocalDrivingLicenseResult.enIsDaitianedLicense;
            if (ExpirationDate > DateTime.Now)
                return enRenewLocalDrivingLicenseResult.enIsNotExpired;
            return enRenewLocalDrivingLicenseResult.Allowed;


        }
        public enReplacementLicenseResult ReplacementLicenseResult()
        {
            
            if (!IsActive)
                return enReplacementLicenseResult.enIsDaitianedLicense;
            if (ExpirationDate < DateTime.Now)
                return enReplacementLicenseResult.enIsExpired;
            return enReplacementLicenseResult.Allowed;


        }
        public static bool IsDetainedLicense(int LicenseID)
        {
            clsDetainedLicense DetainLicense = clsDetainedLicense.FindLastDetainedLicense(LicenseID);
            if (DetainLicense == null || DetainLicense.IsReleased) return false;
            return true;
        }
        public bool IsDetainedLicense()
        {
            return IsDetainedLicense(this.LicenseID);
        }
        public enDetainLicenseResult DetainLicenseResult()
        {
            
            if (!IsActive)
                return enDetainLicenseResult.enNotActiveLicense;
            if (this.IsDetainedLicense())
                return enDetainLicenseResult.enIsDaitianedLicense;
            return enDetainLicenseResult.Allowed;
        }

        public static bool DisactivateLicense(int LicenseClassID , int DriverID , bool ExpiredLicenseOnly = false)
        {
            return clsLicensesDataAccess.DisactivateLicense(LicenseClassID , DriverID , ExpiredLicenseOnly);
        }
        public bool DisactivateLicense(bool ExpiredLicenseOnly = false)
        {
            return DisactivateLicense(this.LicenseClass, this.DriverID , ExpiredLicenseOnly);
        }

    }
}

