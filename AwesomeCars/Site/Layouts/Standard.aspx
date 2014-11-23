<%@ Page language="c#" Codepage="65001" AutoEventWireup="true" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<%@ OutputCache Location="None" VaryByParam="none" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!--A Design by W3layouts
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE HTML>
<html>
<head>
<title>The Auto-Swift Website Template | Home :: w3layouts</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href='http://fonts.googleapis.com/css?family=Julius+Sans+One' rel='stylesheet' type='text/css'>
<link href="/css/style.css" rel="stylesheet" type="text/css" media="all" />
<!--slider-->
<link href="css/camera.css" rel="stylesheet" type="text/css" media="all" />
    <script type='text/javascript' src='/js/jquery.min.js'></script>
    <script type='text/javascript' src='/js/jquery.autocomplete.min.js'></script>
    <script type='text/javascript' src='/js/jquery.mobile.customized.min.js'></script>
    <script type='text/javascript' src='/js/jquery.easing.1.3.js'></script> 
</head>
<body>
    <form runat="server">
<!--start header-->
<div class="h_bg">
<div class="wrap">
<div class="wrapper">
<div class="header">
	<div class="logo">
		 <a href="/"><img src="/images/logo.png"> </a>
	</div>
	<div class="cssmenu">
	<ul>
	   <li class="active"><a href="/"><span>Home</span></a></li>
	      <li><a href=#""><span>About</span></a></li>
	   <li class="last"><a href="#"><span>Contact</span></a></li>
        <li class="last"><a href="/search"><span>Sarch</span></a></li>
	 <div class="clear"></div>
	 </ul>
	</div>
	<div class="clear"></div>
</div>
</div>
</div>
</div>
<sc:Placeholder runat="server" Key="carousel"/> 

<!-- start content -->
<div class="content_bg">
<div class="wrap">
<div class="wrapper">
	<div class="main">
	<!-- start content_left -->
	<div class="content_left">
	    <sc:Placeholder runat="server" Key="leftCol"/>
    </div>
	<!-- start content_right -->
	<div class="content_right">
        <sc:Placeholder runat="server" Key="content"/>
	</div>
	<div class="clear"></div>
</div>
</div>
</div>
</div>
<div class="footer_bg">
<div class="wrap">
<div class="wrapper">
	<div class="footer">
		<div class="copy">
			<p class="w3-link">© All Rights Reserved | Design by&nbsp; <a href="http://w3layouts.com/"> W3Layouts</a></p>
		</div>
		<div class="f_nav">
		<ul>
			<li><a href="#">Skype</a></li>
			<li><a href="#">Linked in</a></li>
			<li><a href="#">Twitter</a></li>
			<li><a href="#">Facebook</a></li>
		</ul>
		</div>
		<div class="clear"></div>
	</div>
</div>
</div>
</div>
        </form>
</body>
</html>