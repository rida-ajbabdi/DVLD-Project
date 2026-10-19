using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsDataAccess
    {
        public static DataTable GetLocalDrivingLicenseApplicationsList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM LocalDrivingLicenseApplications_View";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable LocalDrivingLicenseApplicationsList = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    LocalDrivingLicenseApplicationsList.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return LocalDrivingLicenseApplicationsList;
        }
        ////
        /// 
        /// 
        /// 
        /// 
        public static DataTable GetFilteredLocalDrivingLisenceApplicationsList(string ColumnName, string Value)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = $@"SELECT * FROM LocalDrivingLicenseApplications_View
                             WHERE {ColumnName} LIKE @Value;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Value", Value + '%');
            DataTable ListLocalDrivingLisenceApplications = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListLocalDrivingLisenceApplications.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListLocalDrivingLisenceApplications;
        }
        
        public static DataTable GetFilteredLocalDrivingLisenceApplicationsList(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM LocalDrivingLicenseApplications_View
                             WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            DataTable ListLocalDrivingLisenceApplications = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListLocalDrivingLisenceApplications.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListLocalDrivingLisenceApplications;
        }
        public static DataTable GetFilteredLocalDrivingLisenceApplicationsList(byte Status)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM LocalDrivingLicenseApplications_View
                             WHERE Status=@Status;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Status", Status);
            DataTable ListLocalDrivingLisenceApplications = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListLocalDrivingLisenceApplications.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListLocalDrivingLisenceApplications;
        }
        /// 
        /// 

        ///
        static public bool AddNew(ref int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            string Query = @"
                INSERT INTO LocalDrivingLicenseApplications
                ( ApplicationID , LicenseClassID )
                VALUES
                    (@ApplicationID, @LicenseClassID);
                SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out LocalDrivingLicenseApplicationID))
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
        static public bool Update(int LocalDrivingLicenseApplicationID, int LicenseClassID)
        {
            string Query = @"
            UPDATE LocalDrivingLicenseApplications
            SET 
                LicenseClassID = @LicenseClassID
            WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
        static public bool Find(int ApplicationPersonID, int LicenseClassID, int ApplicationStatus, ref int LocalDrivingLicenseApplicationID, ref int ApplicationID)
        {
            string Query = @"SELECT Top 1 * FROM LocalDrivingLicenseFullApplications_View 
                        WHERE ApplicantPersonID = @ApplicantPersonID AND LicenseClassID = @LicenseClassID AND ApplicationStatus = @ApplicationStatus;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)Reader["LocalDrivingLicenseApplicatonID"];
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
        static public bool Find(int ApplicationPersonID, int LicenseClassID, ref int LocalDrivingLicenseApplicationID, ref int ApplicationID , ref int ApplicationStatus)
        {
            string Query = @"SELECT Top 1 * FROM LocalDrivingLicenseFullApplications_View 
                        WHERE ApplicantPersonID = @ApplicantPersonID AND LicenseClassID = @LicenseClassID;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)Reader["LocalDrivingLicenseApplicatonID"];
                    ApplicationStatus = (int)Reader["ApplicationStatus"];
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
        static public bool Find(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            string Query = @"SELECT Top 1 * FROM LocalDrivingLicenseFullApplications_View 
                        WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
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
        static public sbyte PassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            string Query = @"SELECT PassedTestCount FROM LocalDrivingLicenseApplications_View 
                        WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            sbyte PassedTestCount = 0;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && sbyte.TryParse(Result.ToString(), out PassedTestCount))
                {
                    return PassedTestCount;
                }
            }
            catch (Exception e)
            {
                PassedTestCount = 0;
            }
            finally
            {
                Connection.Close();
            }
            return PassedTestCount;
        }
        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
