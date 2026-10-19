using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsTestTypesDataAccess
    {
        public static DataTable GetTestTypesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM TestTypes";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable TestTypes = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    TestTypes.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return TestTypes;
        }
        static public bool Update(int TestTypeID, string Title,string Description , decimal Fees)
        {
            string Query = @"
            UPDATE TestTypes
            SET 
                TestTypeTitle = @Title,
                TestTypeDescription = @Description,
                TestTypeFees = @Fees
            WHERE TestTypeID = @TestTypeID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@Title", Title);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@Fees", Fees);
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
        public static bool FindTestType(int TestTypeID, ref string Title,ref string Description , ref decimal Fees)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TestTypeID , TestTypeTitle ,TestTypeDescription , TestTypeFees
                             FROM TestTypes
                             WHERE TestTypeID = @TestTypeID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            bool IsFound = false;
            decimal FeesValue = 0;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Title = Reader["TestTypeTitle"].ToString();
                    Description = Reader["TestTypeDescription"].ToString();
                    if (decimal.TryParse(Reader["TestTypeFees"].ToString(), out FeesValue))
                    {
                        Fees = FeesValue;
                    }
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
