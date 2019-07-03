using System.Data;

namespace OracleTest2.DB
{
    public interface IQueryExecutor
    {
        int ExecuteNonQuery(string query);
        DataTable ExecuteQuery(string query);
    }
}