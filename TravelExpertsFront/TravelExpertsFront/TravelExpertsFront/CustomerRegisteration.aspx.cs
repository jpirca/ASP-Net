using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsFront
{
    /*Customer Registration form, validate all the fields. If the data is valied save data to database and
     take control to RegistraionConfirmation.aspx
     Author:Muhammad Islam
     Created: Jan, 2019*/
    public partial class CustomerRegisteration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Call the validate function and save data to database if valied
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            ValidatForm();                       
        }
        //validate form fields
        void ValidatForm()
        {
            CustomersDB regObj = new CustomersDB();
            if (txtFirstName.Text == "")
            {
                lblPovideFname.Text = "Please Provide First Name";
            }
            else if (txtLastName.Text == "")
            {
                lblprovideLastName.Text = "Please Provide Last Name";
            }
            else if (txtAddress.Text == "")
            {
                lblProvidAddrss.Text = "Please Provide Address";
            }
            else if (txtCity.Text == "")
            {
                lblProvideCity.Text = "Please Provide City";
               
            }
            else if(txtProvince.Text == "" ||txtProvince.Text.Length>2)
            {
               lblProvideProvince.Text = "Please Provide Province";
            }
            else if (txtPostalCode.Text == ""||!IsPostalCode(Convert.ToString(txtPostalCode.Text)))
            {
                lblProvidePostalCode.Text = "Postal Code is Empty Or Invalied";
            }
            else if (txtCountry.Text == "")
            {
                lblProvideCountry.Text = "Please Provide Country";
            }
            else if (!IsValidPhone(txtHomePhone.Text))
            {
                lblProvideHomePhone.Text = "Invalid Phone No";
            }
            else if (!(txtBusPhone.Text=="") && !IsValidPhone(txtBusPhone.Text))
            {
                lblProvideBusPhone.Text = "Invalid Phone";
            }
            else if (txtEmail.Text == "" || !isValidEmail(txtEmail.Text))
            {
                lblProvideEmail.Text = "Invalid Email";
                
            }
            else if (txtLoginName.Text == ""||regObj.isValidUserName(txtLoginName.Text))
            {
                if (txtLoginName.Text == "")
                {
                    lblProvideLoginName.Text = "Please provide Your Login Name";
                }
                else
                {
                    lblProvideLoginName.Text = "User Name already exists, Pleas choose another Name";
                }
                
            }
            else if (txtCustPassword.Text == "")
            {
                lblProvidCustPassword.Text = "Please provide Password";
            }
            else if(txtCustPassword.Text != txtConfirmPassword.Text)
            {
                lblProvideCofirmpwd.Text = "Password Mismatched";
            }
            else
            {
                
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
                string custAgent = drpAgents.Text;
                string custLoginName = txtLoginName.Text;
                string custPassword = txtConfirmPassword.Text;
                string custConfirmPaswword = txtConfirmPassword.Text;

                if (regObj.RegisterCustomer(firstName,lastName,custAddress,custCity,custProvice,custPostalcode,
                    custCountry,custHomePhone,custBusinessPhone,custEmail,Convert.ToInt32(custAgent),
                    custLoginName,custPassword,custConfirmPaswword))
                {
                    
                    Response.Redirect("RegistrationConfirmaton.aspx");
                }
            }

        }
        //Match the postal code with regular expression for validity
        public  bool IsPostalCode(string postalCode)
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