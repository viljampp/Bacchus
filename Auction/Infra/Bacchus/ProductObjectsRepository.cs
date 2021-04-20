using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Auction.Domain.Bacchus;
using Newtonsoft.Json;
namespace Auction.Infra.Bacchus
{
    public class ProductObjectsRepository: IProductObjectsRepository
    {
        private static IList<ProductObject> products { get; } = new List<ProductObject>();

        public async Task<ProductObject> GetObject(string id) {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<ProductObject>> GetObjectsList() {
            var l = await jsonToObjectsList();

            products.Clear();
            foreach (var i in l) {
                products.Add(i);
            }

            return new ProductObjectsList(l);
        }

        private async Task<IEnumerable<ProductObject>> jsonToObjectsList() {
            var request = WebRequest.Create(@"https://localhost:44390/products");
            var response = await request.GetResponseAsync().ConfigureAwait(false);

            var reader = new StreamReader(response.GetResponseStream());
            var data = await reader.ReadToEndAsync();

            return JsonConvert.DeserializeObject<IEnumerable<ProductObject>>(data);
        }
    }
}
