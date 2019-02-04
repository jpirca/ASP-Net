using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront
{
    public partial class Login : System.Web.UI.Page
    {
        CustomerDB custDB = new CustomerDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.CustLoginName = txtUsername.Text;
            cust.CustPassword = txtpassword.Text;

            if (custDB.CustomerLogin(cust))
            {
                //Redirect to dashboard
                Session["loggedin"] = true;
                Session["CustID"] = cust.CustomerID;
                Response.Redirect("~/dashboard/index.aspx");
                
            }
            else
            {
                lblErrorMessage.Text = "Error in Login";
            }

        }
    }
}