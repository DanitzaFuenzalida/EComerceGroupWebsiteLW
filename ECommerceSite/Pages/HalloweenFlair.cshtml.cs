using ECommerceSite.Data;
using ECommerceSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.Pages
{
    public class HalloweenFlairModel : PageModel
    {
        private readonly ApplicationDbContext _context; //DbContext

        public HalloweenFlairModel(ApplicationDbContext context)
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
