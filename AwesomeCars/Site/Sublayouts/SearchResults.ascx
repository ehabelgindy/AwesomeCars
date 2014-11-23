<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchResults.ascx.cs" Inherits="AwesomeCars.Site.Sublayouts.SearchResults" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>

<asp:Repeater runat="server" ID="CarsRepeater" ItemType="AwesomeCars.Search.Entities.CarSearchResultItem">
    <HeaderTemplate>
        <div class="image group">
    </HeaderTemplate>
    <ItemTemplate>
        <div class="grids_of_2 top">
        <div class="grid images_3_of_1">
            <img src="<%#: Item.ImageUrl %>">
        </div>
        <div class="grid span_2_of_3">
            <h3><%#: Item.Title %></h3>
            <p class="para"><%#: Item.Summary %> </p>
            <div class="button"><span><a href="<%#: Item.Url %>">Read More</a></span></div>
        </div>
        <div class="clear"></div>
        </div>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>