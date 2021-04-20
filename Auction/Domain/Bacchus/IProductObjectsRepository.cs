using System.Collections.Generic;
using System.Threading.Tasks;
namespace Auction.Domain.Bacchus
{
    public interface IProductObjectsRepository
    {
        Task<ProductObject> GetObject(string id);
        Task<IEnumerable<ProductObject>> GetObjectsList();
    }
}
