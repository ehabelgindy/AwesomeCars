<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchFilters.ascx.cs" Inherits="AwesomeCars.Site.Sublayouts.SearchFilters" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<asp:Repeater runat="server" ID="FacetsRepeater" OnItemDataBound="FacetsRepeater_OnItemDataBound">
    <HeaderTemplate>
        <div class="text1-nav">
    </HeaderTemplate>
    <ItemTemplate>
        <h2><asp:Literal runat="server" ID="FilterTitleLiteral"/></h2>
        <asp:Repeater runat="server" ID="SingleFilterRepeater" OnItemDataBound="SingleFilterRepeater_OnItemDataBound">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li><asp:HyperLink runat="server" ID="FilterLink"/></li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>
