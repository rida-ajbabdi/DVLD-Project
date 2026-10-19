using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsLicenseClasse
    {
        public int LisenceClassID {  get; set; }
        public string LisenceClassName { get; set; }
        public string LisenceClassDescription { get; set; }
        public byte MinimumAllwedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }
        clsLicenseClasse(int LicenseClassID, string LisenceClassName , string LisenceClassDescription , byte MinimumAllwedAge, byte DefaultValidityLength , decimal ClassFees)
        {
            this.LisenceClassID = LicenseClassID;
            this.LisenceClassName = LisenceClassName;
            this.LisenceClassDescription = LisenceClassDescription;
            this.MinimumAllwedAge = MinimumAllwedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }
        public static DataTable GetLicenseClassesList()
        {
            return DVLDDataAccessLayer.clsLicenseClassesDataAccess.GetLicenseClassesList();
        }
        public static clsLicenseClasse Find(int LicenseClassID)
        {
            string LisenceClassName = "", LisenceClassDescription = "";
            byte MinimumAllwedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = 0;
            if (clsLicenseClassesDataAccess.Find(LicenseClassID, ref LisenceClassName ,ref LisenceClassDescription , ref MinimumAllwedAge, ref DefaultValidityLength ,ref ClassFees))
            {
                clsLicenseClasse LicenseClasse = new clsLicenseClasse(LicenseClassID , LisenceClassName, LisenceClassDescription , MinimumAllwedAge , DefaultValidityLength , ClassFees);
                return LicenseClasse;
            }
            return null;
        }
    }
}
