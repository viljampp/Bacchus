using Auction.Core;

namespace Auction.Facade.Common {
    public class NamedViewModel : TemporalViewModel {
        private string id;

        public string ID {
            get => getValue(ref id, Constants.Unspecified);
            set => id = value;
        }
    }
}
