<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Interactive_Learning_Portal.Admin" %>

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
		<div class="main-banner two">
			<div class="container">
				<h2><span>Admin</span></h2>
			</div>
		</div>
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="#">Home</a></li>
					<li class="active">Admin</li>
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
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/sreg.gif" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
                                        <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" CssClass="btn btn-secondary" runat="server">Student Registration</asp:LinkButton>
										
									</div>
								</div>
							</div>
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/treg.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton2" OnClick="LinkButton2_Click" CssClass="btn btn-secondary" runat="server">Teachers Registration</asp:LinkButton>
										
									</div>
								</div>
							</div>
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/details.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton3" OnClick="LinkButton3_Click" CssClass="btn btn-secondary" runat="server">View Details</asp:LinkButton>
										
									</div>
								</div>
							</div>
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/query.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton4" OnClick="LinkButton4_Click" CssClass="btn btn-secondary" runat="server">Queries</asp:LinkButton>
										
									</div>
								</div>
							</div>
						      <div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/Results.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton5" OnClick="LinkButton5_Click" CssClass="btn btn-secondary" runat="server">Results</asp:LinkButton>
										
									</div>
								</div>
							</div>
                            <div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/q1.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton6" CssClass="btn btn-secondary" href="#Delete" data-toggle="modal" data-target="#Delete" runat="server">Delete Quiz</asp:LinkButton>
										
									</div>
								</div>
							</div>

                              <div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/um.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										<asp:LinkButton ID="LinkButton8" OnClick="LinkButton8_Click" CssClass="btn btn-secondary" runat="server">Update Events & News</asp:LinkButton>
										
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
		</footer>
	           <div id="Delete" runat="server" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Upload Quiz</h4>
      </div>
      <div class="modal-body">

          <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Subject</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                             <select class="form-control" id="subject" runat="server" required="required">
                                            <option value="">Choose Subject</option>
                                            <option value="Physics">Physics</option>
                                            <option value="Chemistry">Chemistry</option>
                                            <option value="CSPC">CSPC</option>
                                                 <option value="Mechanics">Mechanics</option>
                                                 <option value="Data Structure">Data Structure</option>
                                                 <option value="DLD">DLD</option>
                                                 <option value="TAFL">TAFL</option>
                                                 <option value="DSGT">DSGT</option>
                                                 <option value="Economics">Economics</option>
                                                 <option value="DAA">DAA</option>
                                                 <option value="PA">PA</option>
                                                 <option value="CN">CN</option>
                                                 <option value="Data Compression">Data Compression</option>
                                                 <option value="Image Processing">Image Processing</option>
                                                 <option value="DS">DS</option>
                                                 <option value="Web Technology">Web Technology</option>
                                                 <option value="Microprocessor">Microprocessor</option>
                                                 <option value="DS">DS</option>
                                                 <option value="NAS">NAS</option>
                                                 <option value="Thermo">Thermo</option>
                                                 <option value="IP">IP</option>
                                                 <option value="ADE">ADE</option>
                                                 <option value="Maths3">Maths3</option>
                                                 <option value="IS">IS</option>
                                                 <option value="BSA">BSA</option>
                                                 <option value="Cyber Security">Cyber Security</option>
                                                 <option value="Control System">Control System</option>
                                                 <option value="SAS">SAS</option>
                                                 
                                        </select>
                                    </div>
                                </div><br /><br />
             <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Branch</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                             <select class="form-control" id="branch2" runat="server" required="required">
                                            <option value="">Choose Branch</option>
                                            <option value="CS">CS</option>
                                            <option value="IT">IT</option>
                                            <option value="EC">EC</option>
                                            
                                        </select>
                                    </div>
                                </div>	
      
        <br /><br />
             <div class="form-group">
                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Semester</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                        <select class="form-control" id="semester2" runat="server" required="required">
                                            <option value="">Choose Semester</option>
                                            <option value="1">1</option>
                                            <option value="2">2</option>
                                            <option value="3">3</option>
                                            <option value="4">4</option>
                                            <option value="5">5</option>
                                            <option value="6">6</option>
                                            <option value="7">7</option>
                                            <option value="8">8</option>
                                        </select>
                                    </div>
                                </div>	
         
      </div>
        <br />
      <div class="modal-footer">
          <asp:Button ID="Button2" OnClick="Button2_Click" CssClass="btn btn-default" runat="server" Text="Done" />
       
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