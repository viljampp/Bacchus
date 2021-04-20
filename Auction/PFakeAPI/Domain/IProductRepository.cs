
using System.Threading.Tasks;

namespace Auction.PFakeAPI.Domain {
    public interface IProductRepository: ICommonRepository<Product> {
        Task<Product> Get(int id);
    }
}
