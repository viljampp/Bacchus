using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auction.PFakeAPI.Common;
using Auction.PFakeAPI.Domain;

namespace Auction.PFakeAPI.Infra {
    public class CategoryRepository: BaseTools, ICategoryRepository {
        protected internal static List<Category> FakeTable => InitializeData.categories;

        public async Task<Category> Get(string id) {
            return FakeTable.FirstOrDefault(x => x.Id == id);
        }

        //TODO Hack, because database missing
        public async Task<Category> Get(int id) {
            return FakeTable.ElementAt(id);
        }
    }
}
