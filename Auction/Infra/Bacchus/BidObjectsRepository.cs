using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auction.Domain.Bacchus;
using Microsoft.EntityFrameworkCore;
namespace Auction.Infra.Bacchus
{
    public class BidObjectsRepository : IBidObjectsRepository
    {
        private readonly BacchusDbContext db;
        public BidObjectsRepository(BacchusDbContext context) {
            db = context;
        }
        public async Task<BidObject> GetObject(string id) {
            var o = await db.Bids.FindAsync(id);
            return new BidObject(o);
        }
        public async Task<IEnumerable<BidObject>> GetObjectsList() {
            var l = await db.Bids.ToListAsync();
            return new BidObjectsList(l);
        }
        public async  Task<BidObject> AddObject(BidObject o) {
            db.Bids.Add(o.DbRecord);
            await db.SaveChangesAsync();
            return o;
        }
        public async Task<BidObject> UpdateObject(BidObject o) {
            db.Bids.Update(o.DbRecord);
            await db.SaveChangesAsync();
            return new BidObject(o.DbRecord);
        }
        public async Task<IEnumerable<BidObject>> DeleteObject(BidObject o) {
            db.Bids.Remove(o.DbRecord);
            await db.SaveChangesAsync();
            return await GetObjectsList();
        }
        public bool IsInitialized() {
            db.Database.EnsureCreated();
            return db.Bids.Any();
        }
    }
}
