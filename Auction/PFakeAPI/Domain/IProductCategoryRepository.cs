using System.Collections.Generic;
using System.Threading.Tasks;
using Auction.PFakeAPI.Facade;

namespace Auction.PFakeAPI.Domain {
    public interface IProductCategoryRepository: ICommonRepository<ProductCategory> {
        Task<ProductView> Get(string productId, string categoryId);
        Task<IEnumerable<ProductCategory>> GetAll();
    }
}
