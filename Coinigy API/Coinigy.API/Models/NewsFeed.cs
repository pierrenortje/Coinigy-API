using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinigy.API.Models
{
    public class NewsFeed
    {
        public string id { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string pubDate { get; set; }
        public string timestamp { get; set; }
        public string feed_id { get; set; }
        public string published_date { get; set; }
        public string feed_name { get; set; }
        public string feed_url { get; set; }
        public string feed_enabled { get; set; }
        public string feed_description { get; set; }
        public string url_field { get; set; }
        public string title_field { get; set; }
        public string date_field { get; set; }
        public string feed_image { get; set; }
    }
}
