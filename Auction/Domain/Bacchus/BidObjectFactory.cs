using System;
using Auction.Core;
using Auction.Data.Bacchus;
namespace Auction.Domain.Bacchus
{
    public static class BidObjectFactory
    {
        public static BidObject Create(string id, string userId, string productId, decimal? price = null,
            DateTime? validFrom = null, DateTime? validTo = null)
        {
            var a = new BidDbRecord
            {
                ID = id,
                UserId = userId,
                ProductId = productId,
                Price = price ?? Constants.DefaultPrize,
                ValidFrom = validFrom ?? DateTime.MinValue,
                ValidTo = validTo ?? DateTime.MaxValue
            };

            return new BidObject(a);
        }
    }
}
