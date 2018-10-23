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
            if (storeroom == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(storeroom);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StoreroomEditViewModel model)
        {
            var storeroom = new Storeroom() {
                Name = model.Name
            };
            Storeroom storeroomCreated = _storeroomData.Add(storeroom);

            return View("Details", storeroomCreated);
        }
    }
}