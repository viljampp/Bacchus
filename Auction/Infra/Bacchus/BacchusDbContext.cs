using Auction.Data.Bacchus;
using Microsoft.EntityFrameworkCore;

namespace Auction.Infra.Bacchus
{
    public class BacchusDbContext : DbContext
    {
        public BacchusDbContext(DbContextOptions<BacchusDbContext> o) : base(o) { }

        public DbSet<BidDbRecord> Bids { get; set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.Entity<BidDbRecord>().ToTable("Bid");
        }
    }
}
