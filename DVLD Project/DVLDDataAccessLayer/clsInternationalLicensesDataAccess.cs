using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsInternationalLicensesDataAccess
    {
        static public bool AddNew(ref int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            string Query = @"
                INSERT INTO InternationalLicenses
                ( ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                VALUES
                (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out InternationalLicenseID))
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
        public static DataTable GetInternationalLicensesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT InternationalLicenseID , ApplicationID , DriverID , IssuedUsingLocalLicenseID , IssueDate , ExpirationDate , IsActive
                            FROM InternationalLicenses";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable InternationalLicensesList = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    InternationalLicensesList.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return InternationalLicensesList;
        }
        public static DataTable GetInternationalLicensesListByPersonID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT        InternationalLicenseID , ApplicationID , InternationalLicenses.DriverID , IssuedUsingLocalLicenseID , IssueDate , ExpirationDate , IsActive
                             FROM            InternationalLicenses INNER JOIN Drivers 
                             ON Drivers.DriverID = InternationalLicenses.DriverID
						     WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            DataTable DriverInternationalLicensesList = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    DriverInternationalLicensesList.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return DriverInternationalLicensesList;
        }
        public static DataTable GetInternationalLicensesListByID(int InternationalLicenseID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT        InternationalLicenseID , ApplicationID , DriverID , IssuedUsingLocalLicenseID , IssueDate , ExpirationDate , IsActive
                             FROM            InternationalLicenses
						 WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            DataTable DriverInternationalLicensesList = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    DriverInternationalLicensesList.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return DriverInternationalLicensesList;
        }
        public static DataTable GetInternationalLicensesListByDriverID(int DriverID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT     InternationalLicenseID , ApplicationID , DriverID , IssuedUsingLocalLicenseID , IssueDate , ExpirationDate , IsActive
                             FROM   InternationalLicenses  
						 WHERE DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            DataTable DriverInternationalLicensesList = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    DriverInternationalLicensesList.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return DriverInternationalLicensesList;
        }
        public static DataTable GetInternationalLicensesListByStatus(bool IsActive)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT       InternationalLicenseID , ApplicationID , DriverID , IssuedUsingLocalLicenseID , IssueDate , ExpirationDate , IsActive
                             FROM       InternationalLicenses     
						    WHERE IsActive = @IsActive";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            DataTable DriverInternationalLicensesList = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    DriverInternationalLicensesList.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return DriverInternationalLicensesList;
        }
        public static bool FindInternationalLicenseByDriverID( int DriverID, ref int InternationalLicenseID, ref int ApplicationID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT  * FROM   InternationalLicenses WHERE DriverID = @DriverID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    InternationalLicenseID = (int)Reader["InternationalLicenseID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
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
        public static bool FindInternationalLicense(int InternationalLicenseID, ref int DriverID , ref int ApplicationID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT  * FROM   InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
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

    }
}
