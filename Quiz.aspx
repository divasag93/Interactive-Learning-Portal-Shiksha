<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="Interactive_Learning_Portal.Quiz" %>

<!DOCTYPE html>
<html lang="en">
	
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Attempt Quiz | Shiksha</title>
    <script src="js/jquery.min.js"></script>
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
											<li><asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" runat="server">Logout</asp:LinkButton></li>
					
							</ul>
						</div>
						</div>
				</nav>
			</div>
		</header>
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li>Answer carefully!!! Negative Marks</li>
					
				</ul>
			</div>
		</div>		
		<div class="container main-container">
			<div class="tabs-wrap">
				<div class="tab-content">
					<div class="tab-pane fade in active" id="tab-1">
						<div class="row">
                            <div class="col-md-3 col-xs-12 col-sm-12">
                                <asp:Button ID="Start" runat="server" Text="Start Quiz" OnClick="Start_Click" />
                            </div>
                            <div class="col-md-6 col-sm-12 col-xs-12">
                            <asp:Label ID="Label1" runat="server" ></asp:Label>
                                <br />
                                <br />
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                </asp:RadioButtonList>
                                <br />
                                <br />
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                <br />
                                <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
						&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Reset" />
&nbsp;
                                <br />
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Home" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Mail Result" />
                                <br />
                                <br />
                                <br />
                                <br />
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
	
            <div id="Result" runat="server" class="modal fade" style="position:fixed;top:25%;" role="dialog">
  <div class="modal-dialog">

    <div class="modal-content">
      <div class="modal-header">
        
        <h4 class="modal-title">Upload Quiz</h4>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label3" runat="server" Text="Your Result :"></asp:Label>
          <asp:Label ID="Label2" runat="server"></asp:Label>
         
      </div>
       
      
    </div>

  </div>
</div>
	   
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