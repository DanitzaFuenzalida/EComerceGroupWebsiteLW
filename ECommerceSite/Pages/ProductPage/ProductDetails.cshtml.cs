
using ECommerceSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.Pages
{
    public class ProductDetailsModel : PageModel
    {
        // Add a property to hold the product details
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Product Product { get; set; }

        public void OnGet()
        {
            // Replace this with actual data retrieval logic
            Product = GetProductById(Id);
        }

        private Product GetProductById(int productId)
        {
            // Replace this with actual data retrieval logic
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