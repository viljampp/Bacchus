using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
using Microsoft.AspNetCore.Mvc;
using Bacchus.Models;
namespace Bacchus.Controllers {
    public class HomeController : Controller {
        private readonly IProductObjectsRepository productRepository;

        public HomeController(IProductObjectsRepository p) {
            productRepository = p;
        }
        public async Task<IActionResult> Index(string category) {
            var l = await productRepository.GetObjectsList();

            if (string.IsNullOrEmpty(category)) l = l.OrderBy(p => p.BiddingEndDate);
            else l = l.Where(p => p.Category.Equals(category)).OrderBy(p => p.BiddingEndDate);

            ViewBag.Category = category;

            return View(new ProductViewModelsList(l));
        }

        public IActionResult Error() {
            return View(new ErrorViewModel {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
