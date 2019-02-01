﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TravelExpertsFront.Register" %>

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
    	<div class="register-page">
		<!--   you can change the color of the filter page using: data-color="blue | azure | green | orange | red | purple" -->
        	<div class="content">
            	<div class="container">
                	<div class="row">
                    	<div class="col-md-8 col-md-offset-2">
                        	<div class="header-text">
                            	<h2>Travel Experts</h2>
                            	<h4>Register for free and experience the journey.</h4>
                            	<hr>
                        	</div>
                    	</div>
                    	<div class="col-md-4 col-md-offset-2">
                        	<div class="media">
                            	<div class="media-left">
                                	<div class="icon icon-danger">
                                    	<i class="ti ti-user"></i>
                                	</div>
                            	</div>
                            	<div class="media-body">
                                	<h5>Free Account</h5>
                                	Here you can write a feature description for your dashboard, let the users know what is the value that you give them.
                            	</div>
                        	</div>
                        	<div class="media">
                            	<div class="media-left">
                                	<div class="icon icon-warning">
                                    	<i class="ti-bar-chart-alt"></i>
                                	</div>
                            	</div>
                            	<div class="media-body">
                                	<h5>Awesome Performances</h5>
                                	Here you can write a feature description for your dashboard, let the users know what is the value that you give them.
                            	</div>
                        	</div>
                        	<div class="media">
                            	<div class="media-left">
                                	<div class="icon icon-info">
                                    	<i class="ti-headphone"></i>
                                	</div>
                            	</div>
                            	<div class="media-body">
                                	<h5>Global Support</h5>
                                	Here you can write a feature description for your dashboard, let the users know what is the value that you give them.
                            	</div>
                        	</div>
                    	</div>
                    	<div class="col-md-4">
                        	<form method="#" action="#">
                            	<div class="card card-plain">
                                	<div class="content">
                                    	<div class="form-group">
                                        	<input type="email" placeholder="Your First Name" class="form-control">
                                    	</div>
                                    	<div class="form-group">
                                        	<input type="email" placeholder="Your Last Name" class="form-control">
                                    	</div>
                                    	<div class="form-group">
                                        	<input type="email" placeholder="Company" class="form-control">
                                    	</div>
                                    	<div class="form-group">
                                        	<input type="email" placeholder="Enter email" class="form-control">
                                    	</div>
                                    	<div class="form-group">
                                        	<input type="password" placeholder="Password" class="form-control">
                                    	</div>
                                    	<div class="form-group">
                                        	<input type="password" placeholder="Password Confirmation" class="form-control">
                                    	</div>
                                	</div>
                                	<div class="footer text-center">
                                    	<button type="submit" class="btn btn-fill btn-danger btn-wd">Create Free Account</button>
                                	</div>
                            	</div>
                        	</form>
                    	</div>
                	</div>
            	</div>
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
</body>

	<!--   Core JS Files. Extra: TouchPunch for touch library inside jquery-ui.min.js   -->
	<script src="../assets/js/jquery-3.1.1.min.js" type="text/javascript"></script>
	<script src="../assets/js/jquery-ui.min.js" type="text/javascript"></script>
	<script src="../assets/js/perfect-scrollbar.min.js" type="text/javascript"></script>
	<script src="../assets/js/bootstrap.min.js" type="text/javascript"></script>

	<!--  Forms Validations Plugin -->
	<script src="../assets/js/jquery.validate.min.js"></script>

	<!-- Promise Library for SweetAlert2 working on IE -->
	<script src="../assets/js/es6-promise-auto.min.js"></script>

	<!--  Plugin for Date Time Picker and Full Calendar Plugin-->
	<script src="../assets/js/moment.min.js"></script>

	<!--  Date Time Picker Plugin is included in this js file -->
	<script src="../assets/js/bootstrap-datetimepicker.js"></script>

	<!--  Select Picker Plugin -->
	<script src="../assets/js/bootstrap-selectpicker.js"></script>

	<!--  Switch and Tags Input Plugins -->
	<script src="../assets/js/bootstrap-switch-tags.js"></script>

	<!-- Circle Percentage-chart -->
	<script src="../assets/js/jquery.easypiechart.min.js"></script>

	<!--  Charts Plugin -->
	<script src="../assets/js/chartist.min.js"></script>

	<!--  Notifications Plugin    -->
	<script src="../assets/js/bootstrap-notify.js"></script>

	<!-- Sweet Alert 2 plugin -->
	<script src="../assets/js/sweetalert2.js"></script>

	<!-- Vector Map plugin -->
	<script src="../assets/js/jquery-jvectormap.js"></script>

	<!--  Google Maps Plugin    -->
	<script src="https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE"></script>

	<!-- Wizard Plugin    -->
	<script src="../assets/js/jquery.bootstrap.wizard.min.js"></script>

	<!--  Bootstrap Table Plugin    -->
	<script src="../assets/js/bootstrap-table.js"></script>

	<!--  Plugin for DataTables.net  -->
	<script src="../assets/js/jquery.datatables.js"></script>

	<!--  Full Calendar Plugin    -->
	<script src="../assets/js/fullcalendar.min.js"></script>

	<!-- Paper Dashboard PRO Core javascript and methods for Demo purpose -->
	<script src="../assets/js/paper-dashboard.js"></script>

	<!-- Paper Dashboard PRO DEMO methods, don't include it in your project! -->
	<script src="../assets/js/demo.js"></script>

	<script type="text/javascript">
        $().ready(function(){
            demo.checkFullPageBackgroundImage();

            setTimeout(function(){
                // after 1000 ms we add the class animated to the login/register card
                $('.card').removeClass('card-hidden');
            }, 700)
		});
	</script>

</html>
