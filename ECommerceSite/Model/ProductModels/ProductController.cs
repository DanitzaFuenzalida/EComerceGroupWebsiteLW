
// ProductsController.cs
using ECommerceSite.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerceSite.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            // Retrieve a list of products (replace with data retrieval logic)
            var products = GetProducts();
            return View(products);
        }

        private List<Product> GetProducts()
        {
            // Replace this with actual data retrieval logic
            return new List<Product>
            {
                new Product { ProductId = 1, Name = "Product 1", Description = "Description 1", Price = 19.99M, StockQuantity = 10, Category = "Electronics" },
                new Product { ProductId = 2, Name = "Product 2", Description = "Description 2", Price = 29.99M, StockQuantity = 15, Category = "Clothing" },
                // Add more products as needed
            };
        }
    }
}
