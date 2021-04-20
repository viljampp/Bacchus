using System.Collections.Generic;
using Auction.Data.Bacchus;
namespace Auction.Domain.Bacchus
{
    public class BidObjectsList: List<BidObject>
    {
        public BidObjectsList(IEnumerable<BidDbRecord> items)
        {
            if (items is null) return;
            foreach (var dbRecord in items)
            {
                Add(new BidObject(dbRecord));
            }
        }
    }
}
