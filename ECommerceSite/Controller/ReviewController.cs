using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.Controller
{
    public class ReviewController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
