using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;

namespace AwesomeCars.Search.Entities
{
    public class CarSearchResultItem : SearchResultItem
    {
        [IndexField("title")]
        public string Title { get; set; }

        [IndexField("body")]
        public string Body { get; set; }

        [IndexField("summary")]
        public string Summary { get; set; }

        [IndexField("make")]
        public string Make { get; set; }

        [IndexField("model")]
        public string Model { get; set; }

        [IndexField("year")]
        public string Year { get; set; }

        [IndexField("imageurl")]
        public string ImageUrl { get; set; }

        // 1.4.2
        [IndexField("autocomplete")]
        public string AutoCompleteTitle { get; set; }
    }
}