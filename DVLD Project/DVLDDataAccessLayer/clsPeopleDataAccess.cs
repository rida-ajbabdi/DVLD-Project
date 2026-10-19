using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static DataTable GetPeopleList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string Query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName AS Nationality , ImagePath
                             FROM People
                             INNER JOIN Countries 
                             ON People.NationalityCountryID = Countries.CountryID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ListPeople = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.HasRows)
                    ListPeople.Load(Reader);
                Reader.Close();
            }
            catch(Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListPeople;
        }
        public static DataTable GetFilteredPeopleList(string ColumnName , string Value)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = $@"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName AS Nationality
                             FROM People
                             INNER JOIN Countries 
                             ON People.NationalityCountryID = Countries.CountryID
                             WHERE {ColumnName} LIKE @Value;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Value", Value + '%');
            DataTable ListPeople = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListPeople.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListPeople;
        }
        public static DataTable GetFilteredPeopleList(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName AS Nationality
                             FROM People
                             INNER JOIN Countries 
                             ON People.NationalityCountryID = Countries.CountryID
                             WHERE PersonID=@Value;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Value" , PersonID);
            DataTable ListPeople = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ListPeople.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ListPeople;
        }
        public static bool FindPerson(int ID , ref string NationalNo, ref string FirstName , ref string SecondName , ref string ThirdName , ref string LastName , ref DateTime DateOfBirth , ref byte Gender ,
                                            ref string Address , ref string Phone , ref string Email , ref string Nationality , ref string ImagePath)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName AS Nationality , ImagePath
                             FROM People
                             INNER JOIN Countries 
                             ON People.NationalityCountryID = Countries.CountryID
                             WHERE PersonID = @PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", ID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ID = (int)Reader["PersonID"];
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gendor"];
                    Address = Reader["Address"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Email = Reader["Email"].ToString();
                    Nationality = Reader["Nationality"].ToString();
                    ImagePath = Reader["ImagePath"].ToString();
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
        public static bool FindPerson( string NationalNo , ref int ID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender,
                                            ref string Address, ref string Phone, ref string Email, ref string Nationality, ref string ImagePath)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, CountryName AS Nationality , ImagePath
                             FROM People
                             INNER JOIN Countries 
                             ON People.NationalityCountryID = Countries.CountryID
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
                    ID = (int)Reader["PersonID"];
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gendor"];
                    Address = Reader["Address"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Email = Reader["Email"].ToString();
                    Nationality = Reader["Nationality"].ToString();
                    ImagePath = Reader["ImagePath"].ToString();
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
        public static bool IsExistPerson(string NationalNo)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM People WHERE NationalNo = @NationalNo);";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
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
        public static bool IsExistPerson(int PersonID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM People WHERE PersonID = @PersonID);";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteNonQuery();
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
        static public bool AddNew(ref int ID , string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
                                             string Address, string Phone, string Email, string Nationality, string ImagePath)
        {
            string Query = @"
            INSERT INTO People
            (NationalNo,FirstName ,SecondName ,ThirdName ,LastName , DateOfBirth ,Gendor ,Address ,Phone ,
            Email , NationalityCountryID ,ImagePath)
            VALUES
                (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address
		        ,@Phone,@Email, (SELECT CountryID FROM Countries WHERE CountryName = @CountryName),@ImagePath);
            SELECT SCOPE_IDENTITY() ; ";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@CountryName", Nationality);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if(Result != null && int.TryParse(Result.ToString() , out ID))
                {
                    return true;
                }
                return false;
            }
            catch(Exception e) {

                return false;
            }
            finally
            {
                Connection.Close();
                
            }
        }
        static public bool Update(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender,
                                     string Address, string Phone, string Email, string Nationality, string ImagePath)
        {
            string Query = @"
            UPDATE People
            SET 
                NationalNo = @NationalNo,
                FirstName = @FirstName,
                SecondName = @SecondName,
                ThirdName = @ThirdName,
                LastName = @LastName,
                DateOfBirth = @DateOfBirth,
                Gendor = @Gendor,
                Address = @Address,
                Phone = @Phone,
                Email = @Email,
                NationalityCountryID =(SELECT CountryID FROM Countries WHERE CountryName = @CountryName)  ,
                ImagePath = @ImagePath
            WHERE PersonID = @ID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@CountryName", Nationality);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
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

            string Query = @"DELETE FROM People WHERE PersonID = @PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", ID);
            bool IsDeleted = false;
            try
            {
                Connection.Open();
                int RowAffected = Command.ExecuteNonQuery();
                if (RowAffected >0)
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
