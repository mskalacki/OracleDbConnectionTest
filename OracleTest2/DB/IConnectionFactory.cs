using System.Data;

namespace OracleTest2.DB
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnectionToDb();
    }
}