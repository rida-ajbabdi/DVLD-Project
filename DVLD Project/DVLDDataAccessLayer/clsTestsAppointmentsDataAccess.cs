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
    public class clsTestsAppointmentsDataAccess
    {
        
        public static DataTable GetTestAppointmentsList(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM TestAppointments
                            WHERE LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID AND TestTypeID =@TestTypeID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            DataTable ListTestAppointments = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListTestAppointments.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListTestAppointments;
        }
        static public bool IsExist(int LocalDrivingLicenseApplicationID, int TestTypeID , bool IsLocked = false)
        {
            string Query = @"SELECT 1 WHERE EXISTS( SELECT TOP 1 1 FROM TestAppointments
                    WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = @IsLocked) ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);
            bool IsFound = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result !=null)
                {
                    IsFound = true;
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
        static public bool IsExist(int TestAppointmentID)
        {
            string Query = @"SELECT 1 WHERE EXISTS( SELECT TOP 1 1 FROM TestAppointments
                    WHERE TestAppointmentID = @TestAppointmentID) ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    IsFound = true;
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
        static public bool FindLastTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, ref int TestAppointmentID, ref DateTime AppointmentDate, ref decimal PaidFees
             , ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 * FROM TestAppointments
                            WHERE LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID AND TestTypeID =@TestTypeID 
                            ORDER BY AppointmentDate DESC;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];
                    if (Reader["RetakeTestApplicationID"] ==DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];
                    IsFound = true;
                }
                Reader.Close();
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
        static public bool Find(int TestAppointmentID , ref int LocalDrivingLicenseApplicationID,ref int TestTypeID, ref DateTime AppointmentDate, ref decimal PaidFees
             , ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM TestAppointments
                            WHERE TestAppointmentID =@TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    TestTypeID = (int)Reader["TestTypeID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];
                    if (Reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];
                    IsFound = true;
                }
                Reader.Close();
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
        static public bool AddNew(ref int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID , bool IsLocked , int RetakeTestApplicationID)
        {
            string Query = @"
                INSERT INTO TestAppointments
                (TestTypeID ,LocalDrivingLicenseApplicationID, AppointmentDate , PaidFees , CreatedByUserID ,
                 IsLocked , RetakeTestApplicationID)
                VALUES
                    (@TestTypeID ,@LocalDrivingLicenseApplicationID, @AppointmentDate , @PaidFees , @CreatedByUserID ,
                 @IsLocked , @RetakeTestApplicationID);
                SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if(RetakeTestApplicationID !=-1)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            try
                {
                    Connection.Open();
                    object Result = Command.ExecuteScalar();
                    if (Result != null && int.TryParse(Result.ToString(), out TestAppointmentID))
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

        static public bool Update(int TestAppointmentID , int TestTypeID , int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID,
                            bool IsLocked, int RetakeTestApplicationID)
        {
            string Query = @"
                UPDATE TestAppointments
                SET 
                    TestTypeID = @TestTypeID,
                    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                    AppointmentDate = @AppointmentDate,
                    PaidFees = @PaidFees,
                    CreatedByUserID = @CreatedByUserID,
                    IsLocked = @IsLocked,
                    RetakeTestApplicationID = @RetakeTestApplicationID
                WHERE TestAppointmentID = @TestAppointmentID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID != -1)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
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
        static public bool LockTestAppointment(int TestAppointmentID)
        {
            string Query = @"
                UPDATE TestAppointments
                SET 
                    IsLocked = @IsLocked
                WHERE TestAppointmentID = @TestAppointmentID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@IsLocked", true);
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
