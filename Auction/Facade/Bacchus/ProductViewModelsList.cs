using System.Collections.Generic;
using Auction.Domain.Bacchus;
namespace Auction.Facade.Bacchus
{
    public class ProductViewModelsList : List<ProductViewModel>
    {
        public ProductViewModelsList(IEnumerable<ProductObject> list)
        {
            if (list is null) return;
            foreach (var e in list)
            {
                Add(ProductViewModelFactory.Create(e));
            }
        }
    }
}
