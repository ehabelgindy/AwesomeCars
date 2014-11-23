<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CarDetails.ascx.cs" Inherits="AwesomeCars.Site.Sublayouts.CarDetails" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>

<div class="details">
	<h2 class="style"><sc:FieldRenderer runat="server" FieldName="Title"/></h2>
<div class="det_pic img_style">
    <sc:Image runat="server" Field="Image"/>		
</div>
<div class="det-para">
	<p class="top style"><sc:FieldRenderer runat="server" FieldName="Body"/></p>
</div>
</div>
