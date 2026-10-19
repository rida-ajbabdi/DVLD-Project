using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsUser
    {
        public enum enMode { Add, Update }
        public enMode Mode { get; set; }
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string HasehedPassword { get; private set; }
        public string Salt { get; private set; }
        public bool IsActive { get; set; }
        
        public void SetPassword(string Password)
        {
            Salt = clsHash.GenerateSalt();
            HasehedPassword = clsHash.ComputeHash(Password, Salt);
        }
        public clsUser()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.Salt = clsHash.GenerateSalt();
            this.Mode = enMode.Add;
        }
        public clsUser(int ID, int PersonID, string UserName, string PasswordHash , string Salt , bool IsActive)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.HasehedPassword = PasswordHash;
            this.Salt = Salt;
            this.IsActive = IsActive;
            this.Mode = enMode.Update;
        }
        public static DataTable GetUsersList()
        {
            return DVLDDataAccessLayer.clsUsersDataAccess.GetUsersList();
        }
        public static DataTable GetFilteredUsersList(string ColumnName, string Value)
        {
            return DVLDDataAccessLayer.clsUsersDataAccess.GetFilteredUsersList(ColumnName, Value);
        }
        public static DataTable GetFilteredUsersListByUserID(int UserID)
        {
            return DVLDDataAccessLayer.clsUsersDataAccess.GetFilteredUsersListByUserID(UserID);
        }
        public static DataTable GetFilteredUsersList(bool IsActive)
        {
            return DVLDDataAccessLayer.clsUsersDataAccess.GetFilteredUsersList(IsActive);
        }
        public static DataTable GetFilteredUsersListByPersonID(int PersonID)
        {
            return DVLDDataAccessLayer.clsUsersDataAccess.GetFilteredUsersListByPersonID(PersonID);
        }
        public static clsUser Find(int ID)
        {
            string UserName = "", HasehedPassword = "", Salt = "";
            int PersonID = -1;
            bool IsActive = false;
            if (DVLDDataAccessLayer.clsUsersDataAccess.FindUser(ID , ref PersonID , ref UserName, ref HasehedPassword , ref Salt, ref IsActive))
            {
                clsUser User = new clsUser(ID, PersonID, UserName, HasehedPassword , Salt, IsActive);
                return User;
            }
            return null;
        }
        public static clsUser Find(string UserName , string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;
            string HashedPassword = "", Salt = "";
            if (DVLDDataAccessLayer.clsUsersDataAccess.FindUser( UserName, ref UserID , ref PersonID , ref HashedPassword, ref Salt, ref IsActive))
            {
                if (clsHash.IsPasswordCurrect(HashedPassword, Password, Salt))
                {
                    clsUser User = new clsUser(UserID, PersonID, UserName, HashedPassword, Salt, IsActive);
                    return User;
                }
            }
            return null;
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        int ID = -1;
                        if (!clsUser.IsExistByPersonID(PersonID))
                        {
                            if (clsUsersDataAccess.AddNew(ref ID, PersonID, UserName, HasehedPassword, Salt, IsActive))
                            {
                                this.ID = ID;
                                this.Mode = enMode.Update;
                                return true;
                            }
                            return false;
                        }
                        return false;
                    }
                case enMode.Update:
                    {
                        return clsUsersDataAccess.Update(ID, PersonID, UserName, HasehedPassword , Salt, IsActive);
       
                    }
                default: return false;
            }
        }
        public static bool Delete(int ID)
        {
            return clsUsersDataAccess.Delete(ID);    
        }
        public static bool IsExist(int ID)
        {
            return clsUsersDataAccess.IsExistUser(ID);
        }
        public static bool IsExistByPersonID(int PersonID)
        {
            return clsUsersDataAccess.IsExistUserByPersonID(PersonID);
        }
        public bool IsValidatePassword(string Password)
        {
            return clsHash.IsPasswordCurrect(HasehedPassword, Password, Salt);
        }
    }
}
