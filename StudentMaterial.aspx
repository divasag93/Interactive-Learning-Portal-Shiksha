<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentMaterial.aspx.cs" Inherits="Interactive_Learning_Portal.StudentMaterial" %>

<!DOCTYPE html>
<html lang="en">
	
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Student | Shiksha</title>
		
		<!-- Bootstrap -->
		<link href="css/bootstrap.min.css" rel="stylesheet">
		
		<!-- Google Web Fonts -->
		<link href="https://fonts.googleapis.com/css?family=Lato:400,100,100italic,300,300italic,400italic,700,700italic,900,900italic" rel="stylesheet" type="text/css">
		<link href="https://fonts.googleapis.com/css?family=Roboto:400,100,300,100italic,300italic,400italic,500,500italic,700,700italic,900,900italic" rel="stylesheet" type="text/css">
		
		<!-- Template CSS Files  -->
		<link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
		<link href="js/plugins/camera/css/camera.css" rel="stylesheet">
		<link href="js/plugins/magnific-popup/magnific-popup.css" rel="stylesheet">
		<link href="css/style.css" rel="stylesheet">
		<link href="css/responsive.css" rel="stylesheet">
		
		<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
		<!--[if lt IE 9]>
		  <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
		  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
		
		<!-- Fav and touch icons -->
		<link rel="apple-touch-icon-precomposed" sizes="144x144" href="images/fav-144.html">
		<link rel="apple-touch-icon-precomposed" sizes="114x114" href="images/fav-114.html">
		<link rel="apple-touch-icon-precomposed" sizes="72x72" href="images/fav-72.html">
		<link rel="apple-touch-icon-precomposed" href="images/fav-57.html">
		<link rel="shortcut icon" href="images/fav.html">
		
	</head>
	<body>
	<!-- Header Starts -->
		<header class="main-header">
		<!-- Nested Container Starts -->
			<div class="container">
                	<div class="top-bar hidden-sm hidden-xs">
					<div class="row">
						<div class="col-sm-6 col-xs-12 col-md-3 ">
                            <span><img src="img/SRMS_Logo.jpg" /></span> 
						</div>
                        <div class="col-sm-6 col-xs-12 col-md-6 ">
                            <h2>Shri Ram Murti Trust</h2>
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
						<!-- Collapse Button Starts -->
							<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
								<span class="sr-only">Toggle navigation</span>
								<span class="icon-bar"></span>
								<span class="icon-bar"></span>
								<span class="icon-bar"></span>
							</button>
						<!-- Collapse Button Ends -->
						<!-- Logo Starts -->
							<a href="#" class="navbar-brand">
								<i class="fa fa-mobile"></i>
								Shiksha
							</a>
						<!-- Logo Ends -->
						</div>
					<!-- Navbar Header Ends -->
					<!-- Navbar Collapse Starts -->
						<div class="navbar-collapse collapse">
							<ul class="nav navbar-nav navbar-right">
						
                                
                                
                      <li><a href="StudentLogin.aspx">Logout</a></li>     
                                		</ul>
						</div>
					<!-- Navbar Collapse Ends -->
					</div>
				</nav>
			<!-- Navbar Ends -->
			</div>
		<!-- Nested Container Ends -->
		</header>
	<!-- Header Ends -->
	<!-- Main Banner Starts -->
		<div class="main-banner three">
			<div class="container">
				<h2><span>Student Material</span></h2>
			</div>
		</div>
	<!-- Main Banner Ends -->
	<!-- Breadcrumb Starts -->
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="Student.aspx">Home</a></li>
					<li class="active">Student Material</li>
				</ul>
			</div>
		</div>		
	<!-- Breadcrumb Ends -->
	<!-- Main Container Starts -->
		<div class="container main-container">
		<!-- Services Tab Starts -->
			<div class="tabs-wrap">
			<!-- Nav Tabs Starts -->
			<!-- Nav Tabs Ends -->
			<!-- Tab Content Starts -->
				<div class="tab-content">
				<!-- Tab #1 Starts -->
					<div class="tab-pane fade in active" id="tab-1">
						<div class="row">
						<!-- Box #1 Starts -->
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/assignment.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										
										<a href="Assignment.aspx" class="btn btn-secondary">Assignments</a>
									</div>
								</div>
							</div>
						<!-- Box #1 Ends -->
						<!-- Box #2 Starts -->
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/tutorial.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										
										<a href="Tutorials.aspx" class="btn btn-secondary">Tutorials</a>
									</div>
								</div>
							</div>
						<!-- Box #2 Ends -->
						<!-- Box #3 Starts -->
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/previos.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										
										<a href="PreviousYear.aspx" class="btn btn-secondary">Previous Year Question Paper</a>
									</div>
								</div>
							</div>
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/previos.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										
										<a href="Lectures.aspx" class="btn btn-secondary">Lectures</a>
									</div>
								</div>
							</div>
			</div></div>
			
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
		<!-- Copyright Ends -->
		</footer>
	<!-- Footer Ends -->
	<!-- Template JS Files -->
	<script src="js/jquery-1.11.3.min.js"></script>
	<script src="js/jquery-migrate-1.2.1.min.js"></script>	
	<script src="js/bootstrap.min.js"></script>
	<script src="js/plugins/camera/js/jquery.mobile.customized.min.js"></script>
	<script src="js/plugins/camera/js/jquery.easing.1.3.js"></script>
	<script src="js/plugins/camera/js/camera.min.js"></script>	
	<script src="js/plugins/shuffle/jquery.shuffle.modernizr.min.js"></script>
	<script src="js/plugins/magnific-popup/jquery.magnific-popup.min.js"></script>
	<script src="https://maps.googleapis.com/maps/api/js"></script>	
	<script src="js/custom.js"></script>		
	</body>

</html>