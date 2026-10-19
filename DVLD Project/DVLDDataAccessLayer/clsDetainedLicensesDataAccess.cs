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
    public class clsDetainedLicensesDataAccess
    {
        public static bool FindLastDetainedLicense(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 *
                             FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID
                             Order By DetainDate DESC";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    DetainID = (int)Reader["DetainID"];
                    ReleasedByUserID = (Reader["ReleasedByUserID"] != DBNull.Value) ? (int)(Reader["ReleasedByUserID"]) : -1;
                    ReleaseApplicationID = (Reader["ReleaseApplicationID"]!=DBNull.Value)? (int)(Reader["ReleaseApplicationID"]): -1;
                    ReleaseDate = (Reader["ReleaseDate"] != DBNull.Value) ? (DateTime)(Reader["ReleaseDate"]) : DateTime.MinValue;
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    IsReleased = (bool)Reader["IsReleased"];
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
        static public bool AddNew(ref int DetainID , int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            string Query = @"
                INSERT INTO DetainedLicenses
                ( LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                VALUES
                    (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
                SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if(ReleaseDate == DateTime.MinValue)
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            if (ReleasedByUserID != -1)
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            if (ReleaseApplicationID != -1)
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out DetainID))
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
        public static bool ReleaseDetainedLicense(int DetainID , DateTime ReleaseDate, int ReleasedByUserID , int ReleaseApplicationID)
        {
            string Query =
                @"UPDATE DetainedLicenses
                  SET 
                  ReleaseDate = @ReleaseDate ,
                  ReleasedByUserID = @ReleasedByUserID ,
                  ReleaseApplicationID = @ReleaseApplicationID,
                  IsReleased = 1
                  WHERE DetainID = @DetainID ;";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
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
        public static DataTable GetListDetainedLicenses()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses_View";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ListDetainedLicenses = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDetainedLicenses.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDetainedLicenses;
        }
        public static DataTable GetListDetainedLicenses(string ColumnName , string Value)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = $@"SELECT * FROM DetainedLicenses_View
                            WHERE {ColumnName} Like @Value;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Value", Value + '%');
            DataTable ListDetainedLicenses = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDetainedLicenses.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDetainedLicenses;
        }
        public static DataTable GetListDetainedLicenses(bool IsReleased)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses_View
                            WHERE IsReleased = @IsReleased;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@IsReleased" , IsReleased);
            DataTable ListDetainedLicenses = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDetainedLicenses.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDetainedLicenses;
        }
        public static DataTable GetListDetainedLicensesByDetainID(int DetainID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses_View
                            WHERE DetainID = @DetainID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
            DataTable ListDetainedLicenses = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDetainedLicenses.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDetainedLicenses;
        }
        public static DataTable GetListDetainedLicensesByReleaseApplicationID(int ReleaseApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses_View
                            WHERE ReleaseApplicationID = @ReleaseApplicationID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            DataTable ListDetainedLicenses = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDetainedLicenses.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDetainedLicenses;
        }
    }
}
