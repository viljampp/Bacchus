using System;
using System.Linq;
using Auction.Bag;
using Auction.Data.Bacchus;
namespace Auction.Infra.Bacchus {
    public class BidDbTableInitializer {
        public static void Initialize(BacchusDbContext c) {
            c.Database.EnsureCreated();
            if (c.Bids.Any()) return;

            //fakeData(c); //TODO For mocking/testing
        }

        private static async void fakeData(BacchusDbContext c) {
            for (var i = 0; i < GetRandom.Int16(1, 5); i++) {
                var bid = new BidDbRecord {
                    ID = Guid.NewGuid().ToString(),
                    UserId = GetRandom.String() + GetRandom.DateTime(),
                    ProductId = Guid.NewGuid().ToString(),
                    Price = GetRandom.Decimal(1, 100)
                };
                c.Bids.Add(bid);
            }

            await c.SaveChangesAsync();
        }
    }
}
