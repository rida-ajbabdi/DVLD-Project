using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsApplicationType
    {
        public enum enApplicationType {enNone , enNewLocalLicense , enRenewLicsense, enReplacementForLostLicsense, enReplacementForDamagedLicsense, enReleaseDetainedLicsense , enNewInternationalLicense , enRetakeTest}
        public enApplicationType ID {  get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        public clsApplicationType(enApplicationType ID , string Title, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }
        public clsApplicationType()
        {
            this.ID = enApplicationType.enNone;
            this.Title = "";
            this.Fees = 0;
        }

        public static DataTable GetApplicationTypesList()
        {
            return DVLDDataAccessLayer.clsApplicationTypesDataAccess.GetApplicationTypesList();
        }
        public static clsApplicationType Find(enApplicationType ID)
        {
            string Title = "";
            decimal Fees = 0;
            if (DVLDDataAccessLayer.clsApplicationTypesDataAccess.FindApplicationType( (int)ID , ref Title , ref Fees))
            {
                clsApplicationType ApplicationType = new clsApplicationType(ID, Title, Fees);
                return ApplicationType;
            }
            return null;
        }
        public bool Save()
        {
            return clsApplicationTypesDataAccess.Update((int)ID, Title, Fees);
        }
    }
}
