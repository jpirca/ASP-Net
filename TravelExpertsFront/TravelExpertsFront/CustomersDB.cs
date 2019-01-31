using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsFront
{
    /*Class to get data from customerRegistration form, initialize member variable of Customers
         * Class to make it ready to send into database
         Author:Muhammad Islam
         Created:Jan,2019*/
    public class CustomersDB
    {
        /*Function gets data from customerRegistration form, and submit into data base,
         returns true if submission is successful otherwise will return false*/
        public bool RegisterCustomer(string fName,string lName,string address,string city,string province,
            string postalcode,string country,string homephone,string businessphone,string email,int agent)
        {
            //Initialize all member variables of Customers Class
            bool custRisgered = false;
            SqlConnection connection = TravelExpertsConnectDB.GetConnection();
            Customers custObj = new Customers();
            custObj.CustFirstName = fName;
            custObj.CustLastName = lName;
            custObj.CustAddress = address;
            custObj.CustCity = city;
            custObj.CustProv = province;
            custObj.CustPostal = postalcode;
            custObj.CustCountry = country;
            custObj.CustHomePhoe = homephone;
            custObj.CustBusPhone = businessphone;
            custObj.Email = email;
            custObj.Agent = agent;
            //Define the Insert query
            string query = "insert into Customers(CustFirstName,CustLastName,CustAddress,CustCity,CustProv" +
                ",CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,AgentId) values(@fName,@lName,@address" +
                ",@city,@prov,@postal,@country,@hPhone,@bPhone,@email,@agentid)";
            //Define the parameters
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
           cmd.Parameters.AddWithValue("@agentid", custObj.Agent);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                custRisgered = true;
            }
            catch (SqlException e)
            {
                throw e;
                
            }
            finally
            {
                connection.Close();
                
            }
            return custRisgered;
        }
    }
}