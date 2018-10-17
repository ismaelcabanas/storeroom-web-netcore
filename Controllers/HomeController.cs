using Microsoft.AspNetCore.Mvc;

namespace storeroom_web_netcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello from HomeController");
        }
    }
}