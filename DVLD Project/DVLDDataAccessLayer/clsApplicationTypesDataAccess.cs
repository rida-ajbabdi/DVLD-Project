using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsApplicationTypesDataAccess
    {
        public static DataTable GetApplicationTypesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM ApplicationTypes";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ApplicationTypes = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ApplicationTypes.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ApplicationTypes;
        }
        static public bool Update(int ApplicationTypeID, string Title, decimal Fees)
        {
            string Query = @"
            UPDATE ApplicationTypes
            SET 
                ApplicationTypeTitle = @Title,
                ApplicationFees = @Fees
            WHERE ApplicationTypeID = @ApplicationTypeID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@Title", Title);
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
        public static bool FindApplicationType(int ApplicationTypeID, ref string Title, ref decimal Fees)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationTypeID , ApplicationTypeTitle ,ApplicationFees
                             FROM ApplicationTypes
                             WHERE ApplicationTypeID = @ApplicationTypeID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            bool IsFound = false;
            decimal FeesValue = 0;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Title = Reader["ApplicationTypeTitle"].ToString();
                    if(decimal.TryParse(Reader["ApplicationFees"].ToString() , out FeesValue))
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
