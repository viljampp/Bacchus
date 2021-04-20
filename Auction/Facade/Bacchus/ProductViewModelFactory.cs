using System;
using Auction.Domain.Bacchus;
namespace Auction.Facade.Bacchus {
    public class ProductViewModelFactory {
        public static ProductViewModel Create(ProductObject o) {
            var v = new ProductViewModel {
                Id = o.Id,
                Name = o.Name,
                Description = o.Description,
                Category = o.Category,
                BiddingEndDate = timeLeft(o.BiddingEndDate)
            };

            return v;
        }

        protected internal static string timeLeft(DateTime value) {
            var format = "HH:mm:ss";
            var end = value.ToLocalTime().Ticks;
            var now = DateTime.Now.Ticks;

            if (end < now) return DateTime.MinValue.ToString(format);

            var result = end - now;
            return new DateTime(result).ToString(format);
        }
    }
}
