using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusinessLayer.clsPerson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLDBusinessLayer
{
    public class clsDriver
    {
        public int DriverID {  get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        private enMode Mode;
        public DateTime CreatedDate { get; set; }
        public enum enMode { Add , Update}
        public clsDriver ()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            this.Mode = enMode.Add;
        }
        private clsDriver(int DriverID,int PersonID ,int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID= DriverID;
            this.PersonID= PersonID;
            this.CreatedDate= CreatedDate;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Update;
        }
        public static DataTable GetDriversList()
        {
            return DVLDDataAccessLayer.clsDriversDataAccess.GetDriversList();
        }
        public static DataTable GetFilteredDriversList(string ColumnName, string Value)
        {
            return DVLDDataAccessLayer.clsDriversDataAccess.GetFilteredDriversList(ColumnName, Value);
        }
        public static DataTable GetFilteredDriversListByDriverID(int DriverID)
        {
            return DVLDDataAccessLayer.clsDriversDataAccess.GetFilteredDriversListByDriverID(DriverID);
        }
        public static DataTable GetFilteredDriversListByPersonID(int PersonID)
        {
            return DVLDDataAccessLayer.clsDriversDataAccess.GetFilteredDriversListByPersonID(PersonID);
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        int DriverID = -1;
                        if (clsDriversDataAccess.AddNew(ref DriverID, PersonID, CreatedByUserID, CreatedDate))
                        {
                            this.DriverID = DriverID;
                            this.Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        return clsDriversDataAccess.Update(DriverID, PersonID, CreatedByUserID, CreatedDate);
                    }
                default: return false;
            }
        }
        public static bool IsExist(int PersonID)
        {
            return clsDriversDataAccess.IsExistDriver(PersonID);
        }
        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            if (DVLDDataAccessLayer.clsDriversDataAccess.FindDriverByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                clsDriver Driver = new clsDriver( DriverID, PersonID,  CreatedByUserID,  CreatedDate);
                return Driver;
            }
            return null;
        }
        public static clsDriver Find(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            if (DVLDDataAccessLayer.clsDriversDataAccess.FindDriverByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                clsDriver Driver = new clsDriver(DriverID , PersonID, CreatedByUserID, CreatedDate);
                return Driver;
            }
            return null;
        }
    }

}
