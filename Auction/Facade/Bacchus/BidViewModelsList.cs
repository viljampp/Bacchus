using System.Collections.Generic;
using Auction.Domain.Bacchus;
namespace Auction.Facade.Bacchus
{
    public class BidViewModelsList : List<BidViewModel>
    {
        public BidViewModelsList(IEnumerable<BidObject> list)
        {
            if (list is null) return;
            foreach (var e in list)
            {
                Add(BidViewModelFactory.Create(e));
            }
        }
    }
}
