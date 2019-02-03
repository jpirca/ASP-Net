<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TravelExpertsFront.Register" %>

<%--Customer Registration Form
    Author:Muhammad islam
    Created:Jan, 2019--%>
<!doctype html>
<html lang="en">
<head>
  
	<meta charset="utf-8" />
	<link rel="apple-touch-icon" sizes="76x76" href="../../assets/img/apple-icon.png">
	<link rel="icon" type="image/png" sizes="96x96" href="../../assets/img/favicon.png">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />

	<title>Register</title>

	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />


     <!-- Bootstrap core CSS     -->
    <link href="../assets/css/bootstrap.min.css" rel="stylesheet" />

    <!--  Paper Dashboard core CSS    -->
    <link href="../assets/css/paper-dashboard.css" rel="stylesheet"/>


    <!--  CSS for Demo Purpose, don't include it in your project     -->
    <link href="../assets/css/demo.css" rel="stylesheet" />


    <!--  Fonts and icons     -->
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" rel="stylesheet">
    <link href='https://fonts.googleapis.com/css?family=Muli:400,300' rel='stylesheet' type='text/css'>
    <link href="../assets/css/themify-icons.css" rel="stylesheet">
</head>
<body>
    <nav class="navbar navbar-transparent navbar-absolute">
	    <div class="container">
	        <div class="navbar-header">
	            <button type="button" class="navbar-toggle navbar-toggle-black" data-toggle="collapse" data-target="#navigation-example-2">
	                <span class="sr-only">Toggle navigation</span>
	                <span class="icon-bar "></span>
	                <span class="icon-bar "></span>
	                <span class="icon-bar"></span>
	            </button>
	        </div>
	        <div class="collapse navbar-collapse">
	            <ul class="nav navbar-nav navbar-right">
	                <li>
	                   <a href="login.aspx" class="btn">
	                        Looking to login?
	                    </a>
	                </li>
	            </ul>
	        </div>
	    </div>
	</nav>
    <div class="wrapper wrapper-full-page">
    	<div class="register-page" data-color="azure" >
		<!--   you can change the color of the filter page using: data-color="blue | azure | green | orange | red | purple" -->
        	<div class="content">
       
            <div class="container" >
                <div class="row">
                <div class="col-md-8 col-md-offset-2">
                        <div class="header-text">
                            	<h2>Travel Experts</h2>
                            	<h4>Register for free and experience the journey.</h4>
                            	<hr>
                        	</div>
                  </div>
                
                    <form id="form1" runat="server">
                    	<div class="col-md-offset-2 col-md-4">
                      
                            	<div class="card card-plain">
                                	<div class="content">
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtFirstName" runat="server" class="form-control" placeholder="First Name"></asp:TextBox>
                                        <asp:Label ID="lblPovideFname" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                            <asp:TextBox ID="txtLastName" runat="server" class="form-control" placeholder="Last Name"></asp:TextBox>
                                             <asp:Label ID="lblprovideLastName" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtAddress" runat="server" class="form-control" placeholder="Your Address"></asp:TextBox>
                                            <asp:Label ID="lblProvidAddrss" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtCity" runat="server" class="form-control" placeholder="Calgary"></asp:TextBox>
                                            <asp:Label ID="lblProvideCity" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtProvince" runat="server" class="form-control" placeholder="Province, AB"></asp:TextBox>
                                            <asp:Label ID="lblProvideProvince" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtPostalCode" runat="server" class="form-control" placeholder="Postal Code, A1A A1A"></asp:TextBox>
                                            <asp:Label ID="lblProvidePostalCode" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                       <div class="form-group">
                                        	 <asp:TextBox ID="txtCountry" runat="server" class="form-control" placeholder="Canada"></asp:TextBox>
                                             <asp:Label ID="lblProvideCountry" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	  <asp:TextBox ID="txtBusPhone" runat="server" class="form-control" placeholder="(587)9879999"></asp:TextBox>
                                              <asp:Label ID="lblProvideBusPhone" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="email@email.com"></asp:TextBox>
                                             <asp:Label ID="lblProvideEmail" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	 <asp:TextBox ID="txtHomePhone" runat="server" class="form-control" placeholder="(587)9789999"></asp:TextBox>
                                             <asp:Label ID="lblProvideHomePhone" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                	</div>
                                    <hr />
                            	</div>
                        	
                    	</div>
                    	<div class="col-md-4">
                        	
                            	<div class="card card-plain">
                                	<div class="content">
                                    	
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtLoginName" runat="server" class="form-control" placeholder="Username"></asp:TextBox>
                                            <asp:Label ID="lblProvideLoginName" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                    	<div class="form-group">
                                        	<asp:TextBox ID="txtCustPassword" placeholder="Password" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                                            <asp:Label ID="lblProvidCustPassword" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                        <div class="form-group">
                                        	<asp:TextBox ID="txtConfirmPassword" placeholder="Confirm Password" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                                            <asp:Label ID="lblProvideCofirmpwd" runat="server" CssClass="lableerror"></asp:Label>
                                    	</div>
                                	</div>
                                    <hr />
                                	
                            	</div>
                        	
                    	</div>
                        <div class=" col-md-12 footer text-center">
                              <asp:Button ID="btnRegiste" class="btn btn-fill btn-danger btn-wd" runat="server" OnClick="btnRegister_Click" Text="Create Free Account" />
                              <asp:Button ID="btnReset" CssClass="btn btn-fill btn-danger btn-wd" runat="server" Text="Clear Form" OnClick="btnReset_Click" />
                         </div>
					</form>

                    </div>
                <footer class="footer footer-transparent">
            	<div class="container">
                	<div class="copyright text-center">
                    	&copy; <script>document.write(new Date().getFullYear())</script>, made with <i class="fa fa-heart heart"></i> by <a href="#">Travel Experts</a>
                	</div>
            	</div>
        	</footer>
                </div>
            </div>
        </div>
    </body>
</html>
