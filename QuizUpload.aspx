<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuizUpload.aspx.cs" Inherits="Interactive_Learning_Portal.QuizUpload" %>

<!DOCTYPE html>
<html lang="en">
	
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Shiksha | Contact</title>
		
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
                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton></li>
							</ul>
						</div>
					<!-- Navbar Collapse Ends -->
					</div>
				</nav>
			<!-- Navbar Ends -->
			</div>
		<!-- Nested Container Ends -->
		</header><!-- Header Ends -->
	<!-- Main Banner Starts -->
		<div class="main-banner five">
			<div class="container">
				<h2><span>Contact Us</span></h2>
			</div>
		</div>
	<!-- Main Banner Ends -->
	<!-- Breadcrumb Starts -->
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="index.aspx">Home</a></li>
					<li class="active">Quiz Upload</li>
				</ul>
			</div>
		</div>		
	<!-- Breadcrumb Ends -->
	<!-- Main Container Starts -->
		<div class="container main-container">
			<div class="contact-content">
				<div class="row">
                    <div class="alert alert-danger" id="alert" runat="server">
  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
  <strong>
      <asp:Label ID="Label1" runat="server"></asp:Label></strong>
</div>
				<!-- Contact Form Starts -->
					<div class="col-sm-8 col-md-offset-2 col-xs-12">
						<h3>Write questions and answers here carefully.</h3>
						<div class="status alert alert-success contact-status"></div>
						
							<div class="row">
                                <div class="col-xs-12">
									<div class="form-group">
										<label for="message">Question: </label>
										<textarea class="form-control" rows="4" id="question" runat="server"></textarea>
									</div>
								</div>
							<!-- Name Field Starts -->
								<div class="col-md-6">
									<div class="form-group">
										<label for="name">Option 1 </label>
										<input type="text" class="form-control"  id="ans1" runat="server">
									</div>
								</div>
							<!-- Name Field Ends -->
							<!-- Email Field Starts -->
								<div class="col-md-6">
									<div class="form-group">
										<label for="email">Option 2 </label>
										<input type="text" class="form-control" id="ans2" runat="server">
									</div>
								</div>
							<!-- Email Field Ends -->
							<!-- Phone No Field Starts -->
								<div class="col-md-6">
									<div class="form-group">
										<label for="phoneno">Option 3 </label>
										<input type="text" class="form-control" id="ans3" runat="server">
									</div>
								</div>
							<!-- Phone No Field Ends -->
							<!-- Subject Field Starts -->
								<div class="col-md-6">
									<div class="form-group">
										<label for="subject">Option 4 </label>
										<input type="text" class="form-control" id="ans4" runat="server">
									</div>
								</div>
							<!-- Subject Field Ends -->
							<!-- Message Field Starts -->
								 <div class="form-group">
                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Correct Answer</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                             <select class="form-control" id="ca" runat="server">
                                            <option value="">Choose Correct Answer</option>
                                            <option value="A">A</option>
                                            <option value="B">B</option>
                                            <option value="C">C</option>
                                            <option value="D">D</option>
                                        </select>
                                    </div>
                                </div>	
							<!-- Message Field Ends -->
								<div class="col-xs-12">
                                    <asp:Button ID="Button1" CssClass="btn btn-black text-uppercase" OnClick="Button1_Click" runat="server" Text="Submit" />
                                 
								</div>
							</div>
						
					</div>
				<!-- Contact Form Ends -->
		
				</div>
			</div>
		<!-- Contact Content Ends -->
		</div>
	
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
            <div id="UQuiz" runat="server" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        
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
                                                 <option value="Data Structure">Data Structures</option>
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
          <asp:Button ID="Button2" OnClick="ututorial_Click1" CssClass="btn btn-default" runat="server" Text="Next" />
        
          
        
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
</html>