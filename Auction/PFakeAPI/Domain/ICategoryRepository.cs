
using System.Threading.Tasks;

namespace Auction.PFakeAPI.Domain {
    public interface ICategoryRepository: ICommonRepository<Category> {
        Task<Category> Get(int id);
    }
}
