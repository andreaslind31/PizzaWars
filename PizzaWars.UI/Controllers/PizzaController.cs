using Microsoft.AspNetCore.Mvc;
using PizzaWars.API;
using PizzaWars.Data;
using PizzaWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWars.UI.Controllers
{
    public class PizzaController : Controller
    {
        public async Task<IActionResult> Index()
        {

            PizzaModel pizza = await PizzaProcessor.LoadPizza();

            pizza.Name = "Random pizza nr1";
            pizza.Id = 1;
            pizza.Toppings = new List<string> { "ham", "cheese", "tomatoes" };


            return View(pizza);
        }
        public IActionResult Edit(string name, int id, int hypelevel, List<string> toppings)
        {
            ViewBag.name = name;
            ViewBag.id = id;
            ViewBag.hypelevel = hypelevel;
            ViewBag.toppings = toppings;

            return View();
        }
    }
}
