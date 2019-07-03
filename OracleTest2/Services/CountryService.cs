using OracleTest2.DAO;
using OracleTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OracleTest2.Services
{
    public class CountryService : ICountryService
    {
        private ICountryDAO _dao;
        public CountryService (ICountryDAO countryDao)
        {
            this._dao = countryDao;
        }

        public List<Country> GetAllCountries()
        {
            return _dao.GetAllCountries();
        }

        public int AddCountry (string code, string name, int region)
        {
            return _dao.AddCountry(code, name, region);
        }
    }
}