using System.Collections.Generic;
using System.Linq;
using Auction.Domain.Bacchus;
using Auction.Facade.Components;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Bacchus.Components {
    public class CategoryMenu : ViewComponent {
        private readonly IProductObjectsRepository productRepository;

        public CategoryMenu(IProductObjectsRepository p) {
            productRepository = p;
        }

        public IViewComponentResult Invoke() {
            var products = productRepository.GetObjectsList().Result;

            var categories = products.OrderBy(x => x.Category);
            return View(categories);
        }

        public static IEnumerable<CategoryMenuViewModel> Categories(IEnumerable<ProductObject> products) {
            var categoryMenuItems = new List<CategoryMenuViewModel>();
            foreach (var product in products) {
                if (categoryMenuItems.Count == 0) {
                    categoryMenuItems.Add(createNewCategory(product));
                    continue;
                }

                var categoryExists = false;
                foreach (var item in categoryMenuItems) {
                    if (product.Category != item.Category) continue;

                    item.Products.Add(product);
                    categoryExists = true;
                }

                if (categoryExists) continue;

                categoryMenuItems.Add(createNewCategory(product));
            }

            return categoryMenuItems;
        }

        private static CategoryMenuViewModel createNewCategory(ProductObject product) {
            var c = new CategoryMenuViewModel {Category = product.Category};
            c.Products.Add(product);
            return c;
        }
    }
}
