using AwesomeCars.Code;
using Sitecore.Web;

namespace AwesomeCars.Site.Sublayouts
{
    using System;

    public partial class SearchBox : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
            // Put user code to initialize the page here
            if (!Page.IsPostBack)
            {
                TagsTextBox.Text = Request.Params["query"];
            }
        }

        protected void SearchButton_OnClick(object sender, EventArgs e)
        {
            var url = this.UpdateQueryString("query", TagsTextBox.Text,"make","model","year");
            Response.Redirect(url);
        }
    }
}