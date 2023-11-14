using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: Views/Home/Index.cshtml
        public IActionResult Index()
        {
            return View();
        }
    }
}
