using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDDataAccessLayer;
using System.IO;
using System.Web.SessionState;
namespace DVLDBusinessLayer
{
    public class 
        clsPerson
    {
        public enum enGender { Femel = 0  , Male = 1}
        public enum enMode { Add , Update}
        public enMode Mode { get; set; }
        public int ID { get; set; }
        public string NationalNo {get ; set;}
        public string FirstName {get ; set;}
        public string SecondName{get ; set;}
        public string ThirdName {get ; set;}
        public string LastName {get ; set;}
        public DateTime DateOfBirth {get ; set;}
        public enGender Gender {get ; set;}
        public string Address {get ; set;}
        public string Phone {get ; set;}
        public string Email {get ; set;}
        public string Nationality{get ; set;}
        public string ImagePath {get ; set;}
        public string OldImagePath { set; private get; }
        public clsPerson()
        {
            this.ID = -1;
            this.Mode = enMode.Add;
        }
        public clsPerson(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, enGender Gender,
                                             string Address, string Phone, string Email, string Nationality, string ImagePath)
        {
            this.ID = ID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.Nationality = Nationality;
            this.ImagePath = ImagePath;
            this.Mode = enMode.Update;
        }
        public string FullName ()
        {
            return this.FirstName + " " + this.SecondName + " " + this.ThirdName + " " + this.LastName;
        }
        public static DataTable GetPeopleList()
        {
            return DVLDDataAccessLayer.clsPeopleDataAccess.GetPeopleList();
        }
        public static DataTable GetFilteredPeopleList(string ColumnName , string Value)
        {
            return DVLDDataAccessLayer.clsPeopleDataAccess.GetFilteredPeopleList(ColumnName , Value);
        }
        public static DataTable GetFilteredPeopleList(int PersonID)
        {
            return DVLDDataAccessLayer.clsPeopleDataAccess.GetFilteredPeopleList(PersonID);
        }
        public static clsPerson Find(int ID)
        {
            string NationalNo="", FirstName="", SecondName="", ThirdName="", LastName="" , Address="", Phone="", Email="", Nationality="", ImagePath = "";
            byte Gender = 0;
            DateTime DateOfBirth =DateTime.Now;
            if (DVLDDataAccessLayer.clsPeopleDataAccess.FindPerson(ID, ref NationalNo , ref FirstName, ref SecondName , ref ThirdName , ref LastName , ref DateOfBirth ,
                ref Gender , ref Address  , ref Phone , ref Email , ref Nationality , ref ImagePath))
            {
                clsPerson Person = new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                 (enGender)Gender , Address, Phone, Email, Nationality, ImagePath);
                return Person;
            }
            return null;
        }
        public static clsPerson Find(string NationalNo)
        {
            int ID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", Nationality = "", ImagePath = "";
            byte Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            if (DVLDDataAccessLayer.clsPeopleDataAccess.FindPerson(NationalNo, ref ID , ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                ref Gender, ref Address, ref Phone, ref Email, ref Nationality, ref ImagePath))
            {
                clsPerson Person = new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                 (enGender)Gender, Address, Phone, Email, Nationality, ImagePath);
                return Person;
            }
            return null;
        }

        public bool Save()
        {
            string SelectedImagePath = this.ImagePath;
            string NewImagePath = "";
            if (SelectedImagePath != "")
            {
                string Extension = Path.GetExtension(SelectedImagePath);
                Guid guid = Guid.NewGuid();
                NewImagePath = Path.Combine(clsDVLDBusinessSettings.ImagePathFolder , guid.ToString() + Extension);
            }
            switch (this.Mode)
            {
                case enMode.Add:
                {
                    int ID = -1;
                    if(clsPeopleDataAccess.AddNew(ref ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (byte)Gender,
                          Address, Phone, Email, Nationality, NewImagePath))
                    {
                          this.ID = ID;
                          this.Mode = enMode.Update;
                          if (SelectedImagePath != "")
                            {
                                File.Copy(SelectedImagePath, NewImagePath);
                                this.ImagePath = NewImagePath;
                            }
                            
                          return true;
                    }
                    return false;
                }
                case enMode.Update:
                {
                    ImagePath = (SelectedImagePath != "" && SelectedImagePath!=OldImagePath) ? NewImagePath : SelectedImagePath;
                    if (clsPeopleDataAccess.Update(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (byte)Gender,
                          Address, Phone, Email, Nationality, ImagePath))
                    {
                        if (OldImagePath != SelectedImagePath)
                        {
                            if (OldImagePath !="")
                            {
                                File.Delete(OldImagePath);
                                OldImagePath = "";
                            }
                            if (SelectedImagePath != "")
                                File.Copy(SelectedImagePath, NewImagePath);
                        }
                        return true;
                    }
                    return false;
                }
                default: return false;
            }
        }
        public static bool Delete(int ID , string ImagePath = "")
        {
            if( clsPeopleDataAccess.Delete(ID))
            {
                if (ImagePath != "")
                    File.Delete(ImagePath);
                return true;
            }
            return false;
        }
        public static bool IsExist(int PersonID)
        {
            return clsPeopleDataAccess.IsExistPerson(PersonID);
        }
        public static bool IsExist(string NationalNo)
        {
            return clsPeopleDataAccess.IsExistPerson(NationalNo);
        }

    }
}
