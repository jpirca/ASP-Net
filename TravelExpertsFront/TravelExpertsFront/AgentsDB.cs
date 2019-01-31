using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsFront
{
    /*Class to return agents in form of list object connected to a drop dwon list named drpAgents, using object data source
     * Author:Muhammad Islam
     * Created:Jan, 2019*/
    public class AgentsDB
    {
        //Function returns list of Agents in form of Agents Class object to drop down name drpAgents
        public static List<Agents> GetAgents()
        {
            List<Agents> agents = new List<Agents>(); // empty list
            Agents agentsobj = null; // reference for reading 
            // define connection
            SqlConnection connection = TravelExpertsConnectDB.GetConnection();

            // define the select query command
            string selectQuery = "select AgentId,AgtFirstName from Agents ";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            //  selectCommand.Parameters.AddWithValue("@State", stateCode);
            try
            {
                // open the connection
                connection.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader(); // can be multiple records

                // process the results
                while (reader.Read()) // while there are customers
                {
                    agentsobj = new Agents();
                   agentsobj.agentID= (int)reader["AgentId"];
                    agentsobj.Name = reader["AgtFirstName"].ToString();
                    agents.Add(agentsobj);
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally
            {
                connection.Close(); // close connecto no matter what
            }

            return agents;

        }
    }
}