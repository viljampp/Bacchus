using Auction.Core;
using Auction.Data.Common;
namespace Auction.Data.Bacchus
{
    public class BidDbRecord: UniqueDbRecord
    {
        private string productId;
        private string userId;

        public string UserId {
            get => getValue(ref userId, Constants.Unspecified);
            set => userId = value;
        }
        public string ProductId {
            get => getValue(ref productId, Constants.Unspecified);
            set => productId = value;
        }
        public decimal Price { get; set; }
    }
}
