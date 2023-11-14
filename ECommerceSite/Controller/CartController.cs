using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.Controller
{
    public class CartController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
