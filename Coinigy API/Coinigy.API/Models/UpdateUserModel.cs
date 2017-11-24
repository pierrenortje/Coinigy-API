using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class UpdateUserModel
    {
        [SerializeAs(Name = "first_name")]
        public string FirstName { get; set; }

        [SerializeAs(Name = "last_name")]
        public string LastName { get; set; }

        [SerializeAs(Name = "company")]
        public string Company { get; set; }

        [SerializeAs(Name = "phone")]
        public string Phone { get; set; }

        [SerializeAs(Name = "street1")]
        public string Street1 { get; set; }

        [SerializeAs(Name = "street2")]
        public string Street2 { get; set; }

        [SerializeAs(Name = "city")]
        public string City { get; set; }

        [SerializeAs(Name = "state")]
        public string State { get; set; }

        [SerializeAs(Name = "zip")]
        public string Zip { get; set; }

        [SerializeAs(Name = "country")]
        public string Country { get; set; }
    }
}
