using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class NewsFeed
    {
        [DeserializeAs(Name = "id")]
        public string ID { get; set; }

        [DeserializeAs(Name = "url")]
        public string Url { get; set; }

        [DeserializeAs(Name = "title")]
        public string Title { get; set; }

        [DeserializeAs(Name = "pubDate")]
        public string PubDate { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public string Timestamp { get; set; }

        [DeserializeAs(Name = "feed_id")]
        public string FeedId { get; set; }

        [DeserializeAs(Name = "published_date")]
        public string PublishedDate { get; set; }

        [DeserializeAs(Name = "feed_name")]
        public string FeedName { get; set; }

        [DeserializeAs(Name = "feed_url")]
        public string FeedUrl { get; set; }

        [DeserializeAs(Name = "feed_enabled")]
        public string FeedEnabled { get; set; }

        [DeserializeAs(Name = "feed_description")]
        public string FeedDescription { get; set; }

        [DeserializeAs(Name = "url_field")]
        public string UrlField { get; set; }

        [DeserializeAs(Name = "title_field")]
        public string TitleField { get; set; }

        [DeserializeAs(Name = "date_field")]
        public string DateField { get; set; }

        [DeserializeAs(Name = "feed_image")]
        public string FeedImage { get; set; }
    }
}
