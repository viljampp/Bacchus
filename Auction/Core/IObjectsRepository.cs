using System.Collections.Generic;
using System.Threading.Tasks;
namespace Auction.Core {
    public interface IObjectsRepository<T>
    {

        Task<T> GetObject(string id);
        Task<IEnumerable<T>> GetObjectsList();
        Task<T> AddObject(T o);
        Task<T> UpdateObject(T o);
        Task<IEnumerable<T>> DeleteObject(T o);

    }
}


