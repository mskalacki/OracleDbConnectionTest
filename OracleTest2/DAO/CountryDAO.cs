using OracleTest2.DAOMappers;
using OracleTest2.DB;
using OracleTest2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OracleTest2.DAO
{
    public class CountryDAO : ICountryDAO
    {
        private IConnectionFactory _connectionFactory;
        private ICountryMapper _mapper;
        


        public CountryDAO(IConnectionFactory connection, ICountryMapper mapper)
        {
            this._connectionFactory = connection;
            this._mapper = mapper;
            
        }

        public int AddCountry (string code, string name, int region)
        {
            int result = 0;

            string sqlQuery = "insert into countries (country_id, country_name, region_id) values ( '" + code + "','" + name + "', " + region + ")";

            IQueryExecutor connectionToDb = _connectionFactory.CreateConnectionToDb();
            result = connectionToDb.ExecuteNonQuery(sqlQuery);

            return result;
        }

        public List<Country> GetAllCountries()
        {
            List<Country> CountriesFromDb = new List<Country>();
            string sqlQuery = "select * from countries";

            IQueryExecutor connectionToDb = _connectionFactory.CreateConnectionToDb();
            DataTable table = connectionToDb.ExecuteQuery(sqlQuery);

            foreach (DataRow row in table.Rows)
            {
                CountriesFromDb.Add(_mapper.MapCountry(row));
            }

            return CountriesFromDb;
        }
            
    }
}