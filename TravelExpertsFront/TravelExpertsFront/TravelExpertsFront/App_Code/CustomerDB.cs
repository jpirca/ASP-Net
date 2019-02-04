using System;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TravelExpertsFront.App_Code
{
    public class CustomerDB
    {
        /*Function gets data from customerRegistration form, and submit into data base,
         returns true if submission is successful otherwise will return false*/
        public bool RegisterCustomer(string fName, string lName, string address, string city, string province,
            string postalcode, string country, string homephone, string businessphone, string email,
            string CustLoginName, string CustPassword, int? agent = null)
        {
            
            
            //Initialize all member variables of Customers Class
            bool custRegistered = false;
            Customer custObj = new Customer
            {
                CustFirstName = fName,
                CustLastName = lName,
                CustAddress = address,
                CustCity = city,
                CustProv = province,
                CustPostal = postalcode,
                CustCountry = country,
                CustHomePhone = homephone,
                CustBusPhone = businessphone,
                Email = email,
                CustLoginName = CustLoginName,
                CustPassword = Encrypt(CustPassword)
            };

            //Define the Insert query
            string query = "insert into Customers(CustFirstName,CustLastName,CustAddress,CustCity,CustProv" +
                ",CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,AgentId,CustLoginName" +
                ",CustPassword) values(@fName,@lName,@address" +
                ",@city,@prov,@postal,@country,@hPhone,@bPhone,@email,@agentid,@loginname" +
                ",@custpassword)";

           
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
                cmd.Parameters.AddWithValue("@hPhone", custObj.CustHomePhone);
                cmd.Parameters.AddWithValue("@bPhone", custObj.CustBusPhone);
                cmd.Parameters.AddWithValue("@email", custObj.Email);
                cmd.Parameters.AddWithValue("@agentid", agent == null ? (object)DBNull.Value : Convert.ToInt32(agent));
                cmd.Parameters.AddWithValue("@loginname", custObj.CustLoginName);
                cmd.Parameters.AddWithValue("@custpassword", custObj.CustPassword);
                

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    custRegistered = true;
                }
                catch (SqlException e)
                {
                    throw e;

                }
                finally
                {
                    connection.Close();

                }
            }
            return custRegistered;
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

        public bool CustomerLogin(Customer customer)
        {
            //Check username 
            if (CheckCustomerEmail(customer))
            {

                //Console.WriteLine(VerifyPassword(agent.AgentPassword, hashsalt.Hash, hashsalt.Salt));
                string DBhashedPassword = GetHashPasswordByCustomerId(customer).CustPassword.ToString();
                if (VerifyPassword(customer.CustPassword, DBhashedPassword))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private bool CheckCustomerEmail(Customer customer)
        {

            using (SqlConnection connection = new SqlConnection(TravelExpertsConnectDB.GetConnectionString()))
            {
                try
                {
                    //open the connection
                    connection.Open();
                    SqlCommand checkEmail = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE CustLoginName = @custlogin", connection);
                    checkEmail.Parameters.AddWithValue("@custlogin", customer.CustLoginName);
                    int UserExist = (int)checkEmail.ExecuteScalar();
                    if (UserExist > 0)
                    {
                        SqlCommand command = new SqlCommand("SELECT CustomerId FROM Customers WHERE CustLoginName = @custlogin", connection);
                        command.Parameters.AddWithValue("@custlogin", customer.CustLoginName);

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            //Set Customer ID
                            customer.CustomerID = Convert.ToInt32(reader["CustomerId"]);
                        }
                        return true;
                    }
                    else
                    {
                        //Username doesn't exist.
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    //Utils.WriteErrorLog("Login failed Type: " + ex.GetType() + "  Message: " + ex.Message);
                   // Utils.ErrorManager(ex, "Agents", "AgentDB.CheckAgentEmail()");
                    return false;
                }
            }
        }

        private Customer GetHashPasswordByCustomerId(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(TravelExpertsConnectDB.GetConnectionString()))
            {
                //SqlCommand AgentHashSalt = new SqlCommand("SELECT Hash, Salt FROM HashSalt WHERE AgentID = @agentId", connection);
                SqlCommand CustomerHashPass = new SqlCommand("SELECT CustPassword FROM Customers WHERE CustomerId = @custId", connection);
                CustomerHashPass.Parameters.AddWithValue("@custId", customer.CustomerID);

                //open the connection

                connection.Open();
                SqlDataReader reader = CustomerHashPass.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        customer.CustPassword = reader["CustPassword"].ToString();
                    }

                    return customer;
                }
                catch (Exception ex)
                {
                    //Utils.ErrorManager(ex, "Agents", "AgentDB.GetHashPasswordByAgentId()");
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return customer;
        }

        private bool VerifyPassword(string customerHashedPassword, string DBhashedPassword)
        {
            int result = customerHashedPassword.CompareTo(DBhashedPassword);
            if (customerHashedPassword == DBhashedPassword)
            {
                return true;
            }
            else {
                return false;
            }
        }

        protected void logout(object sender, EventArgs e)
        {
           
        }

        public void getallCustomerInfoById(Customer custObj)
        {

            //Define the Insert query
            string query = "SELECT[CustFirstName] ,[CustLastName] ,[CustAddress] ,[CustCity] ,[CustProv],[CustPostal],[CustCountry]"+
                           ",[CustHomePhone] ,[CustBusPhone] ,[CustEmail],[AgentId],[CustLoginName],[CustPassword] FROM [Customers] WHERE [CustomerId] = "+custObj.CustomerID;


            //Define the parameters
            using (SqlConnection connection = new SqlConnection(TravelExpertsConnectDB.GetConnectionString()))
            {
                
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            custObj.CustFirstName = reader["CustFirstName"].ToString();
                            custObj.CustLastName = reader["CustLastName"].ToString();
                            custObj.CustAddress = reader["CustAddress"].ToString();
                            custObj.CustCity = reader["CustCity"].ToString();
                            custObj.CustPostal = reader["CustPostal"].ToString();
                            custObj.CustProv = reader["CustProv"].ToString();
                            custObj.CustCity = reader["CustCountry"].ToString();
                            custObj.CustHomePhone = reader["CustHomePhone"].ToString();
                            custObj.CustBusPhone = reader["CustBusPhone"].ToString();
                            custObj.Email = reader["CustEmail"].ToString();
                            custObj.CustLoginName = reader["CustLoginName"].ToString();
                            custObj.AgentId = (reader["AgentId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["AgentId"]));
                        }
                    }

                    
                }
                catch (SqlException e)
                {
                    throw e;

                }
                finally
                {
                    connection.Close();

                }
            }
        }

    }
}