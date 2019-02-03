using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsFront
{
    /*Form to edit customers profile, loads data of logged in customers into a form, then after the customer
     * make changes to it, save it to database
     Author: Muhammad Islam
     Created: Feb, 2019*/
    public partial class WebForm1 : System.Web.UI.Page
    {
        //on load, call the load_from_data function to load data of currently loged in customer into form
        protected void Page_Load(object sender, EventArgs e)
        {
            load_form_data();
        }
        //update the specific record
        protected void btnRegiste_Click(object sender, EventArgs e)
        {
            ValidatForm();
        }
        void ValidatForm()
        {
            CustomersDB updateObj = new CustomersDB();
            CustomersDB regObj = new CustomersDB();
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
            //else if (!(txtBusPhone.Text == "") && !IsValidPhone(txtBusPhone.Text))
            //{
            //    lblProvideBusPhone.Text = "Invalid Phone";
            //    txtBusPhone.Focus();
            //}
            //else if (txtEmail.Text == "" || !isValidEmail(txtEmail.Text))
            //{
            //    lblProvideEmail.Text = "Invalid Email";
            //    txtEmail.Focus();
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
               // string password = txtNewPassword.Text;
                int CustId = 105;

                if (updateObj.UpdateUserProfile(firstName, lastName, address, city, province, postalcode, country
                    , homephone, busphone, email, CustId))
                {

                    lblUpdated.Text = "Updated Successfully";
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
        private void load_form_data()
        {
            int CustId = 105;
            CustomersDB fetchDataObj = new CustomersDB();
            fetchDataObj.fetchDataIntoForm(CustId);
            txtFirstName.Text = fetchDataObj.firstName;
            txtLastName.Text = fetchDataObj.lastName;
            txtAddress.Text = fetchDataObj.Address;
            txtCity.Text = fetchDataObj.City;
            txtProvince.Text = fetchDataObj.Prov;
            txtPostalCode.Text = fetchDataObj.Postal;
            txtCountry.Text = fetchDataObj.Country;
            txtHomePhone.Text = fetchDataObj.homePhoe;
            txtBusPhone.Text = fetchDataObj.busPhone;
            txtEmail.Text = fetchDataObj.Email;
            //txtCustPassword.Text = fetchDataObj.Password;
        }

    }
}