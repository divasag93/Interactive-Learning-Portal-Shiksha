<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher.aspx.cs" Inherits="Interactive_Learning_Portal.Teacher" %>

<!DOCTYPE html>
<html lang="en">
	
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Teacher | Shiksha</title>
		
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
        <form id="form1" runat="server">
	<!-- Header Starts -->
		<header class="main-header">
		<!-- Nested Container Starts -->
			<div class="container">
			<!-- Top Bar Starts -->
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
			<!-- Top Bar Ends -->
			<!-- Navbar Starts -->
				<nav id="nav" class="navbar navbar-default" role="navigation">
					<div class="container-fluid">
					<!-- Navbar Header Starts -->
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
							<a href="index.aspx" class="navbar-brand">
								<i class="fa fa-mobile"></i>
								Shiksha
							</a>
						<!-- Logo Ends -->
						</div>
					<!-- Navbar Header Ends -->
					<!-- Navbar Collapse Starts -->
						<div class="navbar-collapse collapse">
							<ul class="nav navbar-nav navbar-right">
<li>
                                    <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" runat="server">Logout</asp:LinkButton></li>
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
		<div class="main-banner two">
			<div class="container">
				<h2><span>Teacher</span></h2>
			</div>
		</div>
	<!-- Main Banner Ends -->
	<!-- Breadcrumb Starts -->
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="index.aspx">Home</a></li>
					<li class="active">Teacher</li>
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
                             <div class="alert alert-danger" id="alert" runat="server">
  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
  <strong>
      <asp:Label ID="Label2" runat="server"></asp:Label></strong>
</div>
						<!-- Box #1 Starts -->
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/um.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
                                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CssClass="btn btn-secondary">Upload Material</asp:LinkButton>
										
									</div>
								</div>
							</div>
						<!-- Box #1 Ends -->
						<!-- Box #2 Starts -->
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/uploadquiz.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" CssClass="btn btn-secondary">Upload Quiz</asp:LinkButton>
										
									</div>
								</div>
							</div>
						<!-- Box #2 Ends -->
						<!-- Box #3 Starts -->
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/result.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" CssClass="btn btn-secondary">Student Result</asp:LinkButton>
										
									</div>
								</div>
							</div>
						<!-- Box #3 Ends -->
						<!-- Box #4 Starts -->
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/changepass.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton5" runat="server" href="#ChangePass" data-toggle="modal" data-target="#ChangePass" CssClass="btn btn-secondary">Change Password</asp:LinkButton>
										
									</div>
								</div>
							</div>
				
			</div></div>
				
				</div>
			<!-- Tab Content Ends -->
			</div>
		<!-- Services Tab Ends -->
		</div>
	<!-- Main Container Ends -->
	<!-- Footer Starts -->
		<footer class="main-footer">
		<!-- Footer Area Starts -->
			
		<!-- Footer Area Ends -->
		<!-- Copyright Starts -->
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

 
            <div id="ChangePass" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Change Password</h4>
      </div>
      <div class="modal-body">


        
                                <div class="form-group">
                                    <label>New Password</label>
                                    <input type="password" class="form-control"  id="newpass" placeholder="New Password" runat="server" required="required">
                                </div>
                           
     
                                <div class="form-group">
                                    <label>Confirm Password</label>
                                    <input type="password" class="form-control"  id="confirmpass" placeholder="ReEnter Password" runat="server" required="required">
                                </div>
                            </div>
     
      <div class="modal-footer">
          <asp:Button ID="Button1" OnClick="Button1_Click" CssClass="btn btn-default" runat="server" Text="Submit" />
 
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
   

  </div>
</div>
</div>
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
            </form>	
	</body>

<!-- Mirrored from sainathchillapuram.com/BS/mediplus/hosptails/html-fullwidth/services.html by HTTrack Website Copier/3.x [XR&CO'2014], Wed, 06 Apr 2016 19:07:11 GMT -->
</html>