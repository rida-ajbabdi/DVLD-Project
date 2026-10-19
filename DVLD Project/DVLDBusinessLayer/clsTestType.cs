using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsTestType
    {
        public enum enTestType { enVisionTest = 1, enWritingTest = 2, enStreetTest = 3, enNone = 4 }
        public enTestType ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        public clsTestType(enTestType ID, string Title, string Description , decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }
        public clsTestType()
        {
            this.ID = enTestType.enNone;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
        }

        public static DataTable GetTestTypesList()
        {
            return DVLDDataAccessLayer.clsTestTypesDataAccess.GetTestTypesList();
        }
        public static clsTestType Find(enTestType ID)
        {
            string Title = "", Description = "";
            decimal Fees = 0;
            if (DVLDDataAccessLayer.clsTestTypesDataAccess.FindTestType((int)ID, ref Title,ref Description , ref Fees))
            {
                clsTestType TestType = new clsTestType(ID, Title,Description, Fees);
                return TestType;
            }
            return null;
        }
        public bool Save()
        {
            return clsTestTypesDataAccess.Update((int)ID, Title,Description, Fees);
        }

    }
}
