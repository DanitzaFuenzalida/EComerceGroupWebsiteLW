using Microsoft.AspNetCore.Mvc;


namespace ECommerceSite.Controller
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
