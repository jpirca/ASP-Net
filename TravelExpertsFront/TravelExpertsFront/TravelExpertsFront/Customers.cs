using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsFront
{
    /*Class to define varaibles for all data columns of Customers Table, in order to send data to database using
     its object
     Author: Muhammad Islam
     Created:Jan, 2019*/
    public class Customers
    {
        //Define member variable properties
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }
        public string CustPostal { get; set; }
        public string CustCountry { get; set; }
        public string CustHomePhoe { get; set; }
        public string CustBusPhone { get; set; }
        public string Email { get; set; }
        public int Agent { get; set; }
        public string CustLoginName { get; set; }
        public string CustPassword { get; set; }
        public string CustConfirmPassword { get; set; }
        //Define constructor
        public Customers() { }
    }
}