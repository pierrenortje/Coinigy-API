using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class UpdateUserModel
    {
        [SerializeAs(Name = "first_name")]
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company { get; set; }
        public string phone { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
    }
}
