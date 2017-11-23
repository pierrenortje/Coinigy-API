using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class UpdateTickersModel
    {
        [SerializeAs(Name = "exch_mkt_ids")]
        public string ExchMktIds { get; set; }
    }
}
