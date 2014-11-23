using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwesomeCars.Code;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;

namespace AwesomeCars.Search.ComputedFields
{
    public class ImageUrl : AbstractComputedField
    {
        protected override object ComputeFieldValue(Item item)
        {
            //1.1.3
             if (item.TemplateName == "Car")
            {
                var fileField = (FileField)item.Fields["Image"];
                if (fileField != null && fileField.MediaItem != null)
                {
                    var url = MediaManager.GetMediaUrl(fileField.MediaItem, new MediaUrlOptions { UseItemPath = false, AbsolutePath = false });
                    return url;
                }
            }
            return null;
        }
    }
}