using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace AwesomeCars.service
{
    /// <summary>
    /// Summary description for autocomplete
    /// </summary>
    public class autocomplete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var query = context.Request.Params["query"];
            var suggestions = Code.Search.Autocomplete(query);
            if (suggestions.Any())
            {
                CreateResponse(context, query, suggestions);
            }
        }

        private void CreateResponse(HttpContext context, string query, List<string> suggestions)
        {
            
            var response = new AutocompleteResponse();
            response.query = query;
            response.suggestions = suggestions;
            var serializer = new JavaScriptSerializer();
            var jsonString = serializer.Serialize(response);
            context.Response.ContentType = "application/json";
            context.Response.Write(jsonString);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

    public class AutocompleteResponse
    {
        public string query { get; set; }
        public List<string> suggestions { get; set; }
    }
    //public class AutocompelteResult
    //{
    //    public string data { get; set; }
    //    public string value { get; set; }
    //}
}