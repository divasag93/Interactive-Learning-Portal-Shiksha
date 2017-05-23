<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadMaterial.aspx.cs" Inherits="Interactive_Learning_Portal.UploadMaterial" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		<title>Upload Material | Shiksha</title>
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
        <form runat="server">
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
									<li><a href="contact.html">Logout</a></li>
							</ul>
						</div>
					<!-- Navbar Collapse Ends -->
					</div>
				</nav>
				</div>
			</header>
	  
		<div class="main-banner three">
			<div class="container">
				<h2><span>Teacher: Upload Material's</span></h2>
			</div>
		</div>
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="index.aspx">Home</a></li>
					<li class="active">Upload Material</li>
				</ul>
			</div>
		</div>		
		<div class="container main-container">
			<div class="tabs-wrap">
				<div class="tab-content">
					<div class="tab-pane fade in active" id="tab-1">
						<div class="row">
                                    <div class="alert alert-danger" id="alert" runat="server">
  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
  <strong>
      <asp:Label ID="Label2" runat="server"></asp:Label></strong>
</div>
                              <div class="alert alert-success" id="alert1" runat="server">
  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
  <strong>
      <asp:Label ID="Label3" runat="server"></asp:Label></strong>
</div>
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/pp.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
                                        <a href="#pyquestion" data-toggle="modal" data-target="#pyquestion" class="btn btn-secondary">Upload Previous Year Papers</a>
									</div>
								</div>
							</div>
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/asg.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										
										<a href="#uassignments" data-toggle="modal" data-target="#uassignments" class="btn btn-secondary">Upload Assignment</a>
									</div>
								</div>
							</div>
							<div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/ut.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										
										<a href="#ututorials" data-toggle="modal" data-target="#ututorials" class="btn btn-secondary">Upload Tutorials</a>
									</div>
								</div>
							</div>
                            <div class="col-md-4 col-sm-6 col-xs-12">
								<div class="box1 text-center-xs">
									<img src="img/ul.jpg" alt="Blog Image" class="img-responsive img-center-sm img-center-xs">
									<div class="inner">
										
										<a href="#ulectures" data-toggle="modal" data-target="#ulectures" class="btn btn-secondary">Upload Lectures</a>
									</div>
								</div>
							</div>

                   


                            <asp:Label ID="Label1" runat="server"></asp:Label>
			</div></div>
			
				</div>
			</div>
		</div>
	
<!-- Modal -->
<div id="pyquestion" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Upload Previous Year Question Paper</h4>
          <br /><p>Only PDF</p>
      </div>
      <div class="modal-body">


        
            <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Branch</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                             <select class="form-control" id="branch" runat="server" name="size">
                                            <option value="">Chose Branch</option>
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
                                        <select class="form-control" id="semester" runat="server" name="size">
                                            <option value="">Chose Semester</option>
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
         
          <br />
          <br />
            <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Upload</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                        <asp:FileUpload ID="pyquestionupload" CssClass="form-control" runat="server" />
                                            
                                        
                                    </div>
                                </div>	
          
          
      </div>
        <br />
      <div class="modal-footer">
          <asp:Button ID="previousyearquestion" OnClick="previousyearquestion_Click" runat="server" class="btn btn-default" Text="Upload" />
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>

  </div>
</div>
       
<div id="uassignments" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Upload Assignments</h4>
          <p>Only PDF</p>
      </div>
      <div class="modal-body">


        
            <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Branch</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                             <select class="form-control" id="branch1" runat="server" name="size">
                                            <option value="">Chose Branch</option>
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
                                        <select class="form-control" id="semester1" runat="server" name="size">
                                            <option value="">Chose Semester</option>
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
         
          <br />
          <br />
            <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Upload</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                        <asp:FileUpload ID="uploadassignment" CssClass="form-control" runat="server" />
                                            
                                    </div>
                                </div>	
          
        <br />
      </div>
        <br />
      <div class="modal-footer">
          <asp:Button ID="uassignment" OnClick="uassignment_Click" class="btn btn-default" runat="server" Text="Upload" />
 
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>

        <div id="ututorials" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Upload Tutorials</h4>
          <p>Only PDF format supported</p>
      </div>
      <div class="modal-body">


             <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Branch</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                             <select class="form-control" id="branch2" runat="server" name="size">
                                            <option value="">Chose Branch</option>
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
                                        <select class="form-control" id="semester2" runat="server" name="size">
                                            <option value="">Chose Semester</option>
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
         
          <br />
          <br />
            <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Upload</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                        <asp:FileUpload ID="uploadtutorial" CssClass="form-control" runat="server" />
                                            
                                        
                                    </div>
                                </div>	
          
        
      </div>
        <br />
      <div class="modal-footer">
          <asp:Button ID="ututorial" OnClick="ututorial_Click" class="btn btn-default" runat="server" Text="Upload" />
 
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>

  </div>
</div>


               <div id="ulectures" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">Upload Lecture's</h4>
          <p>Only .mp4 format supported</p>
      </div>
      <div class="modal-body">


             <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Branch</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                             <select class="form-control" id="branch3" runat="server" name="size">
                                            <option value="">Chose Branch</option>
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
                                        <select class="form-control" id="semester3" runat="server" name="size">
                                            <option value="">Chose Semester</option>
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
         
          <br />
          <br />
            <div class="form-group">


                                    <label class="col-xs-12 col-md-6 col-sm-12 control-label">Upload</label>
                                    <div class="col-xs-12 col-md-6 col-sm-12 selectContainer">
                                  
                                        
                                        <asp:FileUpload ID="lectureupload" CssClass="form-control" runat="server" />
                                            
                                        
                                    </div>
                                </div>	
          
        
      </div>
        <br />
      <div class="modal-footer">
          <asp:Button ID="uploadlecture" OnClick="uploadlecture_Click" class="btn btn-default" runat="server" Text="Upload" />
 
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
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
	     </form>
	<script src="js/jquery-1.11.3.min.js"></script>
	<script src="js/jquery-migrate-1.2.1.min.js"></script>	
	<script src="js/bootstrap.min.js"></script>
	<script src="js/plugins/camera/js/jquery.mobile.customized.min.js"></script>
	<script src="js/plugins/camera/js/jquery.easing.1.3.js"></script>
	<script src="js/plugins/camera/js/camera.min.js"></script>	
	<script src="js/plugins/shuffle/jquery.shuffle.modernizr.min.js"></script>
	<script src="js/plugins/magnific-popup/jquery.magnific-popup.min.js"></script>
	<script src="js/custom.js"></script>		
	</body>
</html>