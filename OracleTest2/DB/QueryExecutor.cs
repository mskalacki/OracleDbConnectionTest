using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OracleTest2.DB
{
    public class QueryExecutor : IQueryExecutor
    {
        private IDbConnection _connection;

        public QueryExecutor(IDbConnection connection)
        {

            this._connection = connection;
        }

        public int ExecuteNonQuery(string query)
        {
            int result = 0;
            using (_connection)
            {
                _connection.Open();

                using (IDbTransaction tran = _connection.BeginTransaction())
                {
                    IDbCommand command = _connection.CreateCommand();
                    try
                    {
                         
                        command.CommandText = query;
                        result = command.ExecuteNonQuery();
                        tran.Commit();
                        
                    }
                    catch (Exception)
                    {
                        tran.Rollback();

                    }
                    finally
                    {
                        command.Dispose();
                    }
                }
            }
            return result;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable result = new DataTable();

            using (_connection)
            {
                _connection.Open();
                using (IDbCommand command = _connection.CreateCommand())
                {
                    command.CommandText = query;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        result.Load(reader);

                    }
                }
                return result;

            }
        }
    }
}