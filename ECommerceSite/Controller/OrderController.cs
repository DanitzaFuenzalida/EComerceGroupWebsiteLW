using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.Controller
{
    public class OrderController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
