using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsFront
{
    /*Class to make its associated data access class ready to popuplate Agents into a drop down list
     Author:Muahmmad Islam
     Created:Jan,2019*/
    public class Agents
    {
        //Define member variables
        public int agentID { get; set; }
        public string Name { get; set; }
        //Define constructor
        public Agents() { }
    }
}