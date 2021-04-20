using System;
using Auction.PFakeAPI.Domain;
using System.Collections.Generic;
using System.Linq;
using Auction.PFakeAPI.Common;

namespace Auction.PFakeAPI.Infra {
    public static class InitializeData{
        //TODO Middle-way
        //public static void CreateFakeData() {
        //    createFakeProducts();
        //    createFakeCategories();
        //    createFakeProductCategories();
        //}

        //private static void createFakeProducts() {
        //    if (ProductRepository.FakeTable.Any()) return;
        //    ProductRepository.FakeTable.AddRange(products);
        //}
        //private static void createFakeCategories() {
        //    if (CategoryRepository.FakeTable.Any()) return;
        //    CategoryRepository.FakeTable.AddRange(categories);
        //}
        //private static void createFakeProductCategories() {
        //    if (ProductCategoryRepository.FakeTable.Any()) return;
        //    ProductCategoryRepository.FakeTable.AddRange(productCategories);
        //}

        internal static List<Product> products => new List<Product> {
            new Product {Id = "0", Name = "Men's suit", Description = "Superior Men's suit", BiddingEndDate = Startup.FixedTime.AddMinutes(10)},
            new Product {Id = "1", Name = "Tracksuit", Description = "Kickass Tracksuit", BiddingEndDate = Startup.FixedTime.AddMinutes(3) },
            new Product {Id = "2", Name = "Hand dryer", Description = "Superior Men's suit", BiddingEndDate = Startup.FixedTime.AddMinutes(6) },
            new Product {Id = "3", Name = "Baseball club", Description = "Valueable Baseball club", BiddingEndDate = Startup.FixedTime.AddMinutes(12) },
            new Product {Id = "4", Name = "WD Blue 4TB Desktop Hard Disk Drive", Description = "Defective WD Blue 4TB Desktop Hard Disk Drive", BiddingEndDate = Startup.FixedTime.AddMinutes(4) },
            new Product {Id = "5", Name = "MSI Radeon RX 570", Description = "Kickass MSI Radeon RX 570", BiddingEndDate = Startup.FixedTime.AddMinutes(8)},
            new Product {Id = "6", Name = "Potato masher", Description = "Average Potato masher", BiddingEndDate = Startup.FixedTime.AddMinutes(3) },
            new Product {Id = "7", Name = "Woolen sweater", Description = "Superior Woolen sweater", BiddingEndDate = Startup.FixedTime.AddMinutes(9) },
            new Product {Id = "8", Name = "Golf club", Description = "Horrific Golf club", BiddingEndDate = Startup.FixedTime.AddMinutes(3) }
        };

        internal static List<Category> categories => new List<Category> {
            new Category {Id = "0", Name = "Cooking and kitchen" },
            new Category {Id = "1", Name = "Clothing" },
            new Category {Id = "2", Name = "Hygiene" },
            new Category {Id = "3", Name = "Computer hardware" },
            new Category {Id = "4", Name = "Sports" }
        };

        internal static List<ProductCategory> productCategories => new List<ProductCategory> {
            new ProductCategory {Id = "0", ProductId = getProductId(0), CategoryId = getCategoryId(1) },
            new ProductCategory {Id = "1", ProductId = getProductId(1), CategoryId = getCategoryId(1) },
            new ProductCategory {Id = "2", ProductId = getProductId(2), CategoryId = getCategoryId(2) },
            new ProductCategory {Id = "3", ProductId = getProductId(3), CategoryId = getCategoryId(4) },
            new ProductCategory {Id = "4", ProductId = getProductId(4), CategoryId = getCategoryId(3) },
            new ProductCategory {Id = "5", ProductId = getProductId(5), CategoryId = getCategoryId(3) },
            new ProductCategory {Id = "5", ProductId = getProductId(6), CategoryId = getCategoryId(0) },
            new ProductCategory {Id = "6", ProductId = getProductId(7), CategoryId = getCategoryId(1) },
            new ProductCategory {Id = "7", ProductId = getProductId(8), CategoryId = getCategoryId(4) }
        };

        //TODO Id = getId, not Id = "xx"
        private static string getId => Guid.NewGuid().ToString();
        private static string getProductId(int id) => products.ElementAt(id).Id;
        private static string getCategoryId(int id) => categories.ElementAt(id).Id;
    }
}
