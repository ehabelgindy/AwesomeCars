using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeCars.Code
{
    public class SearchParams
    {
        public string Query { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}