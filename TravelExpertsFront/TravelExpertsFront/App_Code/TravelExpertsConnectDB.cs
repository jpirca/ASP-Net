using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsFront
{
    /*Class to make a connection to TravlesExperts database locally, and facilitate other classes with connection
     Author: Muhammad Islam
     Date: Jan, 2019*/
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