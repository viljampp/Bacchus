using System.ComponentModel;
namespace Auction.Facade.Bacchus
{
    public class ProductViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [DisplayName("Time Left")]
        public string BiddingEndDate { get; set; }
    }
}
