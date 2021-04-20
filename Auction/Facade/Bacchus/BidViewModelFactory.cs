using System;
using Auction.Domain.Bacchus;
namespace Auction.Facade.Bacchus
{
    public class BidViewModelFactory
    {
        public static BidViewModel Create(BidObject o)
        {
            var v = new BidViewModel
            {
                ID = o?.DbRecord.ID,
                ProductId = o?.DbRecord.ProductId,
                UserId = o?.DbRecord.UserId
            };

            if (o is null) return v;

            v.Price = o.DbRecord.Price;
            v.ValidFrom = setNullIfExtremum(o.DbRecord.ValidFrom);
            v.ValidTo = setNullIfExtremum(o.DbRecord.ValidTo);
            return v;
        }
        private static DateTime? setNullIfExtremum(DateTime d)
        {
            if (d.Date >= DateTime.MaxValue.Date) return null;
            if (d.Date <= DateTime.MinValue.AddDays(1).Date) return null;
            return d;
        }
    }
}
