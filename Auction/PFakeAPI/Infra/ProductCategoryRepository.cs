using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auction.PFakeAPI.Common;
using Auction.PFakeAPI.Domain;
using Auction.PFakeAPI.Facade;

namespace Auction.PFakeAPI.Infra {
    public class ProductCategoryRepository: BaseTools, IProductCategoryRepository {
        protected internal static List<ProductCategory> FakeTable => InitializeData.productCategories;

        private IProductRepository productRepository;
        private ICategoryRepository categoryRepository;

        public ProductCategoryRepository(IProductRepository p, ICategoryRepository c) {
            productRepository = p;
            categoryRepository = c;
        }

        public async Task<ProductCategory> Get(string id) {
            return FakeTable.FirstOrDefault(x => x.Id == id);
        }

        // TODO Include, dbset missing, a big mess, I know what is wrong
        public async Task<ProductView> Get(string productId, string categoryId) {
            var product = await productRepository.Get(productId);
            var category = await categoryRepository.Get(categoryId);

            return new ProductView {
                productId = product.Id,
                productName = product.Name,
                productDescription = product.Description,
                productCategory = category.Name,
                biddingEndDate = product.BiddingEndDate
            };
        }

        public async Task<IEnumerable<ProductCategory>> GetAll() {
            return FakeTable.ToList();
        }
    }
}
