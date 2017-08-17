using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tryzomato
{
    public class Collection2
    {
        public int collection_id { get; set; }
        public int res_count { get; set; }
        public string image_url { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string share_url { get; set; }
    }

    public class Collection
    {
        public Collection2 collection { get; set; }
    }

    public class RootObject_collection
    {
        public List<Collection> collections { get; set; }
        public int has_more { get; set; }
        public string share_url { get; set; }
        public string display_text { get; set; }
        public int has_total { get; set; }
    }
}