using System.Threading.Tasks;

namespace Auction.PFakeAPI.Domain {
    public interface ICommonRepository<T> {
        Task<T> Get(string id);
    }
}
