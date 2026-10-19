using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace DVLDBusinessLayer
{
    public class clsTest
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        
        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes,int CreatedByUserID)
        { 
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }
        public clsTest()
        {
            this.TestID =-1;
            this.TestAppointmentID =-1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
        }
        public static clsTestType.enTestType GetNextTest(int PassedTest)
        {
            switch (PassedTest)
            {
                case 0:
                    {
                        return clsTestType.enTestType.enVisionTest;
                    }
                case 1:
                    {
                        return clsTestType.enTestType.enWritingTest;
                    }
                case 2:
                    {
                        return clsTestType.enTestType.enStreetTest;
                    }
                default:
                    return clsTestType.enTestType.enNone;
            }
        }
        public static clsTest Find(int TestAppointmentID)
        {
            int TestID = -1, CreatedByUserID = -1;
            bool TestResult = false;
            string Notes = "";
            if (DVLDDataAccessLayer.clsTestsDataAccess.Find(TestAppointmentID, ref TestID, ref TestResult , ref Notes , ref CreatedByUserID ))
            {
                clsTest TestAppointment = new clsTest( TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
                return TestAppointment;
            }
            return null;
        }
        public bool AddNew()
        {
            int TestID = -1;
            CreatedByUserID = clsDVLDBusinessSettings.CurrentUser.ID;
            if(clsTestAppointement.Lock(TestAppointmentID))
            {
                if (clsTestsDataAccess.AddNew(ref TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID))
                {
                    this.TestID = TestID;
                    return true;
                }
            }
            return false;
        }

    }
    
}
