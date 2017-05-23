<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpStudent.aspx.cs" Inherits="Interactive_Learning_Portal.SignUpStudent" %>

<!DOCTYPE html>
<html lang="en">
	
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Register | Shiksha</title>
		
		<link href="css/bootstrap.min.css" rel="stylesheet">
		
		<link href="https://fonts.googleapis.com/css?family=Lato:400,100,100italic,300,300italic,400italic,700,700italic,900,900italic" rel="stylesheet" type="text/css">
		<link href="https://fonts.googleapis.com/css?family=Roboto:400,100,300,100italic,300italic,400italic,500,500italic,700,700italic,900,900italic" rel="stylesheet" type="text/css">
		
		<link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
		<link href="js/plugins/camera/css/camera.css" rel="stylesheet">
		<link href="js/plugins/magnific-popup/magnific-popup.css" rel="stylesheet">
		<link href="css/style.css" rel="stylesheet">
		<link href="css/responsive.css" rel="stylesheet">
		
		  <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
		  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
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
							<a href="index.aspx" class="navbar-brand">
								<i class="fa fa-mobile"></i>
								Shiksha
							</a>
						</div>
						
						</div>
				</nav>
			</div>
		</header>
		<div class="main-banner three">
			<div class="container">
				<h2>Register&nbsp;</h2>
			</div>
		</div>
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="index.aspx">Home</a></li>
                    <li class="active">Register</li> 
				</ul>
			</div>
		</div>		
		<div class="container main-container">
			<div class="tabs-wrap">
				<div class="tab-content">
					<div class="tab-pane fade in active" id="tab-1">
					 <div class="alert alert-danger" id="alert" runat="server">
  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
  <strong>
      <asp:Label ID="Label2" runat="server"></asp:Label></strong>
</div>
                         <div class="alert alert-success" id="alert1" runat="server">
  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
  <strong>
      <asp:Label ID="Label1" runat="server"></asp:Label></strong>
</div>
                        			<div class="row">
					<div class="col-sm-8 col-xs-12 col-md-12">
						<div class="status alert alert-success contact-status"></div>
					
							<div class="row">
						
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Name </label>
										<input type="text" class="form-control" placeholder="Enter Name" id="name" runat="server" required="required">
									</div>
								</div>
							
                                		<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Roll No.</label>
										<input type="number" class="form-control" id="rollno" pattern="[0-9]{10}" min="10" runat="server" placeholder="Enter Roll No." required="required">
									</div>
								</div>
						
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Father's Name </label>
										<input type="text" class="form-control"  id="fname" runat="server" placeholder="Enter Father's Name" required="required">
									</div>
								</div>
                                
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Mother's Name </label>
										<input type="text" class="form-control"  id="mname" runat="server" placeholder="Enter Mother's Name" required="required">
									</div>
								</div>
							
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>DOB</label>
										<input type="date" class="form-control" id="dob" runat="server" required="required">
									</div>
								</div>
							
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Course </label>
										<input type="text" class="form-control" id="course" runat="server" required="required" placeholder="Enter Course">
									</div>
								</div>
							
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Branch</label>
										<input type="text" class="form-control text-uppercase" id="branch" placeholder="Enter Branch" runat="server" required="required">
									</div>
								</div>

                                    <div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Batch</label>
										<input type="text" class="form-control" id="batch" placeholder="Enter Batch" runat="server"  required="required">
									</div>
								</div>	
                            <div class="col-md-6 col-xs-12 col-sm-12">
                                <div class="form-group">
                                    <label>Contact No.</label>
                                    <input type="text" class="form-control" id="pno" placeholder="Enter Contact No." runat="server" required="required">
                                </div>
                            </div>
                                <div class="col-md-6 col-xs-12 col-sm-12">
                                    <div class="form-group">
                                        <label>Email-ID</label>
                                        <input type="email" class="form-control" id="email" runat="server" placeholder="Enter Email ID" required="required">
                                    </div>
                                </div>

                                <div class="col-md-6 col-xs-12 col-sm-12">
                                    <div class="form-group">
                                        <label>Address: </label>
                                        <asp:TextBox ID="address"  runat="server" class="form-control" required="required" TextMode="MultiLine"></asp:TextBox>
                                       
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Semester</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                        <select class="form-control" id="semester" runat="server" required="required">
                                            <option value="">Choose semester</option>
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
                                
                                
							
								<div class="col-xs-12 col-sm-12">
                                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-black text-uppercase" OnClick="Button1_Click" Text="submit" />
								
								</div>
                                
				</div>
                        	
                    </div>
						
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
