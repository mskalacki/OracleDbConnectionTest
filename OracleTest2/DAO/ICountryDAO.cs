using System.Collections.Generic;
using OracleTest2.Models;

namespace OracleTest2.DAO
{
    public interface ICountryDAO
    {
        int AddCountry(string code, string name, int region);
        List<Country> GetAllCountries();
    }
}