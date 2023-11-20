using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.Pages.ProductPage
{
    public class ShopModel : PageModel
    {
        private readonly ILogger<ShopModel> _logger;

        public ShopModel(ILogger<ShopModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            // Initialization code or GET requests
        }

        // Add methods (OnPost or form submissions)
    }
}