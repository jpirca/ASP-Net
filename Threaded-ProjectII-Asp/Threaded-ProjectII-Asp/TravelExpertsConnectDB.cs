using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Threaded_ProjectII_Asp
{
    public class TravelExpertsConnectDB
    {
        public static SqlConnection GetConnection()
        {
            // get connection string from Web.config
            string connString = ConfigurationManager.ConnectionStrings["rdsconnect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}