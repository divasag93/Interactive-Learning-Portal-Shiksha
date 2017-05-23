<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentProfile.aspx.cs" Inherits="Interactive_Learning_Portal.StudentProfile" %>

<!DOCTYPE html>
<html lang="en">
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Student Profile | Shiksha</title>
		
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
		<div class="main-banner three">
			<div class="container">
				<h2><span>Student- Edit Student Profile</span></h2>
			</div>
		</div>
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="Student.aspx">Home</a></li>
					
                    <li class="active">Edit Profile</li> 
				</ul>
			</div>
		</div>		
		<div class="container main-container">
		<div class="tabs-wrap">
				<div class="tab-content">
						<div class="tab-pane fade in active" id="tab-1">
					
                        			<div class="row">
					<div class="col-sm-8 col-xs-12 col-md-12">
						<div class="status alert alert-success contact-status"></div>
					
							<div class="row">
						
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Name </label>
										<input type="text" class="form-control" pattern="(?=.*[a-z])(?=.*[A-Z]).{2,}" disabled="disabled" placeholder="Enter Name" id="name" runat="server" required="required">
									</div>
								</div>
							
                                		<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Roll No.</label>
										<input type="text" class="form-control" id="rollno" runat="server" placeholder="Enter Roll No." disabled="disabled" required="required">
									</div>
								</div>
						
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Father's Name </label>
										<input type="text" class="form-control" pattern="(?=.*[a-z])(?=.*[A-Z]).{2,}"  id="fname" runat="server" disabled="disabled" placeholder="Enter Father's Name" required="required">
									</div>
								</div>
                                
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Mother's Name </label>
										<input type="text" class="form-control" pattern="(?=.*[a-z])(?=.*[A-Z]).{2,}"  id="mname" runat="server" placeholder="Enter Mother's Name" disabled="disabled" required="required">
									</div>
								</div>
							
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>DOB</label>
										<input type="date" class="form-control" id="dob" runat="server" required="required" disabled="disabled">
									</div>
								</div>
							
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Course </label>
										<input type="text" class="form-control" disabled="disabled"  id="course" runat="server" required="required">
									</div>
								</div>
							
								<div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Branch</label>
										<input type="text" class="form-control text-uppercase" id="branch" placeholder="Enter Branch" runat="server" required="required" disabled="disabled">
									</div>
								</div>

                                    <div class="col-md-6 col-xs-12 col-sm-12">
									<div class="form-group">
										<label>Batch</label>
										<input type="text" class="form-control" id="batch" placeholder="Enter Batch" runat="server"  required="required" disabled="disabled">
									</div>
								</div>	
                            <div class="col-md-6 col-xs-12 col-sm-12">
                                <div class="form-group">
                                    <label>Contact No.</label>
                                    <input type="text" class="form-control" pattern="[789][0-9]{9}" id="pno" placeholder="Enter Contact No." runat="server" required="required">
                                </div>
                            </div>
                                <div class="col-md-6 col-xs-12 col-sm-12">
                                    <div class="form-group">
                                        <label>Email-ID</label>
                                        <input type="email" class="form-control" id="email" runat="server" placeholder="Enter Email ID" required="required" disabled="disabled">
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
                                        <select class="form-control" id="semester" runat="server" required="required" disabled="disabled">
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