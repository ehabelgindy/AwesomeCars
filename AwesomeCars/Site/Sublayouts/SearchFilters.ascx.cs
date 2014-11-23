using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web.UI.WebControls;
using AwesomeCars.Code;
using Sitecore.ContentSearch.Linq;
using Sitecore.Web;

namespace AwesomeCars.Site.Sublayouts
{
    public partial class SearchFilters : System.Web.UI.UserControl
    {
        private EventHandler _eventHandler;
        private void Page_Load(object sender, EventArgs e)
        {
            _eventHandler = OnFacetsEventReceived;
            this.SubscribeToEvent("FacetsEvent", _eventHandler);
        }

        private void OnFacetsEventReceived(object sender, EventArgs e)
        {
            var facets = Sitecore.Events.Event.ExtractParameter(e, 0) as FacetResults;
            if (facets != null)
            {
                FacetsRepeater.DataSource = facets.Categories;
                FacetsRepeater.DataBind();
            }
        }

        private void Page_Unload(object sender, EventArgs e)
        {
            if (_eventHandler!=null)
                this.UnsubscribeFromEvent("FacetsEvent", _eventHandler);
        }

        protected void FacetsRepeater_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var filterTitleLiteral = e.Item.FindControl("FilterTitleLiteral") as Literal;
            var singleFilterRepeater = e.Item.FindControl("SingleFilterRepeater") as Repeater;
            var facetCategory = e.Item.DataItem as FacetCategory;
            if (facetCategory != null)
            {
                var categories =
                    facetCategory.Values.Where(c => c.AggregateCount > 0).Select(
                        c =>
                        new Category
                            {
                                CategoryTitle = string.Format("{0} ({1})", c.Name, c.AggregateCount),
                                CategoryUrl = this.UpdateQueryString(facetCategory.Name,c.Name),
                                FacetName = facetCategory.Name
                            }).ToList();
                
                filterTitleLiteral.Text =  facetCategory.Name;
                singleFilterRepeater.DataSource = categories;
                singleFilterRepeater.DataBind();
            }
        }

        protected void SingleFilterRepeater_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var filterLink = e.Item.FindControl("FilterLink") as HyperLink;
            var facetCategory = e.Item.DataItem as Category;
            if (facetCategory != null)
            {
                filterLink.NavigateUrl = facetCategory.CategoryUrl;
                filterLink.Text = facetCategory.CategoryTitle;
            }
        }
    }

    public class Category
    {
        public string CategoryUrl { get; set; }
        public string CategoryTitle { get; set; }
        public string FacetName { get; set; }
    }
}