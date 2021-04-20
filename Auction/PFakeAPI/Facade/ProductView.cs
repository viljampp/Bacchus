using System;

namespace Auction.PFakeAPI.Facade {
    public class ProductView {
        public string productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productCategory { get; set; }
        public DateTime biddingEndDate { get; set; }
    }
}
