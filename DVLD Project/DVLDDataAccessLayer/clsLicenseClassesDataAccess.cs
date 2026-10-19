using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsLicenseClassesDataAccess
    {
        public static DataTable GetLicenseClassesList()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM LicenseClasses";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable LicenseClassesList = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    LicenseClassesList.Load(Reader);
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return LicenseClassesList;
        }
        static public bool Find(int LicenseClassID, ref string ClassName , ref string ClassDescription , ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            string Query = @"SELECT * FROM LicenseClasses 
                        WHERE LicenseClassID = @LicenseClassID ;";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ClassName = Reader["ClassName"].ToString();
                    ClassDescription = Reader["ClassDescription"].ToString();
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
                    ClassFees = (decimal)Reader["ClassFees"];
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
