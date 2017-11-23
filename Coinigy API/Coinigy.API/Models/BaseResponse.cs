using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class BaseResponse<T>
    {
        [DeserializeAs(Name = "data")]
        public T Data { get; set; }

        [DeserializeAs(Name = "notifications")]
        public List<object> Notifications { get; set; }
    }
}
