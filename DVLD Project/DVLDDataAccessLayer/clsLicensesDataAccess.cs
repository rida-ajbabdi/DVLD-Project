using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccessLayer
{
    public class clsLicensesDataAccess
    {
        static public bool AddNew(ref int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive,
             int IssueReason, int CreatedByUserID)
        {
            string Query = @"
                INSERT INTO Licenses
                ( ApplicationID,  DriverID,  LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
              IssueReason, CreatedByUserID)
                VALUES
                    (@ApplicationID,  @DriverID,  @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive,
              @IssueReason, @CreatedByUserID);
                SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out LicenseID))
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

        public static bool IsExistLicense(int ApplicationID ,int LicenseClassID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM Licenses WHERE ApplicationID=@ApplicationID AND LicenseClass=@LicenseClass);";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                IsFound = Result != null;
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
        public static DataTable GetDriverLicensesListByPersonID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT        Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                             FROM            Drivers INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
						 WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            DataTable ListDriverLicenses = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDriverLicenses.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDriverLicenses;
        }
        public static DataTable GetDriverLicensesListByDriverID(int DriverID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT        Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                             FROM            Drivers INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
						 WHERE Licenses.DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            DataTable ListDriverLicenses = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDriverLicenses.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDriverLicenses;
        }
        public static bool FindLicenseByApplicationID(int ApplicationID , ref int LicenseID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref int IssueReason, ref int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT  * FROM   Licenses WHERE ApplicationID = @ApplicationID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    LicenseID = (int)Reader["LicenseID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClass = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = Reader["Notes"].ToString();
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
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
        public static bool FindLicense( int LicenseID , ref int ApplicationID , ref int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref int IssueReason, ref int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT  * FROM   Licenses WHERE LicenseID = @LicenseID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClass = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = Reader["Notes"].ToString();
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
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

        public static bool DisactivateLicense(int LicenseClassID, int DriverID , bool ExpiredLicenseOnly = false)
        {
            string Query = (ExpiredLicenseOnly) ?
                @"UPDATE Licenses
                SET 
                    IsActive = 0
                WHERE LicenseClass = @LicenseClass AND DriverID =@DriverID AND ExpirationDate < GETDATE();"
                :
                @"UPDATE Licenses
                SET 
                    IsActive = 0
                WHERE LicenseClass = @LicenseClass AND DriverID =@DriverID ;";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
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
    }
}
