<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Interactive_Learning_Portal.index" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>
<html lang="en">
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>SRMS CET | Shiksha</title>
		
		<link href="css/bootstrap.min.css" rel="stylesheet">
		<link href="https://fonts.googleapis.com/css?family=Lato:400,100,100italic,300,300italic,400italic,700,700italic,900,900italic" rel="stylesheet" type="text/css">
		<link href="https://fonts.googleapis.com/css?family=Roboto:400,100,300,100italic,300italic,400italic,500,500italic,700,700italic,900,900italic" rel="stylesheet" type="text/css">
		
		<link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
		<link href="js/plugins/camera/css/camera.css" rel="stylesheet">
		<link href="js/plugins/magnific-popup/magnific-popup.css" rel="stylesheet">
		<link href="css/style.css" rel="stylesheet">
		<link href="css/responsive.css" rel="stylesheet">
		
		
		
		<link rel="apple-touch-icon-precomposed" sizes="144x144" href="images/fav-144.html">
		<link rel="apple-touch-icon-precomposed" sizes="114x114" href="images/fav-114.html">
		<link rel="apple-touch-icon-precomposed" sizes="72x72" href="images/fav-72.html">
		<link rel="apple-touch-icon-precomposed" href="images/fav-57.html">
		<link rel="shortcut icon" href="images/fav.html">
		
	</head>
	<body>
		<header class="main-header">
			<div class="container">
				<div class="top-bar hidden-sm hidden-xs">
					<div class="row">
						<div class="col-sm-6 col-xs-12 col-md-3 ">
                            <span><img src="img/SRMS_Logo.jpg" /></span> 
						</div>
                        <div class="col-sm-6 col-xs-12 col-md-6 ">
                            <h2>Shri Ram Murti Smarak Trust</h2>
                            </div>
                            <div class="col-sm-6 col-xs-12 col-md-3">
                                <ul class="list-unstyled list-inline">
                                    <li></li>
                                    <li><i class="fa fa-phone"></i>Contact: +91-999999999</li>
                                </ul>
                            </div>
                        </div>
				</div>
				<nav id="nav" class="navbar navbar-default" role="navigation">
					<div class="container-fluid">
						<div class="navbar-header">
							<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
								<span class="sr-only">Toggle navigation</span>
								<span class="icon-bar"></span>
								<span class="icon-bar"></span>
								<span class="icon-bar"></span>
							</button>
							<a href="index.aspx" class="navbar-brand">
								<i class="fa fa-mobile"></i>
								Shiksha
							</a>
							</div>
						<div class="navbar-collapse collapse">
							<ul class="nav navbar-nav navbar-right">
								<li class="active"><a href="index.aspx">Home</a></li>
								<li><a href="StudentLogin.aspx">Student</a></li>
								<li><a href="TeacherLogin.aspx">Teacher</a></li>
								
                                <li><a href="AdminLogin.aspx">Admin   </a></li>
								
						    	<li><a href="Forum_Login.aspx">Forum</a></li>
								
							
								
								<li><a href="Contact.aspx">Contact</a></li>
							</ul>
						</div>
				
					</div>
				</nav>
			
			</div>
		
		</header>
		<section class="slider clearfix">
			<div id="camera_wrap_1" class="camera_wrap camera_white_skin">
				<div data-src="img/1.jpg">
					<div class="camera_caption fadeFromLeft hidden-sm hidden-xs">
						<h2>One Stop Solution</h2>
						<h2>For All <span>Learning</span></h2>
						
						
					</div>
				</div>
			<div data-src="img/2.jpg">
					<div class="camera_caption fadeIn hidden-sm hidden-xs">
						<h2>All your College</h2>
						<h2><span>Is in your</span> Hand</h2>
						
					</div>
				</div>
				<div data-src="img/6.png">
					<div class="camera_caption fadeIn hidden-sm hidden-xs">
                        <h2>All your College</h2>
                        <h2><span>Is in your</span> Hand</h2>
						
					</div>
				</div>
			</div>
		</section>
	<div class="container">
        <div class="row" style="height:20px"></div>
        <div class="row">
            <div class="col-md-1 col-xs-12 col-sm-12"></div>  
            <div class="col-md-4 col-xs-12 col-sm-12">
                <div class="panel panel-primary">
                    <div class="panel-heading" style="text-align:center">News</div>
                    <div class="panel-body">
                        <ul>
                            <% SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "select * from Latest where Type='news' order by Lid desc";
                SqlCommand cmd = new SqlCommand(str, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) { 
                %>
                            <li><%=dr[2].ToString() %></li>
                    <%
                }
                cn.Close(); %>
                        </ul> 
                    </div>
                </div>
            </div> 
            <div class="col-md-2 col-xs-12 col-sm-12"></div>  
            <div class="col-md-4 col-xs-12 col-sm-12">
                <div class="panel panel-primary">
                    <div class="panel-heading" style="text-align:center">Events</div>
                    <div class="panel-body">
                        <ul>
                              <% SqlConnection cn1 = new SqlConnection();
                cn1.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn1.Open();
                string str1 = "select * from Latest where Type='event' order by Lid desc";
                SqlCommand cmd1 = new SqlCommand(str1, cn1);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                while (dr1.Read()) { 
                %>
                            <li><%=dr1[2].ToString() %></li>
                    <%
                }
                cn1.Close(); %>
                            
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
		<footer class="main-footer">
			<div class="copyright">
				<div class="container clearfix">
					<p class="pull-left">
						&copy; COPYRIGHT 2017. AlL Rights Reserved By <span>Shiksha</span>
					</p>
					<ul class="list-unstyled list-inline pull-right">
							<li><a href="Contact.aspx">Contact Us</a></li>
					</ul>
				</div>
			</div>
		</footer>
	
	<script src="js/jquery-1.11.3.min.js"></script>
	<script src="js/jquery-migrate-1.2.1.min.js"></script>	
	<script src="js/bootstrap.min.js"></script>
        <script src="js/jquery.min.js"></script>
	<script src="js/plugins/camera/js/jquery.mobile.customized.min.js"></script>
	<script src="js/plugins/camera/js/jquery.easing.1.3.js"></script>
	<script src="js/plugins/camera/js/camera.min.js"></script>	
	<script src="js/plugins/shuffle/jquery.shuffle.modernizr.min.js"></script>
	<script src="js/plugins/magnific-popup/jquery.magnific-popup.min.js"></script>
	<script src="https://maps.googleapis.com/maps/api/js"></script>	
	<script src="js/custom.js"></script>	
	</body>
</html>