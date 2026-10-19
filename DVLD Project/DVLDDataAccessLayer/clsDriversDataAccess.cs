using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsDriversDataAccess
    {
        static public bool AddNew(ref int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            string Query = @"
            INSERT INTO Drivers
            (PersonID,CreatedByUserID ,CreatedDate)
            VALUES
                (@PersonID,@CreatedByUserID,@CreatedDate);
            SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out DriverID))
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
        public static DataTable GetDriversList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers_View";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ListDrivers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDrivers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDrivers;
        }
        public static DataTable GetFilteredDriversList(string ColumnName, string Value)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = $@"SELECT * FROM Drivers_View
                             WHERE {ColumnName} LIKE @Value;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Value", Value + '%');
            DataTable ListDrivers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDrivers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDrivers;
        }
        public static DataTable GetFilteredDriversListByDriverID(int DriverID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers_View
                             WHERE DriverID=@DriverID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            DataTable ListDrivers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDrivers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDrivers;
        }
        public static DataTable GetFilteredDriversListByPersonID(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers_View
                             WHERE PersonID=@PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            DataTable ListDrivers = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListDrivers.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListDrivers;
        }
        static public bool Update(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            string Query = @"
            UPDATE Drivers
            SET 
                PersonID = @PersonID,
                CreatedByUserID = @CreatedByUserID,
                CreatedDate = @CreatedDate,
            WHERE DriverID = @DriverID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
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
        public static bool IsExistDriver(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM Drivers WHERE PersonID = @PersonID);";
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
        public static bool FindDriverByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers WHERE PersonID = @PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    DriverID =(int) Reader["DriverID"];
                    CreatedByUserID = (int) Reader["CreatedByUserID"];
                    CreatedDate =(DateTime) Reader["CreatedDate"];
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

        public static bool FindDriverByNationalNo(string NationalNo, ref int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Drivers.*
                             FROM Drivers INNER JOIN  People ON Drivers.PersonID = People.PersonID
                             WHERE NationalNo = @NationalNo;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    DriverID = (int)Reader["DriverID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];
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
        public static bool FindDriverByDriverID(int DriverID, ref int PersonID , ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers WHERE DriverID = @DriverID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    PersonID = (int)Reader["PersonID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];
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
