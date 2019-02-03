<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustEditProfile.aspx.cs" Inherits="TravelExpertsFront.WebForm1" %>

<!DOCTYPE html lang="en">
<%-- Page to customer profile, loads the logged in customer data in to form and then after changes are done
    Author: Muhammad Islam
    Created: FEB, 2019
    --%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="stylesheet/travelExpertsStyles.css" rel="stylesheet" />
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet" />
    <script src="bootstrap/bootstrap.min.js"></script>
    <script src="bootstrap/jquery.js"></script>
    <title>Customer Edit Profile</title>
</head>
<body>
    <div class="container-fluid">
        <form id="form1" runat="server">
            <div class="container">
                <div class="row">
                    <div class="col-2">
                    </div>
                    <div class="col-8">
                        <div class="jumbotron jumbotron-fluid">
                            <div class="container">
                                <h4 class="display-4">Personal Information</h4>
                                <asp:Label ID="lblFirstname" runat="server" Text="*First Name" Class="lablestyle"></asp:Label>
                                <asp:TextBox ID="txtFirstName" runat="server" class="form-control" placeholder="Jhone"></asp:TextBox>
                                <asp:Label ID="lblPovideFname" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblLastname" runat="server" Text="*Last Name" class="lablestyle"></asp:Label>
                                <asp:TextBox ID="txtLastName" runat="server" class="form-control" placeholder="Smith"></asp:TextBox>
                                <asp:Label ID="lblprovideLastName" runat="server" CssClass="lableerror"></asp:Label>
                            </div>
                        </div>

                    </div>
                    <div class="col-2">
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-8">
                        <div class="jumbotron jumbotron-fluid">
                            <div class="container">
                                <h4 class="display-4">Contact Information</h4>
                                <asp:Label ID="lblAddress" runat="server" class="lablestyle">*Street Address</asp:Label>
                                <asp:TextBox ID="txtAddress" runat="server" class="form-control" placeholder="7 Wolf Creek Drive SE"></asp:TextBox>
                                <asp:Label ID="lblProvidAddrss" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblCity" runat="server" class="lablestyle">*City</asp:Label>
                                <asp:TextBox ID="txtCity" runat="server" class="form-control" placeholder="Calgary"></asp:TextBox>
                                <asp:Label ID="lblProvideCity" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblProvince" runat="server" class="lablestyle">*Province</asp:Label>
                                <asp:TextBox ID="txtProvince" runat="server" class="form-control" placeholder="AB"></asp:TextBox>
                                <asp:Label ID="lblProvideProvince" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblPostalCode" runat="server" class="lablestyle">*PostalCode</asp:Label>
                                <asp:TextBox ID="txtPostalCode" runat="server" class="form-control" placeholder="T3J0A8"></asp:TextBox>
                                <asp:Label ID="lblProvidePostalCode" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblContry" runat="server" class="lablestyle">*Country</asp:Label>
                                <asp:TextBox ID="txtCountry" runat="server" class="form-control" placeholder="Canada"></asp:TextBox>
                                <asp:Label ID="lblProvideCountry" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblHomePhone" runat="server" class="lablestyle">*Home Phone</asp:Label>
                                <asp:TextBox ID="txtHomePhone" runat="server" class="form-control" placeholder="(587)9789999"></asp:TextBox>
                                <asp:Label ID="lblProvideHomePhone" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblBusPhone" runat="server" class="lablestyle">Business Phone</asp:Label>
                                <asp:TextBox ID="txtBusPhone" runat="server" class="form-control" placeholder="(587)9879999"></asp:TextBox>
                                <asp:Label ID="lblProvideBusPhone" runat="server" CssClass="lableerror"></asp:Label>
                                <asp:Label ID="lblEmail" runat="server" class="lablestyle">*Email</asp:Label>
                                <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="jhon@gmail.com"></asp:TextBox>
                                <asp:Label ID="lblProvideEmail" runat="server" CssClass="lableerror"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="col-2"></div>
                </div>
            </div>
            <%--<div class="container">
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-8">
                        <div class="jumbotron jumbotron-fluid">--%>
                            <%--<div class="container">
                                <h4 class="display-4">Security Information</h4>--%>
                                <%--      <asp:Label ID="lblCustPassword" runat="server" class="lablestyle">*Current Password</asp:Label>
                        <asp:TextBox ID="txtCustPassword" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                        <asp:Label ID="lblProvidCustPassword" runat="server" CssClass="lableerror"></asp:Label>--%>
                              <%--  <asp:Label ID="lblConfirmPassword" runat="server" class="lablestyle">*New Password</asp:Label>
                        <asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                        <asp:Label ID="lblProvideCofirmpwd" runat="server" CssClass="lableerror"></asp:Label>
                                </div>--%>
                  <%--          </div>
                    </div>
                    <div class="col-2"></div>
                </div>
            </div>--%>
            <div class="container">
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-4">
 <asp:Button ID="btnRegiste" class="btn btn-primary  btn-block" runat="server" Text="Save Changes" OnClick="btnRegiste_Click" />
                    </div>
                    <div class="col-4">
 <asp:Button ID="btnReset" CssClass="btn btn-primary btn-block" runat="server" Text="Clear Form"  />
                    </div>
                    <div class="col-2">
                        <asp:Label ID="lblUpdated" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
            <%--</div>--%>
        </form>
    </div>

</body>
</html>
