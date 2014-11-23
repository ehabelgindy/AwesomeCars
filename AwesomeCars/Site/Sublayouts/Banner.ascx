<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Banner.ascx.cs" Inherits="AwesomeCars.Site.Sublayouts.Banner" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<script type='text/javascript' src='/js/camera.min.js'></script> 
    
    <script>
        jQuery(function () {

            jQuery('#camera_wrap_1').camera({
                thumbnails: true
            });

            jQuery('#camera_wrap_2').camera({
                height: '400px',
                loader: 'bar',
                pagination: false,
                thumbnails: true
            });
        });
	</script>

<!-- start slider -->
<div class="slider_bg">
<div class="wrap">
<div class="wrapper">
	<div class="slider">
	<!-- #camera_wrap_1 -->
	<div class="fluid_container">
        <div class="camera_wrap camera_azure_skin" id="camera_wrap_1">
            <div data-thumb="images/thumbs/slider1.jpg" data-src="images/slider/slider1.jpg">
            </div>
            <div data-thumb="images/thumbs/slider2.jpg" data-src="images/slider/slider2.jpg">
            </div>
            <div data-thumb="images/thumbs/slider3.jpg" data-src="images/slider/slider3.jpg">
            </div>
            <div data-thumb="images/thumbs/slider4.jpg" data-src="images/slider/slider4.jpg">
            </div>            
             </div><!-- #camera_wrap_1 -->
         <div class="clear"></div>
	</div>
	<!-- end #camera_wrap_1 -->
	<div class="clear"></div>
	</div>
</div>
</div>
</div>