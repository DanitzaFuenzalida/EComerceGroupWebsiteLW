//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using ECommerceSite.Model; // Assuming this is the namespace for your models
//using ECommerceSite.Data;
//// using YourNamespace.Data; // Replace with your actual DbContext namespace

//namespace ECommerceSite.Pages
//{
//    public class NewFallStylesModel : PageModel
//    {
//        private readonly YourDbContext _context; // Replace with your actual DbContext

//        public NewFallStylesModel(YourDbContext context)
//        {
//            _context = context;
//        }

//        public void OnGet()
//        {
//        }

//        public async Task<IActionResult> OnPostOrderAsync(int productId, int quantity)
//        {
//            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
//            if (product == null)
//            {
//                // If product doesn't exist
//                return Page();
//            }

//            var orderItem = new OrderItem
//            {
//                ProductId = productId,
//                Quantity = quantity,
//                UnitPrice = product.Price
//            };

//            // Add to an existing order or create a new one
//            // This logic depends on how you handle orders in your application

//            await _context.OrderItems.AddAsync(orderItem);
//            await _context.SaveChangesAsync();


//        }
//    }
//}
using ECommerceSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ECommerceSite.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ECommerceSite.Pages
{
    public class NewFallStylesModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context; //DbContext

        public NewFallStylesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        // "Order" button for a chair
        public IActionResult OnPostOrderChair()
        {
            // Product name
            var product = _context.Product.FirstOrDefault(p => p.Name == "Chair");
            if (product != null)
            {
                var orderItem = new OrderItem
                {
                    ProductId = product.ProductId,
                    Quantity = 1, //Have customer change this via razor page?
                    UnitPrice = product.Price
                };

                _context.UOrderItem.Add(orderItem);
                _context.SaveChanges();
            }

            return RedirectToPage("ShoppingCart");
        }

        public IActionResult OnPostOrderBed()
        {
            // Product name
            var product = _context.Product.FirstOrDefault(p => p.Name == "Bed");
            if (product != null)
            {
                var orderItem = new OrderItem
                {
                    ProductId = product.ProductId,
                    Quantity = 1, //Have customer change this via razor page?
                    UnitPrice = product.Price
                };

                _context.UOrderItem.Add(orderItem);
                _context.SaveChanges();
            }

            return RedirectToPage("ShoppingCart");
        }

        public IActionResult OnPostOrderTable()
        {
            // Product name
            var product = _context.Product.FirstOrDefault(p => p.Name == "Table");
            if (product != null)
            {
                var orderItem = new OrderItem
                {
                    ProductId = product.ProductId,
                    Quantity = 1, //Have customer change this via razor page?
                    UnitPrice = product.Price
                };

                _context.UOrderItem.Add(orderItem);
                _context.SaveChanges();
            }

            return RedirectToPage("ShoppingCart");
        }
    }
}
