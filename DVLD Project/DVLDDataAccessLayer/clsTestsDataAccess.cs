using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace DVLDDataAccessLayer
{
    public class clsTestsDataAccess
    {
        public static bool Find(int TestAppointmentID, ref int TestID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    TestID = (int)Reader["TestID"];
                    TestResult = (bool)Reader["TestResult"];
                    Notes = Reader["Notes"].ToString();
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

        public static bool AddNew(ref int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            string Query = @"
                INSERT INTO Tests
                (TestAppointmentID ,TestResult, Notes , CreatedByUserID )
                VALUES
                    (@TestAppointmentID ,@TestResult, @Notes , @CreatedByUserID);
                SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out TestID))
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
        public static DateTime LastTestDateOrDefault(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 AppointmentDate FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID AND TestTypeID =@TestTypeID 
                            ORDER BY AppointmentDate DESC;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            DateTime LastTestAppointmentDate = DateTime.Now;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    LastTestAppointmentDate = (DateTime)Result;
                }
            }
            catch (Exception e)
            {
                LastTestAppointmentDate = DateTime.Now;
            }
            finally
            {
                Connection.Close();
            }
            return LastTestAppointmentDate;
        }
    }
    }

