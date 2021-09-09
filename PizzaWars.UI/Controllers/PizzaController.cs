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

            List<string> pizzaNames = new List<string>();
            pizzaNames = Enum.GetNames(typeof(PizzaNamesEnum)).ToList();
            string nameRandom = pizzaNames[new Random().Next(0, pizzaNames.Count())];
            pizza.Name = nameRandom;

            int idRandom = new Random().Next(1, 11);

            pizza.Id = idRandom;

            pizza.Toppings = new List<string>();
            List<string> toppings = new List<string>();
            toppings = Enum.GetNames(typeof(PizzaToppingsEnum)).ToList();
           

            for (int i = 0; i < 4; i++)
            {
                string randomTopping = toppings[new Random().Next(0, toppings.Count())];
                pizza.Toppings.Add(randomTopping);
            }

            //pizza.Name = "Random pizza nr1";
            //pizza.Id = 1;
            //pizza.Toppings = new List<string> { "ham", "cheese", "tomatoes" };


            return View(pizza);
        }
        [HttpGet]
        public List<PizzaModel> Pizzas()
        {
            var pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel vesuvio = new PizzaModel() { Name = "Vesuvio", Id = 1 };
            vesuvio.Image = pizzaImg.Result.Image;
            List<string> toppings = new List<string>() { "ham", "cheese", "tomatsauce" };
            vesuvio.Toppings = toppings;

            pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel cappricciosa = new PizzaModel() { Name = "Cappricciosa", Id = 2 };
            cappricciosa.Image = pizzaImg.Result.Image;
            toppings = new List<string>(){ "ham", "cheese", "tomatsauce", "mushrooms"};
            cappricciosa.Toppings = toppings;


            pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel hawaii = new PizzaModel() { Name = "Hawaii", Id = 3 };
            hawaii.Image = pizzaImg.Result.Image;
            toppings = new List<string>() { "ham", "cheese", "tomatsauce", "pineapple" };
            hawaii.Toppings = toppings;
            
            List<PizzaModel> pizzas = new List<PizzaModel>() { vesuvio, cappricciosa, hawaii };

            return pizzas;
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
