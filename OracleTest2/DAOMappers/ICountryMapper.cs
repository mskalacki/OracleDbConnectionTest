using System.Data;
using OracleTest2.Models;

namespace OracleTest2.DAOMappers
{
    public interface ICountryMapper
    {
        Country MapCountry(DataRow row);
    }
}