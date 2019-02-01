using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsFront.App_Code
{
    public class CustomersDB
    {
        public static bool RegisterCustomer()
        {
            bool custRisgered = false;
            SqlConnection connection = TravelExpertsConnectDB.GetConnection();
            Customer custObj = new Customer();
            custObj.CustFirstName = "Muhammad";
            custObj.CustLastName = "Islam";
            custObj.CustAddress = "7 Tralake Gardens NE";
            custObj.CustCity = "Calgary";
            custObj.CustProv = "AB";
            custObj.CustPostal = "T3j0A9";
            custObj.CustCountry = "Canada";
            custObj.CustHomePhoe = "4039713419";
            custObj.CustBusPhone = "";
            custObj.Email = "islammtci@yahoo.com";

            string query = "insert into Customers(CustFirstName,CustLastName,CustAddress,CustCity,CustProv" +
                ",CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail) values(@fName,@lName,@address" +
                ",@city,@prov,@postal,@country,@hPhone,@bPhone,@email)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@fName", custObj.CustFirstName);
            cmd.Parameters.AddWithValue("@lName", custObj.CustLastName);
            cmd.Parameters.AddWithValue("@address", custObj.CustAddress);
            cmd.Parameters.AddWithValue("@city", custObj.CustCity);
            cmd.Parameters.AddWithValue("@prov", custObj.CustProv);
            cmd.Parameters.AddWithValue("@postal", custObj.CustPostal);
            cmd.Parameters.AddWithValue("@country", custObj.CustCountry);
            cmd.Parameters.AddWithValue("@hPhone", custObj.CustHomePhoe);
            cmd.Parameters.AddWithValue("@bPhone", custObj.CustBusPhone);
            cmd.Parameters.AddWithValue("@email", custObj.Email);
            //  try
            // {
            connection.Open();
            cmd.ExecuteNonQuery();
            custRisgered = true;
            // }
            // catch (SqlException e)
            // {


            // }
            // finally
            // {
            connection.Close();

            // }
            return custRisgered;
        }
    }
}