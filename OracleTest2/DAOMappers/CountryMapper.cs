using OracleTest2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OracleTest2.DAOMappers
{
    public class CountryMapper : ICountryMapper
    {
        public Country MapCountry(DataRow row)
        {
            Country countryFromDb = new Country();
            
                countryFromDb.Id = row["COUNTRY_ID"].ToString();
                countryFromDb.CuontryName = row["COUNTRY_NAME"].ToString();
                countryFromDb.RegionId = int.Parse(row["REGION_ID"].ToString());
         
            return countryFromDb;
        }
    }
}