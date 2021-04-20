using System;

namespace Auction.PFakeAPI.Domain {
    public class Product {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BiddingEndDate { get; set; }
    }
}
