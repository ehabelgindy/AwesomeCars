using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwesomeCars.Search.Entities;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Maintenance;
using Sitecore.ContentSearch.Maintenance.Strategies;
using Sitecore.Data;

namespace AwesomeCars.Code
{
    public static class Search
    {
        public static SearchResults<CarSearchResultItem> GetSearchResults(SearchParams searchParams = null)
        {
            //1.1.1
            //1.2
            //1.3.1
            var indexName = string.Format("sitecore_{0}_index", Sitecore.Context.Database.Name);
            var index = ContentSearchManager.GetIndex(indexName);
            using (var context = index.CreateSearchContext())
            {
                var query = context.GetQueryable<CarSearchResultItem>();
                query = query.Where(i => i.Parent == new ID("{B05F6DDC-763C-4D12-8137-B40A81AED6D7}"));
                query = BuildFilters(query, searchParams);
                query = query.FacetOn(i => i.Make).FacetOn(i => i.Model).FacetOn(i => i.Year);
                return query.GetResults();
            }
            return null;
        }

        private static IQueryable<CarSearchResultItem> BuildFilters(IQueryable<CarSearchResultItem> query, SearchParams searchParams)
        {
            //1.1.2
            //1.3.2
            if (searchParams == null)
                return query;
            if (!string.IsNullOrEmpty(searchParams.Query))
            {
                var searchQuery = searchParams.Query.Replace(" ", "@");
                query = query.Where(i => (i.Title == searchQuery).Boost(5.0f) || (i.Body == searchQuery).Boost(0.1f));
            }
            if (!string.IsNullOrEmpty(searchParams.Year))
                query = query.Where(i => i.Year == searchParams.Year);
            if (!string.IsNullOrEmpty(searchParams.Make))
                query = query.Where(i => i.Make == searchParams.Make);
            if (!string.IsNullOrEmpty(searchParams.Model))
                query = query.Where(i => i.Model == searchParams.Model);
            return query;
                       

            return null;

        }


        public static List<string> Autocomplete(string searchQuery)
        {
            //1.4.1
            var indexName = "sitecore_web_index";
            var index = ContentSearchManager.GetIndex(indexName);
            using (var context = index.CreateSearchContext())
            {
                var query = context.GetQueryable<CarSearchResultItem>();
                query = query.Where(i => i.Parent == new ID("{B05F6DDC-763C-4D12-8137-B40A81AED6D7}"));
                query = query.Where(i => i.AutoCompleteTitle == searchQuery);
                return query.GetResults().Hits.Select(h => h.Document.Title).ToList();
            }
            return null;
        }
    }
}