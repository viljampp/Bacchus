using System.Collections.Generic;
namespace Auction.Domain.Bacchus {
    public class ProductObjectsList : List<ProductObject> {
        public ProductObjectsList(IEnumerable<ProductObject> items) {
            if (items is null) return;
            foreach (var item in items) { Add(item); }
        }
    }
}
