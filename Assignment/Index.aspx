<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Assignment.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<title>Home</title>

	<link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap-responsive.min.css">
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<link rel='stylesheet' type='text/css' href='css/opensans.css'>
	<link href='http://fonts.googleapis.com/css?family=Jura:400,600,500,300' rel='stylesheet' type='text/css'>
</head>
<body>
	<div class="navbar">
		<div class="navbar-banner">
			<div class="container">
				<a class="brandname pull-left">
					<img src="resources/img/logo.png" />Electronic
					<strong>Shop</strong>
				</a>
				<h5 class="font-bold font-white pull-right">Call us now: 1800 000 000</h5>				
			</div>
		</div>
		<div class="navbar-inner">
			<div class="container">
				<div class="nav-collapse collapse">
					<ul class="nav">
						<li class="active">
							<a href="./index.html">Home</a>
						</li>
						<li class="">
							<a href="#">About Us</a>
						</li>
						<li class="">
							<a href="#">Shop Online</a>
						</li>
						<li class="">
							<a href="#">Visit Us</a>
						</li>
					</ul>
					<ul class="nav pull-right">
						<li class="">
							<a href="#"><img class="shopping_cart" src="resources/img/shopping_cart.png" />Cart: 0</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
	</div>

	<div class="jumbotron">
		<div class="container">
			<div class="row-fluid">
				<div class="span7">
					<h2 class="font-bold">Technology you can trust</h2>
					<h5 class="font-bold font-red">Get the best deals here.</h5>
					<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
					<p>Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
					<button class="btn-red btn-large">More Info</button>
				</div>
				<div class="span5">
					<img src="resources/img/feature.png" class="pull-right" />
				</div>
			</div>
		</div>
	</div>

	<div class="container">
		<div class="row-fluid categories border-bottom">
			<div class="span2 text-center">
				<img src="resources/img/mobile.jpg" />
				<h6>Mobile</h6>
				<button class="btn-red btn-large">More Info</button>
			</div>
			<div class="span2 offset1 text-center">
				<img src="resources/img/laptop.jpg" />
				<h6>Laptops</h6>
				<button class="btn-red btn-large">More Info</button>
			</div>
			<div class="span2 offset1 text-center">
				<img src="resources/img/computer.jpg" />
				<h6>Computers</h6>
				<button class="btn-red btn-large">More Info</button>
			</div>
			<div class="span2 offset1 text-center">
				<img src="resources/img/accessory.jpg" />
				<h6>Accessories</h6>
				<button class="btn-red btn-large">More Info</button>
			</div>
		</div>

		<div class="row-fluid">
			<div class="span6 feature-box">
				<img src="resources/img/best_sellers.jpg" class="pull-right" />
				<h4><span class="font-red">Best</span> Sellers</h4>
				<p>
					Lorem ipsum dolor sit amet, consectetur adipisicing elit.
				</p>
			</div>
			<div class="span6 feature-box">
				<img src="resources/img/new_arrivals.jpg" class="pull-right" />
				<h4><span class="font-red">New</span> Arrivals</h4>
				<p>
					Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
				</p>
			</div>
		</div>

		<div class="row-fluid">
			<div class="span6 feature-box">
				<img src="resources/img/deals.jpg" class="pull-right" />
				<h4><span class="font-red">Deals</span></h4>
				<p>
					Consectetur adipisicing elit.
				</p>
			</div>
			<div class="span6 feature-box">
				<img src="resources/img/help_center.jpg" class="pull-right" />
				<h4><span class="font-red">Help</span> Center</h4>
				<p>
					Eiusmod tempor incididunt ut labore et dolore magna aliqua.
				</p>
			</div>
		</div>
	</div>

	<div class="footer text-center">
		<p>&COPY; Company 2013</p>
	</div>

</body>
</html>
