using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Threaded_ProjectII_Asp
{
    public partial class CustomerRegisteration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CustomersDB regObj = new CustomersDB();
            if (regObj.RegisterCustomer())
            {
                lblCustRegisteration.Text = "Customers Added Successfully";
            }
        }
    }
}