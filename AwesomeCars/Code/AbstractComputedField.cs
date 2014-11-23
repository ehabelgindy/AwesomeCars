using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;

namespace AwesomeCars.Code
{
    public abstract class AbstractComputedField : IComputedIndexField
    {
        public object ComputeFieldValue(IIndexable indexable)
        {
            var scIndexable = indexable as SitecoreIndexableItem;
            if (scIndexable != null)
            {
                var item = (Item)scIndexable;
                if (item != null)
                {
                    return ComputeFieldValue(item);
                }

            }
            return null;
        }

        protected abstract object ComputeFieldValue(Item item);

        public string FieldName { get; set; }
        public string ReturnType { get; set; }
    }
}