using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Auction.Core;
using Auction.Facade.Common;
namespace Auction.Facade.Bacchus
{
    public class BidViewModel: NamedViewModel
    {
        private string productId;
        private string userId;

        [DisplayName("Product ID")]
        public string ProductId {
            get => getValue(ref productId, Constants.Unspecified);
            set => productId = value;
        }

        [Required]
        [DisplayName("User ID")]
        public string UserId {
            get => getValue(ref userId, Constants.Unspecified);
            set => userId = value;
        }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
