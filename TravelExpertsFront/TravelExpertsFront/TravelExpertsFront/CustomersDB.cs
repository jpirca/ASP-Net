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
            string postalcode,string country,string homephone,string businessphone,string email,int agent
            ,string CustLoginName,string CustPassword,string CustConfrimPassword)
        {
            //Initialize all member variables of Customers Class
            bool custRisgered = false;
           // SqlConnection connection = TravelExpertsConnectDB.GetConnection();
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
            custObj.CustLoginName = CustLoginName;
            custObj.CustPassword = CustPassword;
            custObj.CustConfirmPassword = CustConfrimPassword;
            //Define the Insert query
            string query = "insert into Customers(CustFirstName,CustLastName,CustAddress,CustCity,CustProv" +
                ",CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,AgentId,CustLoginName" +
                ",CustPassword,CustConfirmPassword) values(@fName,@lName,@address" +
                ",@city,@prov,@postal,@country,@hPhone,@bPhone,@email,@agentid,@loginname" +
                ",@custpassword,@custconfirmpassword)";
            //Define the parameters
            using (SqlConnection connection = new SqlConnection(TravelExpertsConnectDB.GetConnectionString()))
            {
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
                cmd.Parameters.AddWithValue("@loginname", custObj.CustLoginName);
                cmd.Parameters.AddWithValue("@custpassword", custObj.CustPassword);
                cmd.Parameters.AddWithValue("@custconfirmpassword", custObj.CustConfirmPassword);

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
                //finally
                //{
                //    connection.Close();

                //}
            }
            return custRisgered;
        }
        public bool isValidUserName(string name)
        {
            int count = 0;
            bool isValidUser = false;
            string Name;
            // define connection
            // SqlConnection connection = TravelExpertsConnectDB.GetConnection();
            using (SqlConnection connection = new SqlConnection(TravelExpertsConnectDB.GetConnectionString()))
            {
                // define the select query command
                string selectQuery = "select CustLoginName from customers where CustLoginName=@loginname";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@loginname", name);
                try
                {
                    // open the connection
                    connection.Open();

                    // execute the query
                    SqlDataReader reader = selectCommand.ExecuteReader(); // can be multiple records

                    // process the results
                    while (reader.Read()) // while there are customers
                    {

                        Name = reader["CustLoginName"].ToString();
                        count++;
                    }
                    if (count > 0)
                    {
                        isValidUser = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex; // let the form handle it
                }
              
            }
            return isValidUser;
        }
    }
}