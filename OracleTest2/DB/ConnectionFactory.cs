﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace OracleTest2.DB
{
    public class ConnectionFactory : IConnectionFactory
    {
        public IDbConnection CreateConnectionToDb()
        {

            IDbConnection connection = new OracleConnection();
            connection.ConnectionString = ConfigurationManager.AppSettings["OracleConnectionString"];

            return connection;
        }
    }
}