using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront.Dashboard
{
    public partial class Dashoboard : System.Web.UI.MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedin"] != null)
            {
                Customer custObj = new Customer();
                CustomerDB customerDB = new CustomerDB();
                custObj.CustomerID = Convert.ToInt32(Session["CustID"]);
               
                customerDB.getallCustomerInfoById(custObj);
                lblCustomerName.Text = custObj.CustFirstName + " " + custObj.CustLastName;
            }
            else {
                Response.Redirect("~/Login.aspx");
            }
           
        }
    }
}