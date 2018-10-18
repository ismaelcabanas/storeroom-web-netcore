using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using storeroom_web_netcore.Models;
using storeroom_web_netcore.Services;

namespace storeroom_web_netcore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreroomData _storeroomData;

        public HomeController(IStoreroomData storeroomData)
        {
            this._storeroomData = storeroomData;
        }
        public IActionResult Index()
        {
            var model = _storeroomData.GetAll();

            return View(model);
        }
    }
}