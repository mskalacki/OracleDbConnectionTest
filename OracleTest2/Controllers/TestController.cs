using Oracle.ManagedDataAccess.Client;
using OracleTest2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OracleTest2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<string> MyList = new List<string>();
            using (OracleConnection conn = new OracleConnection()) 
            {
                conn.ConnectionString = "Data Source=(DESCRIPTION =(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA =(SID =xe)));User ID=hr;Password=hr;";
                conn.Open();
                IDbCommand command = conn.CreateCommand();
                command.CommandText = "select * from countries";

                var reader = command.ExecuteReader();

                while (reader.Read())
                {

                    MyList.Add(reader["COUNTRY_ID"].ToString());
                }
            }

            return Json(new
            {
                list = MyList
            },JsonRequestBehavior.AllowGet);
        }

        public ActionResult InsertItem(Country countryToAdd)
        {

            using (OracleConnection conn = new OracleConnection())
            {
                conn.ConnectionString = "Data Source=(DESCRIPTION =(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA =(SID =xe)));User ID=hr;Password=hr;";
                conn.Open();
                using (OracleTransaction tran = conn.BeginTransaction())
                {

                    IDbCommand command = conn.CreateCommand();

                }

            }
            return null;   
        }
    }
}