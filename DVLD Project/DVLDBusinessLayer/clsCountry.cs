using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsCountry
    {
        public static DataTable GetCountriesList()
        {
            return DVLDDataAccessLayer.clsCountriesDataAccess.GetCountriesList();
        }
    }
}
