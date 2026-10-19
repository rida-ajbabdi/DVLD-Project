using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using static DVLDBusinessLayer.clsLicense;

namespace DVLDBusinessLayer
{
    public class clsDetainedLicense
    {
        public int DetainID {  get; set; }
        public int LicenseID {  get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public enum enMode { enAdd, enUpdate }
        public enMode Mode { get; set; }
        public enum enReleaseDetainedLicenseResult { enIsNotDaitianedLicense, Allowed }


        public clsDetainedLicense(int LicenseID , DateTime DetainDate , decimal FineFees , int CreatedByUserID , bool IsReleased , DateTime ReleaseDate, int ReleasedByUserID , int ReleasedApplicationID)
        {
            this.DetainID = -1;
            this.LicenseID  = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleasedApplicationID;
            Mode = enMode.enAdd;
        }
        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = true;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            Mode = enMode.enAdd;
        }
        private clsDetainedLicense(int DetainID , int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleasedApplicationID)

        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleasedApplicationID;
            Mode = enMode.enUpdate;
        }
        public static clsDetainedLicense FindLastDetainedLicense(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1 , ReleaseApplicationID=-1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 0;
            bool IsReleased = false;
            if (DVLDDataAccessLayer.clsDetainedLicensesDataAccess.FindLastDetainedLicense(LicenseID, ref DetainID , ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                clsDetainedLicense DetainLicense = new clsDetainedLicense(DetainID, LicenseID , DetainDate,  FineFees,  CreatedByUserID,  IsReleased,  ReleaseDate,  ReleasedByUserID,  ReleaseApplicationID);
                return DetainLicense;
            }
            return null;
        }
        public bool Save()
        {

            switch (this.Mode)
            {
                case enMode.enAdd:
                    {
                        int DetainID = -1;
                        if (clsDetainedLicensesDataAccess.AddNew(ref DetainID , LicenseID ,  DetainDate,  FineFees,  CreatedByUserID,  IsReleased,  ReleaseDate,  ReleasedByUserID,  ReleaseApplicationID))
                        {
                            this.DetainID = DetainID;
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
        public enReleaseDetainedLicenseResult ReleaseDetainedLicenseResult()
        {

            if (!IsDetainedLicense(this.LicenseID))
                return enReleaseDetainedLicenseResult.enIsNotDaitianedLicense;
            return enReleaseDetainedLicenseResult.Allowed;
        }
        public bool Release()
        {
            clsLicense License = clsLicense.Find(this.LicenseID);
            if (License == null)return false;
            clsDriver Driver = clsDriver.Find(License.DriverID);
            if (Driver == null) return false;
            clsApplication Application = new clsApplication(Driver.PersonID, clsApplicationType.enApplicationType.enReleaseDetainedLicsense);
            if (!Application.Save()) return false;
            this.ReleaseApplicationID = Application.ApplicationID;
            return clsDetainedLicensesDataAccess.ReleaseDetainedLicense(DetainID , ReleaseDate , ReleasedByUserID , ReleaseApplicationID);
        }
        public static DataTable GetListDetainedLicenses()
        {
            return clsDetainedLicensesDataAccess.GetListDetainedLicenses();
        }
        public static DataTable GetListDetainedLicenses(bool IsReleased)
        {
            return clsDetainedLicensesDataAccess.GetListDetainedLicenses(IsReleased);
        }
        public static DataTable GetListDetainedLicenses(string ColumnName , string Value)
        {
            return clsDetainedLicensesDataAccess.GetListDetainedLicenses(ColumnName , Value);
        }
        public static DataTable GetListDetainedLicensesByDetainID(int DetainID)
        {
            return clsDetainedLicensesDataAccess.GetListDetainedLicensesByDetainID(DetainID);
        }
        public static DataTable GetListDetainedLicensesByReleaseApplicationID( int ReleaseApplicationID)
        {
            return clsDetainedLicensesDataAccess.GetListDetainedLicensesByReleaseApplicationID(ReleaseApplicationID);
        }
    }
}
