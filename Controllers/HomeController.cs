using Microsoft.AspNetCore.Mvc;
using storeroom_web_netcore.Models;

namespace storeroom_web_netcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Storeroom {Id = 1, Name = "My storeoom"};

            return View("home");
        }
    }
}