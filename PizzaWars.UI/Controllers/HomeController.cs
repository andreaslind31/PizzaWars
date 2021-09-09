using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaWars.API;
using PizzaWars.Models;
using PizzaWars.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWars.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public List<PizzaModel> HomePizzaImg()
        {
            var pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel homePizzaImg = new PizzaModel();
            homePizzaImg.Image = pizzaImg.Result.Image;
            List<PizzaModel> homePizzaList = new List<PizzaModel>() { homePizzaImg };

            return homePizzaList;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
