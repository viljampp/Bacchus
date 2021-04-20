using System;
namespace Auction.Domain.Bacchus
{
    public static class ProductObjectFactory {
        public static ProductObject Create(string id, string name, string description,
            string category, DateTime biddingEndDate) {
            return new ProductObject {
                Id = id,
                Name = name,
                Description = description,
                Category = category,
                BiddingEndDate = biddingEndDate
            };
        }
    }
}
