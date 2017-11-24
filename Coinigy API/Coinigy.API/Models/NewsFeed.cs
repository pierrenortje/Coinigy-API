#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

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
