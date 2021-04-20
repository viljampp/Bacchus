using System.Collections.Generic;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
namespace Auction.Facade.Components
{
    public class CategoryMenuViewModel: ProductViewModel {
        public CategoryMenuViewModel() {
            Products = new List<ProductObject>();
        } 
        public List<ProductObject> Products { get; set; }
    }
}
