<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchBox.ascx.cs" Inherits="AwesomeCars.Site.Sublayouts.SearchBox" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<div class="search">
    <h2>search</h2>
        <asp:TextBox runat="server" ID="TagsTextBox" ClientIDMode="Static"/>
        <asp:Button runat="server" ID="SearchButton" OnClick="SearchButton_OnClick"/>
</div>


<script>
    var options, a;
    jQuery(function () {
        options = { serviceUrl: '/service/autocomplete.ashx' };
        a = $('#TagsTextBox').autocomplete(options);
    });
  </script>
