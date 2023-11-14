using Microsoft.AspNetCore.Mvc;
using ECommerceSite.Data;
using System.Linq;
using ECommerceSite.Model;
using System.Collections.Generic;

namespace ECommerceSite.Controllers
{
    public class ProductController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            return View(products); //'Index' under Views/Product
        }

        // GET: Products/Details/5
        public IActionResult Details(int id)
        {
            var product = _context.Product.FirstOrDefault(p => p.ProductId == id);
            return View(product); // Assuming a View named 'Details' under Views/Product
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