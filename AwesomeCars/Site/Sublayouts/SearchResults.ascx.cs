using System;
using System.Linq;
using AwesomeCars.Code;


namespace AwesomeCars.Site.Sublayouts
{
    public partial class SearchResults : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
            var searchParams = new SearchParams();
            searchParams.Query = Request.Params["query"];
            searchParams.Year = Request.Params["year"];
            searchParams.Make = Request.Params["make"];
            searchParams.Model = Request.Params["model"];


            var results = Code.Search.GetSearchResults(searchParams);
            if (results == null) return;
            var cars = results.Hits.Select(h => h.Document).ToList();
            CarsRepeater.DataSource = cars;
            CarsRepeater.DataBind();
            this.RaiseEvent("FacetsEvent", results.Facets);
        }
    }
}