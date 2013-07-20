<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Assignment.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<title>Electonic Shop</title>

	<link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css" />
	<link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap-responsive.min.css" />
	<link rel='stylesheet' type='text/css' href='css/OpenSans.css' />
	<link rel='stylesheet' type='text/css' href='css/MyriadPro.css' />
	<link rel="stylesheet" type="text/css" href="css/style.css" />

	<script type="text/javascript" src="js/jquery.min.js"></script>
	<script type="text/javascript" src="bootstrap/js/bootstrap.min.js"></script>
	<script type="text/javascript" src="js/validate.min.js"></script>
</head>
<body>

	<!-- navbar -->
	<div class="navbar">

		<!-- navbar-banner -->
		<div class="navbar-banner">
			<div class="container">
				<a class="brandname pull-left" href="Index.aspx">
					<img src="resources/img/logo.png" />Electronic
					<strong>Shop</strong>
				</a>
				<span class="contact">Call us now: 1800 000 000</span>
			</div>
		</div>
		<!--/ navbar-banner -->

		<!-- navbar-inner -->
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

					<form class="form-search">
						<div class="input-append">
							<input name="searchQuery" id="searchQuery" type="text" placeholder="Search" />
							<button class="btn" type="submit">Go</button>
						</div>
					</form>

					<ul class="nav pull-right">
						<li class="">
							<a href="#"><img class="shopping_cart" src="resources/img/shopping_cart.png" />Cart: 0</a>
						</li>
					</ul>

				</div><!--/ nav-collapse collapse -->
			</div><!--/ container -->		
		</div><!--/ navbar-inner -->

	</div><!--/ navbar -->

	<!-- jumbotron -->
	<div class="jumbotron">
		<div class="container">
			<div class="container-fluid">
				<div class="row-fluid">

					<div class="span7">
						<h2 class="font-bold">Technology you can trust</h2>
						<span class="subtitle">Get the best deals here.</span>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
						<p>Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
						<button class="btn-red btn-large">More Info</button>
					</div>

					<div class="span5">
						<img src="resources/img/feature.png" class="pull-right" />
					</div>

				</div><!--/ row-fluid -->
			</div><!--/ container-fluid -->
		</div><!--/ container -->
	</div><!--/ jumbotron -->

	<!-- content -->
	<div class="content">
		<div class="container">
			<div class="container-fluid">

				<!-- row-categories -->
				<div class="row-fluid row-categories">
					<div class="">
						<img src="resources/img/apple.jpg" />
						<h6>Apple</h6>
						<button class="btn-red btn-large">More Info</button>
					</div>
					<div class="">
						<img src="resources/img/android.jpg" />
						<h6>Android</h6>
						<button class="btn-red btn-large">More Info</button>
					</div>
					<div class="">
						<img src="resources/img/windows_phone.jpg" />
						<h6>Windows Phone</h6>
						<button class="btn-red btn-large">More Info</button>
					</div>
					<div class="">
						<img src="resources/img/blackberry.jpg" />
						<h6>Blackberry</h6>
						<button class="btn-red btn-large">More Info</button>
					</div>
					<div class="">
						<img src="resources/img/accessory.jpg" />
						<h6>Accessories</h6>
						<button class="btn-red btn-large">More Info</button>
					</div>
				</div><!--/ row-categories -->

				<!-- row-products -->
				<div class="row row-products">
					<a href="#" class="clearfix">
						<h3><span class="font-red">Special</span> Deals</h3>
						<span>View more&nbsp;&raquo; </span>
					</a>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/apple-4397-74964-1-catalog.jpg" />
							Apple iPad 4 (with Retina display) - 32GB / Wifi / White
							<span class="old-product-price">681.5 $</span>
							<span class="product-price">634.453 $</span>
							<span class="product-discount-rate">-7 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/samsung-3642-11236-1-catalog.jpg" />
							Samsung Galaxy S4 (i9500) - Full HD 4.99'' / 13MP / 16GB / White
							<span class="old-product-price">715.763 $</span>
							<span class="product-price">704.953 $</span>
							<span class="product-discount-rate">-2 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/blackberry-2662-56776-1-catalog.jpg" />
							BlackBerry Z10 - LCD 4.2'' / 8MP / 16GB / Black
							<span class="old-product-price">728.5 $</span>
							<span class="product-price">633.513 $</span>
							<span class="product-discount-rate">-13 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/nokia-7194-07184-1-catalog.jpg" />
							Nokia Lumia 620 - TFT 3.8'' / 5MP / 8GB / Black
							<span class="old-product-price">246.7 $</span>
							<span class="product-price">225.553 $</span>
							<span class="product-discount-rate">-9 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
				</div><!--/ row-products -->

				<!-- row-products -->
				<div class="row row-products">
					<a href="#" class="clearfix">
						<h3><span class="font-red">Best</span> Sellers</h3>
						<span>View more&nbsp;&raquo; </span>
					</a>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/apple-4397-74964-1-catalog.jpg" />
							Apple iPad 4 (with Retina display) - 32GB / Wifi / White
							<span class="old-product-price">681.5 $</span>
							<span class="product-price">634.453 $</span>
							<span class="product-discount-rate">-7 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/samsung-3642-11236-1-catalog.jpg" />
							Samsung Galaxy S4 (i9500) - Full HD 4.99'' / 13MP / 16GB / White
							<span class="old-product-price">715.763 $</span>
							<span class="product-price">704.953 $</span>
							<span class="product-discount-rate">-2 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/blackberry-2662-56776-1-catalog.jpg" />
							BlackBerry Z10 - LCD 4.2'' / 8MP / 16GB / Black
							<span class="old-product-price">728.5 $</span>
							<span class="product-price">633.513 $</span>
							<span class="product-discount-rate">-13 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/nokia-7194-07184-1-catalog.jpg" />
							Nokia Lumia 620 - TFT 3.8'' / 5MP / 8GB / Black
							<span class="old-product-price">246.7 $</span>
							<span class="product-price">225.553 $</span>
							<span class="product-discount-rate">-9 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
				</div><!--/ row-products -->

				<!-- row-products -->
				<div class="row row-products">
					<a href="#" class="clearfix">
						<h3><span class="font-red">New</span> Arrivals</h3>
						<span>View more&nbsp;&raquo; </span>
					</a>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/apple-4397-74964-1-catalog.jpg" />
							Apple iPad 4 (with Retina display) - 32GB / Wifi / White
							<span class="old-product-price">681.5 $</span>
							<span class="product-price">634.453 $</span>
							<span class="product-discount-rate">-7 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/samsung-3642-11236-1-catalog.jpg" />
							Samsung Galaxy S4 (i9500) - Full HD 4.99'' / 13MP / 16GB / White
							<span class="old-product-price">715.763 $</span>
							<span class="product-price">704.953 $</span>
							<span class="product-discount-rate">-2 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/blackberry-2662-56776-1-catalog.jpg" />
							BlackBerry Z10 - LCD 4.2'' / 8MP / 16GB / Black
							<span class="old-product-price">728.5 $</span>
							<span class="product-price">633.513 $</span>
							<span class="product-discount-rate">-13 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
					<div class="product-box">
						<a href="#">
							<img src="resources/products/nokia-7194-07184-1-catalog.jpg" />
							Nokia Lumia 620 - TFT 3.8'' / 5MP / 8GB / Black
							<span class="old-product-price">246.7 $</span>
							<span class="product-price">225.553 $</span>
							<span class="product-discount-rate">-9 %</span>
						</a>
						<button class="btn-red btn-large">Add to Cart</button>
					</div>
				</div><!--/ row-products -->

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

			</div><!--/ container-fluid -->
		</div><!--/ container -->
	</div><!--/ content -->

	<div class="footer text-center">
		<p>&COPY; Company 2013</p>
	</div>

</body>
</html>
