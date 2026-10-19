using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsUsersDataAccess
    {
        public static DataTable GetUsersList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT UserID , Users.PersonID , FullName = FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName ,  UserName , IsActive
                             FROM Users
                             INNER JOIN People 
                             ON Users.PersonID = People.PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ListUsers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListUsers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListUsers;
        }
        public static DataTable GetFilteredUsersList(bool IsActive)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT UserID , Users.PersonID , FullName = FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName ,  UserName , IsActive
                             FROM Users
                             INNER JOIN People 
                             ON Users.PersonID = People.PersonID
                             WHERE IsActive = @IsActive";
            
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            DataTable ListUsers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListUsers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListUsers;
        }
        public static DataTable GetFilteredUsersList(string ColumnName, string Value)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = $@"SELECT UserID , Users.PersonID  , FullName = FirstName + SecondName + ThirdName + LastName ,  UserName , IsActive
                             FROM Users
                             INNER JOIN People 
                             ON Users.PersonID = People.PersonID
                             WHERE {ColumnName} LIKE @Value;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Value", Value + '%');
            DataTable ListUsers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListUsers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListUsers;
        }
        public static DataTable GetFilteredUsersListByUserID(int UserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT UserID , Users.PersonID  , FullName = FirstName + SecondName + ThirdName + LastName ,  UserName , IsActive
                             FROM Users
                             INNER JOIN People 
                             ON Users.PersonID = People.PersonID
                             WHERE UserID=@UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            DataTable ListUsers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListUsers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListUsers;
        }
        public static DataTable GetFilteredUsersListByPersonID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT UserID , Users.PersonID , FullName = FirstName + SecondName + ThirdName + LastName ,  UserName , IsActive
                             FROM Users
                             INNER JOIN People 
                             ON Users.PersonID = People.PersonID
                             WHERE Users.PersonID=@PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            DataTable ListUsers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListUsers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListUsers;
        }
        public static bool FindUser(int UserID, ref int PersonID, ref string UserName, ref string HashedPassword, ref string Salt, ref bool IsActive)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT UserID , Users.PersonID  , UserName ,HashedPassword , Salt , IsActive
                             FROM Users
                             WHERE UserID = @UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    UserID = (int)Reader["PersonID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = Reader["UserName"].ToString();
                    HashedPassword = Reader["HashedPassword"].ToString();
                    Salt = Reader["Salt"].ToString();
                    IsActive = (bool)Reader["IsActive"];
                    IsFound = true;
                    Reader.Close();
                }
            }
            catch (Exception e)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        public static bool FindUser(string UserName, ref int UserID , ref int PersonID,  ref string HashedPassword, ref string Salt , ref bool IsActive)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT UserID , Users.PersonID  , UserName , HashedPassword , Salt , IsActive
                             FROM Users
                             WHERE UserName = @UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    HashedPassword = Reader["HashedPassword"].ToString();
                    Salt = Reader["Salt"].ToString();
                    IsActive = (bool)Reader["IsActive"];
                    IsFound = true;
                    Reader.Close();
                }
            }
            catch (Exception e)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        public static bool IsExistUser(int UserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM Users WHERE PersonID = @PersonID);";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", UserID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                IsFound = (Result != null);
            }
            catch (Exception e)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        
        public static bool IsExistUserByPersonID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM Users WHERE PersonID = @PersonID);";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                IsFound = (Result != null);
            }
            catch (Exception e)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        static public bool AddNew(ref int UserID, int PersonID, string UserName, string HashedPassword, string Salt , bool IsActive)
        {
            string Query = @"
            INSERT INTO Users
            (PersonID, UserName, HashedPassword , Salt , IsActive)
            VALUES
                (@PersonID, @UserName, @HashedPassword, @Salt , @IsActive);
            SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@HashedPassword", HashedPassword);
            Command.Parameters.AddWithValue("@Salt", Salt);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out UserID))
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                return false;
            }
            finally
            {
                Connection.Close();

            }
        }
        static public bool Update(int UserID, int PersonID, string UserName, string HashedPassword, string Salt, bool IsActive)
        {
            string Query = @"
            UPDATE Users
            SET 
                PersonID = @PersonID,
                UserName = @UserName,
                HashedPassword = @HashedPassword,
                Salt = @Salt,
                IsActive = @IsActive
            WHERE UserID = @UserID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@HashedPassword", HashedPassword);
            Command.Parameters.AddWithValue("@Salt", Salt);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                Connection.Open();
                int RowAffected = Command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Delete(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Users WHERE UserID = @UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", ID);
            bool IsDeleted = false;
            try
            {
                Connection.Open();
                int RowAffected = Command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    IsDeleted = true;
                }
            }
            catch (Exception e)
            {
                IsDeleted = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsDeleted;
        }
    }
}
