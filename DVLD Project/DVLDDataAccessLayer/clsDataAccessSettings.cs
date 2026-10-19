using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DVLDDataAccessLayer
{
    internal class clsDataAccessSettings
    {
        
        //public static string ConnectionString = "Server=.; DataBase=DVLD ; User Id=sa;Password=sa123456;";
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; } }
    }
}
