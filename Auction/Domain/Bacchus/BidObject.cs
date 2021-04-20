using Auction.Data.Bacchus;
namespace Auction.Domain.Bacchus
{
    public class BidObject
    {
        public readonly BidDbRecord DbRecord;
        public BidObject(BidDbRecord r)
        {
            DbRecord = r ?? new BidDbRecord();
        }
    }
}
