using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.Views.Home
{
    public class SampleProductModel : PageModel
    {
        private readonly ILogger<SampleProductModel> _logger;

        public SampleProductModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}