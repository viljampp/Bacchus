using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Auction.PFakeAPI.Domain;
using Auction.PFakeAPI.Facade;
using Microsoft.AspNetCore.Mvc;

namespace Auction.PFakeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductCategoryRepository productCategoryRepository;
        

        public ProductsController(IProductCategoryRepository pC)
        {
            productCategoryRepository = pC;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductView>> Get()
        {
            var productCategories =  await productCategoryRepository.GetAll();

            var list = new List<ProductView>();
            foreach (var item in productCategories) {
                list.Add(await productCategoryRepository.Get(item.ProductId, item.CategoryId));
            }

            return list;
        }
    }
}
