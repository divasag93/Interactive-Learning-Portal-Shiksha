<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shiksha_Forum.aspx.cs" Inherits="Interactive_Learning_Portal.Shiksha_Forum" %>

<!DOCTYPE html>
<html lang="en">
<head>
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta name="description" content="">
		<meta name="author" content="">
		
		<title>Forum | Shiksha</title>
		
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
							<a href="index.aspx" class="navbar-brand">
								<i class="fa fa-mobile"></i>
								Shiksha
							</a>
							</div>
						<div class="navbar-collapse collapse">
							<ul class="nav navbar-nav navbar-right">
                                <asp:LinkButton ID="LinkButton6" OnClick="LinkButton6_Click" runat="server">Logout</asp:LinkButton>
														</ul>
						</div>
				
					</div>
				</nav>
			
			</div>
		
		</header>
		<div class="main-banner seven">
			<div class="container">
				<h2><span>Forum Login</span></h2>
			</div>
		</div>
		<div class="breadcrumb">
			<div class="container">
				<ul class="list-unstyled list-inline">
					<li><a href="index.aspx">Home</a></li>
					<li class="active">Forum Login</li>
				</ul>
			</div>
		</div>		
		<div class="container main-container">
            <div class="row">
                <div class="wrapper">
       <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
           <asp:Panel ID="Panel1" runat="server" BorderStyle="None">
               <asp:Panel ID="Panel2" runat="server" Visible="False" BorderStyle="Solid" 
                   BorderWidth="2" >
                  <asp:Panel ID="Panel12" runat="server">
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="false"></asp:Label>
                   </asp:Panel>
                   <asp:Panel ID="Panel3" runat="server">
                       &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="85px" TextMode="MultiLine" 
                           Width="776px"></asp:TextBox>
                       &#39;<br />
                       &nbsp;<asp:Button ID="Button1" runat="server" Text="Post Answer" 
                           onclick="Button1_Click" CssClass="button" Font-Bold="True" />
                       <br />
                   </asp:Panel>
               </asp:Panel>
               <br />
               <asp:Panel ID="Panel4" runat="server" Visible="False" BorderStyle="Solid" 
                   BorderWidth="2" BackColor="#CC99FF">
                   <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                   <asp:Panel ID="Panel13" runat="server">
                   </asp:Panel>
                   <br />
                   <asp:Panel ID="Panel5" runat="server">
                       &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="85px" TextMode="MultiLine" 
                           Width="776px"></asp:TextBox>
                       <br />
                       &nbsp;<asp:Button ID="Button2" runat="server" Text="Post Answer" 
                           onclick="Button2_Click" CssClass="button" Font-Bold="True" />
                       <br />
                   </asp:Panel>
               </asp:Panel>
               <br />
               <asp:Panel ID="Panel6" runat="server" Visible="False" BorderStyle="Solid" 
                   BorderWidth="2" BackColor="#CC99FF">
                   <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
                   <br />
                   <asp:Panel ID="Panel14" runat="server">
                   </asp:Panel>
                   <br />
                   <asp:Panel ID="Panel7" runat="server">
                       &nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="85px" TextMode="MultiLine" 
                           Width="776px"></asp:TextBox>
                       <br />
                      &nbsp; <asp:Button ID="Button3" runat="server" Text="Post Answer" 
                           onclick="Button3_Click" CssClass="button" Font-Bold="True" />
                   </asp:Panel>
               </asp:Panel>
               <br />
               <asp:Panel ID="Panel8" runat="server" Visible="False" BorderStyle="Solid" 
                   BorderWidth="2" BackColor="#CC99FF">
                   <asp:Label ID="Label5" runat="server" Text="Label" Visible="false"></asp:Label>
                   <asp:Panel ID="Panel15" runat="server">
                   </asp:Panel>
                   <br />
                   <asp:Panel ID="Panel9" runat="server">
                      &nbsp; <asp:TextBox ID="TextBox4" runat="server" Height="85px" TextMode="MultiLine" 
                           Width="776px"></asp:TextBox>
                       <br />
                      &nbsp; <asp:Button ID="Button4" runat="server" Text="Post Answer" 
                           onclick="Button4_Click" CssClass="button" Font-Bold="True" />
                   </asp:Panel>
               </asp:Panel>
               <br />
               <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">Post New Question</asp:LinkButton>
               <br />
               <asp:Panel ID="Panel10" runat="server" Visible="False">
                   <asp:Panel ID="Panel11" runat="server">
                       <asp:TextBox ID="TextBox5" runat="server" Height="85px" TextMode="MultiLine" 
                           Width="776px" BackColor="Silver"></asp:TextBox>
                       <br />
                       <asp:Button ID="Button5" runat="server" Text="Post Question" 
                           onclick="Button5_Click" CssClass="button" Font-Bold="True" />
                   </asp:Panel>
               </asp:Panel>
               


           </asp:Panel>
           <asp:UpdateProgress ID="UpdateProgress1" runat="server">
           </asp:UpdateProgress>
           <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">First</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Pre</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">Next</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">Last</asp:LinkButton>
<br />
               <br />
               <br />
               <br />
               <br />
               <br />
       </ContentTemplate>
    </asp:UpdatePanel>

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