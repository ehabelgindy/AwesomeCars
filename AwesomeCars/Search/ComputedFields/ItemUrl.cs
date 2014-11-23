using AwesomeCars.Code;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Resources.Media;

namespace AwesomeCars.Search.ComputedFields
{
    public class ItemUrl : AbstractComputedField
    {
        protected override object ComputeFieldValue(Item item)
        {
            var opts = LinkManager.GetDefaultUrlOptions();
            opts.AddAspxExtension = false;
            opts.UseDisplayName = true;
            opts.LanguageEmbedding = LanguageEmbedding.Never;
            opts.Site = Sitecore.Sites.SiteContext.GetSite("website");
            return LinkManager.GetItemUrl(item, opts);
        }
    }
}