using Microsoft.AspNetCore.Mvc;

namespace SimpleDotNetHtmlApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
