using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auction.PFakeAPI.Common;
using Auction.PFakeAPI.Domain;

namespace Auction.PFakeAPI.Infra {
    public class ProductRepository: BaseTools, IProductRepository
    {
        protected internal static List<Product> FakeTable => InitializeData.products;  
        
        //public ProductRepository()
        //{
        //    FakeTable.Add(new Product());
        //}

        public async Task<Product> Get(string id) {
            return FakeTable.FirstOrDefault(x => x.Id == id);
        }

        //TODO Hack, because real database missing
        public async Task<Product> Get(int id) {
            return FakeTable.ElementAt(id);
        }
    }
}
