using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccessLayer
{
    public class clsApplicationsDataAccess
    {
        public static DataTable GetApplicationsList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Applications";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ListApplications = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListApplications.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListApplications;
        }

        //public static DataTable GetFilteredApplicationsList(bool IsActive)
        //{
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"SELECT ApplicationID , Applications.ApplicationPersonID , FullName = FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName ,  ApplicationDate , IsActive
        //                         FROM Applications
        //                         INNER JOIN People 
        //                         ON Applications.ApplicationPersonID = People.ApplicationPersonID
        //                         WHERE IsActive = @IsActive";

        //    SqlCommand Command = new SqlCommand(Query, Connection);
        //    Command.Parameters.AddWithValue("@IsActive", IsActive);
        //    DataTable ListApplications = new DataTable();
        //    try
        //    {
        //        Connection.Open();
        //        SqlDataReader Reader = Command.ExecuteReader();
        //        if (Reader.HasRows)
        //            ListApplications.Load(Reader);
        //        Reader.Close();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return ListApplications;
        //}
        //public static DataTable GetFilteredApplicationsList(string ColumnName, string Value)
        //{
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = $@"SELECT ApplicationID , Applications.ApplicationPersonID  , FullName = FirstName + SecondName + ThirdName + LastName ,  ApplicationDate , IsActive
        //                         FROM Applications
        //                         INNER JOIN People 
        //                         ON Applications.ApplicationPersonID = People.ApplicationPersonID
        //                         WHERE {ColumnName} LIKE @Value;";
        //    SqlCommand Command = new SqlCommand(Query, Connection);
        //    Command.Parameters.AddWithValue("@Value", Value + '%');
        //    DataTable ListApplications = new DataTable();
        //    try
        //    {
        //        Connection.Open();
        //        SqlDataReader Reader = Command.ExecuteReader();
        //        if (Reader.HasRows)
        //            ListApplications.Load(Reader);
        //        Reader.Close();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return ListApplications;
        //}
        //public static DataTable GetFilteredApplicationsListByApplicationID(int ApplicationID)
        //{
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"SELECT ApplicationID , Applications.ApplicationPersonID  , FullName = FirstName + SecondName + ThirdName + LastName ,  ApplicationDate , IsActive
        //                         FROM Applications
        //                         INNER JOIN People 
        //                         ON Applications.ApplicationPersonID = People.ApplicationPersonID
        //                         WHERE ApplicationID=@ApplicationID;";
        //    SqlCommand Command = new SqlCommand(Query, Connection);
        //    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        //    DataTable ListApplications = new DataTable();
        //    try
        //    {
        //        Connection.Open();
        //        SqlDataReader Reader = Command.ExecuteReader();
        //        if (Reader.HasRows)
        //            ListApplications.Load(Reader);
        //        Reader.Close();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return ListApplications;
        //}
        //public static DataTable GetFilteredApplicationsListByPersonID(int ApplicationPersonID)
        //{
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"SELECT ApplicationID , Applications.ApplicationPersonID , FullName = FirstName + SecondName + ThirdName + LastName ,  ApplicationDate , IsActive
        //                         FROM Applications
        //                         INNER JOIN People 
        //                         ON Applications.ApplicationPersonID = People.ApplicationPersonID
        //                         WHERE Applications.ApplicationPersonID=@ApplicationPersonID;";
        //    SqlCommand Command = new SqlCommand(Query, Connection);
        //    Command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
        //    DataTable ListApplications = new DataTable();
        //    try
        //    {
        //        Connection.Open();
        //        SqlDataReader Reader = Command.ExecuteReader();
        //        if (Reader.HasRows)
        //            ListApplications.Load(Reader);
        //        Reader.Close();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return ListApplications;
        //}
        public static bool FindApplication(int ApplicationID, ref int ApplicationPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus , ref DateTime LastStatusDate , ref decimal PaidFees , ref int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Applications
                                 WHERE ApplicationID = @ApplicationID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicationDate =(DateTime) Reader["ApplicationDate"];
                    ApplicationTypeID =(int) Reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
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
        public static bool FindApplication(int ApplicationPersonID, int ApplicationTypeID,int LicenseClassID, ref int ApplicationID, ref DateTime ApplicationDate, ref int ApplicationStatus
             , ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                                 WHERE ApplicantPersonID = @ApplicantPersonID AND ApplicationTypeID = @ApplicationTypeID AND LicenseClassID=@LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = (int)Reader["ApplicationID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
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
        //public static bool FindApplication(int ApplicationID , string ApplicationTypeID, ref int ApplicationID, ref int ApplicationPersonID, ref bool IsActive)
        //{
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"SELECT ApplicationID , Applications.ApplicationPersonID  , FullName = FirstName + SecondName + ThirdName + LastName ,  ApplicationDate ,ApplicationTypeID, IsActive
        //                         FROM Applications
        //                         INNER JOIN People 
        //                         ON Applications.ApplicationPersonID = People.ApplicationPersonID
        //                         WHERE ApplicationDate = @ApplicationDate AND ApplicationTypeID = @ApplicationTypeID;";
        //    SqlCommand Command = new SqlCommand(Query, Connection);
        //    Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
        //    Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
        //    bool IsFound = false;
        //    try
        //    {
        //        Connection.Open();
        //        SqlDataReader Reader = Command.ExecuteReader();
        //        if (Reader.Read())
        //        {
        //            ApplicationID = (int)Reader["ApplicationID"];
        //            ApplicationPersonID = (int)Reader["ApplicationPersonID"];
        //            IsActive = (bool)Reader["IsActive"];
        //            IsFound = true;
        //            Reader.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        IsFound = false;
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return IsFound;
        //}
        //public static bool IsExistApplication(int ApplicationID)
        //{
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM Applications WHERE ApplicationPersonID = @ApplicationPersonID);";
        //    SqlCommand Command = new SqlCommand(Query, Connection);
        //    Command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationID);
        //    bool IsFound = false;
        //    try
        //    {
        //        Connection.Open();
        //        object Result = Command.ExecuteScalar();
        //        IsFound = (Result != null);
        //    }
        //    catch (Exception e)
        //    {
        //        IsFound = false;
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return IsFound;
        //}

        //public static bool IsExistApplicationByPersonID(int ApplicationPersonID)
        //{
        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM Applications WHERE ApplicationPersonID = @ApplicationPersonID);";
        //    SqlCommand Command = new SqlCommand(Query, Connection);
        //    Command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
        //    bool IsFound = false;
        //    try
        //    {
        //        Connection.Open();
        //        object Result = Command.ExecuteScalar();
        //        IsFound = (Result != null);
        //    }
        //    catch (Exception e)
        //    {
        //        IsFound = false;
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //    return IsFound;
        //}
        static public bool AddNew(ref int ApplicationID, int ApplicationPersonID , DateTime ApplicationDate , int ApplicationTypeID , byte ApplicationStatus
            , DateTime  LastStatusDate , decimal PaidFees , int CreatedByUserID)
        {
            string Query = @"
                INSERT INTO Applications
                (ApplicantPersonID , ApplicationDate , ApplicationTypeID , ApplicationStatus ,
                 LastStatusDate , PaidFees , CreatedByUserID)
                VALUES
                    (@ApplicationPersonID , @ApplicationDate ,  @ApplicationTypeID , @ApplicationStatus ,
                 @LastStatusDate , @PaidFees , @CreatedByUserID);
                SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out ApplicationID))
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
        static public bool Update( int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus
            , DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            string Query = @"
                UPDATE Applications
                SET 
                    ApplicationDate = @ApplicationDate,
                    ApplicationTypeID = @ApplicationTypeID,
                    ApplicationStatus = @ApplicationStatus,
                    LastStatusDate = @LastStatusDate,
                    PaidFees = @PaidFees,
                    CreatedByUserID = @CreatedByUserID
                WHERE ApplicationID = @ApplicationID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
        public static bool Delete(int ApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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



