using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront
{
    /*Customer Registration form, validate all the fields. If the data is valied save data to database and
    take control to RegistraionConfirmation.aspx
    Author:Muhammad Islam
    Created: Jan, 2019*/
    public partial class Register : System.Web.UI.Page
    {
        CustomerDB regObj = new CustomerDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Call the validate function and save data to database if valied
        protected void btnRegister_Click(object sender, EventArgs e)
        {

            if (ValidateForm()) {


                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string custAddress = txtAddress.Text;
                string custCity = txtCity.Text;
                string custProvice = txtProvince.Text;
                string custPostalcode = txtPostalCode.Text;
                string custCountry = txtCountry.Text;
                string custHomePhone = txtHomePhone.Text;
                string custBusinessPhone = txtBusPhone.Text;
                string custEmail = txtEmail.Text;
                string custLoginName = txtLoginName.Text;
                string custPassword = txtConfirmPassword.Text;
                string custConfirmPaswword = txtConfirmPassword.Text;
                if (regObj.RegisterCustomer(firstName, lastName, custAddress, custCity, custProvice, custPostalcode,
                    custCountry, custHomePhone, custBusinessPhone, custEmail,
                    custLoginName, custPassword, custConfirmPaswword))
                {

                    Response.Redirect("RegistrationConfirmaton.aspx");
                }
            }
        }
        //validate form fields
        private bool ValidateForm()
        {
            bool Validate = false;
           
            if (txtFirstName.Text == "")
            {
                lblPovideFname.Text = "Please Provide Your First Name";
                Validate = false;
            }
            else{
                lblPovideFname.Text = "";
                Validate = true;
            }

            if (txtLastName.Text == "")
            {
                lblProvideLastName.Text = "Please Provide Your Last Name";
                Validate = false;
            }
            else {
                lblProvideLastName.Text = "";
                Validate = true;
            }

            if (txtAddress.Text == "")
            {
                lblProvideAddress.Text = "Please Provide Your Address";
                Validate = false;
            } else {
                lblProvideAddress.Text = "";
                Validate = true;
            }


            if (txtCity.Text == "")
            {
                lblProvideCity.Text = "Please Provide Your City";
                Validate = false;
            }
            else {
                lblProvideCity.Text = "";
                Validate = true;
            }

            if (txtProvince.Text == "" || txtProvince.Text.Length > 2)
            {
                lblProvideProvince.Text = "Please Provide Your Province";
                Validate = false;
            }
            else {
                lblProvideProvince.Text = "";
                Validate = true;
            }

            if (txtPostalCode.Text == "" || !IsPostalCode(Convert.ToString(txtPostalCode.Text)))
            {
                lblProvidePostalCode.Text = "Postal Code is Empty Or Invalid";
                Validate = false;
            }
            else {
                lblProvidePostalCode.Text = "";
                Validate = true;
            }

            if (txtCountry.Text == "")
            {
                lblProvideCountry.Text = "Please Provide YourCountry";
                Validate = false;
            }
            else {
                lblProvideCountry.Text = "";
                Validate = true;
            }

            if (!IsValidPhone(txtHomePhone.Text))
            {
                lblProvideHomePhone.Text = "Provide Your Phone Number Within 10 digits";
                Validate = false;
            }
            else {
                lblProvideHomePhone.Text = "";
                Validate = true;
            }

            if (!(txtBusPhone.Text == "") && !IsValidPhone(txtBusPhone.Text))
            {
                lblProvideBusPhone.Text = "Provide Your Business Number Within 10 digits";
                Validate = false;
            }
            else {
                lblProvideBusPhone.Text = "";
                Validate = true;
            }

            if (txtEmail.Text == "" || !isValidEmail(txtEmail.Text))
            {
                lblProvideEmail.Text = "Make Sure Your Is In The Correct Format";
                Validate = false;
            }
            else {

                lblProvideEmail.Text = "";
                Validate = true;

            }

            if (txtLoginName.Text == "" || regObj.isValidUserName(txtLoginName.Text))
            {
                if (txtLoginName.Text == "")
                {
                    lblProvideLoginName.Text = "Please provide a Username";
                    Validate = false;
                }
                else
                {
                    lblProvideLoginName.Text = "Your Username already exists, Please choose another Name";
                    Validate = false;
                }

            }else{
                txtLoginName.Text = "";
                Validate = true;
            }

            if (txtCustPassword.Text == "")
            {
                lblProvideCustPassword.Text = "Please provide Password";
                Validate = false;
            } else {
                lblProvideCustPassword.Text = "";
                Validate = true;
            }

            if (txtConfirmPassword.Text == "") {
                lblProvideConfirmpwd.Text = "Please Provide Confirm Password";
                Validate = false;
            }
            else
            {
                lblProvideCustPassword.Text = "";
                Validate = true;
            }

            if ((txtCustPassword.Text.Length > 0 && txtConfirmPassword.Text.Length > 0) && (txtCustPassword.Text != txtConfirmPassword.Text))
            {
                lblProvideConfirmpwd.Text = "Your Passwords don't match, Try entering them again :)";
                Validate = false;
            }
            else {
                Validate = true;
            }

            return Validate;
        }
        //Match the postal code with regular expression for validity
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
        //Match the email with regual expression for validity
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        //Call ClearForm function to reste the form
        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        //Function to clear form
        public void ClearForm()
        {
            foreach (Control c in Page.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                        {
                            // myspan.InnerHtml = ((TextBox)c2).Text;
                            ((TextBox)c2).Text = "";  //or  ((TextBox)c2).Text.Length = 0;
                            Response.Redirect("~/CustomerRegisteration.aspx");
                        }
                    }
                }
            }
        }
    }

}