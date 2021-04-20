using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Auction.Domain.Bacchus
{
    public class ProductObject
    {
        [JsonProperty("productId")]
        public string Id { get; set; }

        [JsonProperty("productName")]
        public string Name { get; set; }

        [JsonProperty("productDescription")]
        public string Description { get; set; }

        [JsonProperty("productCategory")]
        public string Category { get; set; }

        [JsonProperty("biddingEndDate")]
        public DateTime BiddingEndDate { get; set; }
    }
}
