using ECommerceSite.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ECommerceSite.Pages
{
    public class AddToCartModel : PageModel
    {
        private readonly ILogger<AddToCartModel> _logger;

        public AddToCartModel(ILogger<AddToCartModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int id)
        {
            HttpContext.Session.TryGetValue("Cart", out byte[] cartBytes);
            var cart = cartBytes != null ? JsonSerializer.Deserialize<List<CartItem>>(cartBytes) : new List<CartItem>();
            cart.Add(new CartItem { Product = GetProductById(id), Quantity = 1 });
            HttpContext.Session.Set("Cart", JsonSerializer.SerializeToUtf8Bytes(cart));

            RedirectToPage("/Index");
        }

        private Product GetProductById(int productId)
        {
            // Replace this with your actual data retrieval logic
            return new Product
            {
                ProductId = productId,
                Name = "Sample Product",
                Description = "Sample Description",
                Price = 29.99M,
                StockQuantity = 20,
                Category = "Electronics"
            };
        }
    }
}