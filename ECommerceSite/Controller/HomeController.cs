using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Views/Home/Index.cshtml
        public IActionResult Index()
        {
            return View();
        }
    }
}
