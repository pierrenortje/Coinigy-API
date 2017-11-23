using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinigy.API.Models
{
    public class Watch
    {
        public string exchmkt_id { get; set; }
        public string mkt_name { get; set; }
        public string exch_code { get; set; }
        public string exch_name { get; set; }
        public string primary_currency_name { get; set; }
        public string secondary_currency_name { get; set; }
        public string server_time { get; set; }
        public string last_price { get; set; }
        public string prev_price { get; set; }
        public string high_trade { get; set; }
        public string low_trade { get; set; }
        public string current_volume { get; set; }
        public string fiat_market { get; set; }
        public string btc_volume { get; set; }
    }
}
