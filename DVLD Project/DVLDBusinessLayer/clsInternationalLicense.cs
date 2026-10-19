using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI;
using static DVLDBusinessLayer.clsLicense;

namespace DVLDBusinessLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public enum enMode { enAddNew, enUpdate }
        public enMode Mode { get; set; }
        public clsInternationalLicense(int LicenseID)
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = LicenseID;
            IssueDate = DateTime.Now;
            ExpirationDate = IssueDate.AddYears(clsDVLDBusinessSettings.DefaultValidityLengthForInternationalLicense);
            IsActive = true;
            CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
            Mode = enMode.enAddNew;
        }
        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID =-1;
            IssueDate = DateTime.Now;
            ExpirationDate = IssueDate.AddYears(clsDVLDBusinessSettings.DefaultValidityLengthForInternationalLicense);
            IsActive = true;
            CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
            Mode = enMode.enAddNew;
        }
        private clsInternationalLicense( int InternationalLicenseID, int ApplicationID,int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID= IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }
        static public clsInternationalLicense FindByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1 , ApplicationID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;
            if (clsInternationalLicensesDataAccess.FindInternationalLicenseByDriverID (DriverID, ref InternationalLicenseID, ref ApplicationID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsInternationalLicense InternationalLicense = new clsInternationalLicense(  InternationalLicenseID,  ApplicationID, DriverID,  IssuedUsingLocalLicenseID,  IssueDate,  ExpirationDate,  IsActive,  CreatedByUserID);
                return InternationalLicense;
            }
            return null;
        }
        static public clsInternationalLicense Find(int InternationalLicenseID)
        {
            int DriverID = -1, ApplicationID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;
            if (clsInternationalLicensesDataAccess.FindInternationalLicense( InternationalLicenseID, ref DriverID , ref ApplicationID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsInternationalLicense InternationalLicense = new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
                return InternationalLicense;
            }
            return null;
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.enAddNew:
                    {
                        clsDriver Driver = clsDriver.Find(this.DriverID);
                        if (Driver == null)
                            return false;
                        clsApplication Application = new clsApplication(Driver.PersonID, clsApplicationType.enApplicationType.enNewInternationalLicense);
                        if(!Application.Save())
                            return false;
                        this.ApplicationID = Application.ApplicationID;
                        this.DriverID = Driver.DriverID;
                        int InternationalLicenseID = -1;
                        if (clsInternationalLicensesDataAccess.AddNew(ref InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID))
                        {
                            this.InternationalLicenseID = InternationalLicenseID;
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
        static public DataTable GetInternationalLicensesListByPersonID(int PersonID)
        {
            return clsInternationalLicensesDataAccess.GetInternationalLicensesListByPersonID(PersonID);
        }
        static public DataTable GetInternationalLicensesList()
        {
            return clsInternationalLicensesDataAccess.GetInternationalLicensesList();
        }
        static public DataTable GetInternationalLicensesListByDriverID(int PersonID)
        {
            return clsInternationalLicensesDataAccess.GetInternationalLicensesListByDriverID(PersonID);
        }
        static public DataTable GetInternationalLicensesListByStatus(bool IsActive)
        {
            return clsInternationalLicensesDataAccess.GetInternationalLicensesListByStatus(IsActive);
        }
        static public DataTable GetInternationalLicensesListByID(int InternationalLicenseID)
        {
            return clsInternationalLicensesDataAccess.GetInternationalLicensesListByID(InternationalLicenseID);
        }
    }
}
