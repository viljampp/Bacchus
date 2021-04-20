using System;
using System.Linq;
using System.Threading.Tasks;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
using Microsoft.AspNetCore.Mvc;

namespace PBacchus.Controllers {
    public class BidController : Controller {
        private readonly IProductObjectsRepository productRepository;
        private readonly IBidObjectsRepository bidRepository;

        public BidController(IProductObjectsRepository p, IBidObjectsRepository b) {
            productRepository = p;
            bidRepository = b;
        }

        public async Task<IActionResult> Offering(string id) {
            await productRepository.GetObjectsList();
            var product = await productRepository.GetObject(id);
            if (product == null) RedirectToAction("Index", "Home");

            ViewData["Product"] = product;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Offering([Bind("ID, UserId, Price")] BidViewModel m) {
            if (!ModelState.IsValid) return View(m);

            await productRepository.GetObjectsList();
            var product = await productRepository.GetObject(m.ID);

            if (product == null) RedirectToAction("Error", "Home"); //TODO Add custom error page, definitely in the future..

            var endDate = product.BiddingEndDate.ToLocalTime();
            if (endDate < DateTime.Now) RedirectToAction("Error", "Home"); //TODO Add custom error page - not yet done, definitely in the future..

            var id = Guid.NewGuid().ToString();
            var userId = (m.UserId + DateTime.Now).Trim();

            var o = BidObjectFactory.Create(id, userId, m.ID, m.Price, DateTime.Now, endDate);
            await bidRepository.AddObject(o);

            return RedirectToAction("GoToHome");
        }

        public IActionResult GoToHome() {
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Results() {
            var o = await bidRepository.GetObjectsList();
            var l = o.GroupBy(x => x.DbRecord.ProductId).Select(x => x.FirstOrDefault()).ToList();
            return View(new BidViewModelsList(l));
        }

        public async Task<IActionResult> Bids(string productId) {
            ViewBag.Product = productId;

            var o = await bidRepository.GetObjectsList();
            var l = o.Where(x => x.DbRecord.ProductId == productId).OrderByDescending(x => x.DbRecord.Price);
            
            return View(new BidViewModelsList(l));
        }

    }
}