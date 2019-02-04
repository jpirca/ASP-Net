using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;


namespace TravelExpertsFront.Dashboard
{
    public partial class editProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["loggedin"] != null)
                {
                    Customer custObj = new Customer();
                    CustomerDB customerDB = new CustomerDB();
                    custObj.CustomerID = Convert.ToInt32(Session["CustID"]);
                    customerDB.getallCustomerInfoById(custObj);
                    //lblCustomerName.Text = custObj.CustFirstName + " " + custObj.CustLastName;
                    txtFirstName.Text = custObj.CustFirstName;
                    txtLastName.Text = custObj.CustLastName;
                    txtAddress.Text = custObj.CustAddress;
                    txtCity.Text = custObj.CustCity;
                    txtProvince.Text = custObj.CustProv;
                    txtCountry.Text = custObj.CustCountry;
                    txtPostalCode.Text = custObj.CustPostal;
                    txtHomePhone.Text = custObj.CustHomePhone;
                    txtBusPhone.Text = custObj.CustBusPhone;
                    txtEmail.Text = custObj.Email;
                    drpAgents.DataValueField = custObj.AgentId.ToString();

                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ValidatForm();
        }

      public  void ValidatForm()
        {
            CustomerDB updateObj = new CustomerDB();
            if (txtFirstName.Text == "")
            {
                lblPovideFname.Text = "Please Provide First Name";
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                lblprovideLastName.Text = "Please Provide Last Name";
                txtLastName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                lblProvidAddrss.Text = "Please Provide Address";
                txtAddress.Focus();
            }
            else if (txtCity.Text == "")
            {
                lblProvideCity.Text = "Please Provide City";
                txtCity.Focus();

            }
            else if (txtProvince.Text == "" || txtProvince.Text.Length > 2)
            {
                lblProvideProvince.Text = "Please Provide Province";
                txtProvince.Focus();
            }
            else if (txtPostalCode.Text == "" || !IsPostalCode(Convert.ToString(txtPostalCode.Text)))
            {
                lblProvidePostalCode.Text = "Postal Code is Empty Or Invalied";
                txtPostalCode.Focus();
            }
            else if (txtCountry.Text == "")
            {
                lblProvideCountry.Text = "Please Provide Country";
                txtCountry.Focus();
            }
            else if (!IsValidPhone(txtHomePhone.Text))
            {
                lblProvideHomePhone.Text = "Invalid Phone No";
                txtHomePhone.Focus();
            }
            else if (!(txtBusPhone.Text == "") && !IsValidPhone(txtBusPhone.Text))
            {
                lblProvideBusPhone.Text = "Invalid Phone";
                txtBusPhone.Focus();
            }

            //else if (txtNewPassword.Text == "")
            //{
            //    lblProvideNewPassword.Text = "Please choose your new Password";
            //}
            else
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string province = txtProvince.Text;
                string postalcode = txtPostalCode.Text;
                string country = txtCountry.Text;
                string homephone = txtHomePhone.Text;
                string busphone = txtBusPhone.Text;
                string email = txtEmail.Text;
                string password = txtCustPassword.Text;
                int CustId = Convert.ToInt32(Session["CustID"]);


                if (updateObj.UpdateUserProfile(firstName, lastName, address, city, province, postalcode, country
                    , homephone, busphone, email, CustId, password))
                {

                    lblUpdated.Text = "Updated Successfully" + txtFirstName.Text;

                }
            }
            //else if (txtCustPassword.Text == "")
            //{
            //    lblProvidCustPassword.Text = "Please provide Password";
            //    txtCustPassword.Focus();
            //}
            //else if (txtCustPassword.Text != txtConfirmPassword.Text)
            //{
            //    lblProvideCofirmpwd.Text = "Password Mismatched";
            //    txtCustPassword.Focus();
            //}

        }
        public bool IsPostalCode(string postalCode)
        {

            //Canadian Postal Code in the format of "M3A 1A5"
            string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";

            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            if (!(reg.IsMatch(postalCode)))
                return false;
            return true;
        }
        public bool IsValidPhone(string Phone)
        {
            try
            {
                if (string.IsNullOrEmpty(Phone))
                    return false;
                var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
                return r.IsMatch(Phone);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}