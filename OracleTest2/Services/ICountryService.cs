using System.Collections.Generic;
using OracleTest2.Models;

namespace OracleTest2.Services
{
    public interface ICountryService
    {
        int AddCountry(string code, string name, int region);
        List<Country> GetAllCountries();
    }
}