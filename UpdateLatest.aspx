<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateLatest.aspx.cs" Inherits="Interactive_Learning_Portal.UpdateLatest" %>

<!DOCTYPE html>
<html lang="en">
	
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Admin | Shiksha</title>
		
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
        <form id="form1" runat="server">
		<header class="main-header">
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
							<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
								<span class="sr-only">Toggle navigation</span>
								<span class="icon-bar"></span>
								<span class="icon-bar"></span>
								<span class="icon-bar"></span>
							</button>
							<a href="#" class="navbar-brand">
								<i class="fa fa-mobile"></i>
								Shiksha
							</a>
						
						</div>
						<div class="navbar-collapse collapse">
							<ul class="nav navbar-nav navbar-right">
								
								<li><asp:LinkButton ID="LinkButton7" OnClick="LinkButton7_Click" runat="server">Logout</asp:LinkButton></li>
							</ul>
						</div>
					
					</div>
				</nav>
			
			</div>
		
		</header>
		<div class="main-banner three">
			<div class="container">
				<h2><span>Update Events & News</span></h2>
			</div>
		</div>
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="#">Home</a></li>
					<li class="active">Update Events & News</li>
				</ul>
			</div>
		</div>		
		<div class="container main-container">
			<div class="tabs-wrap">
				<div class="tab-content">
					<div class="tab-pane fade in active" id="tab-1">
						<div class="row">
                             <div class="alert alert-success" id="alert1" runat="server">
  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
  <strong>
      <asp:Label ID="Label1" runat="server"></asp:Label></strong>
</div>
							<div class="col-md-10 col-md-offset-1 col-sm-6 col-xs-12">
								<h4>What's new in Events...?</h4>
                                <textarea class="form-control" rows="4" id="events" runat="server"></textarea>
                                <br />
                                <asp:Button ID="Button1" CssClass="btn btn-black text-uppercase" OnClick="Button1_Click" runat="server" Text="Update Event" />
								</div>
							
							<div class="col-md-10 col-md-offset-1 col-sm-6 col-xs-12">
								<h4>What's new in News...?</h4>
                                <textarea class="form-control" rows="4" id="news" runat="server"></textarea>
                                <br />
                                <asp:Button ID="Button2" CssClass="btn btn-black text-uppercase" OnClick="Button2_Click" runat="server" Text="Update News" />
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
		</footer>
	           
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
</html>