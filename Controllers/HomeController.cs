using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using storeroom_web_netcore.Models;
using storeroom_web_netcore.Services;
using storeroom_web_netcore.ViewModels;

namespace storeroom_web_netcore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreroomData _storeroomData;
        private IGreeter _greeter;

        public HomeController(IStoreroomData storeroomData, IGreeter greeter)
        {
            this._storeroomData = storeroomData;
            this._greeter = greeter;
        }
        public IActionResult Index()
        {
            var storerooms = _storeroomData.GetAll();
            var message = _greeter.GetGreeterMessageOfTheDay();

            var viewModel = new StoreroomViewModel(storerooms, message);    
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var storeroom = _storeroomData.Get(id);

            return Content(storeroom.Name);
        }
    }
}