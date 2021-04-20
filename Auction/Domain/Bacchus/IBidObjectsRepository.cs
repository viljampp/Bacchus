using Auction.Core;
namespace Auction.Domain.Bacchus
{
    public interface IBidObjectsRepository: IObjectsRepository<BidObject>
    {
        bool IsInitialized();
    }
}
