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
        //public async Task<IActionResult> Index()
        //{
        //    PizzaModel pizza = await PizzaProcessor.LoadPizza();

        //    List<string> pizzaNames = new List<string>();
        //    pizzaNames = Enum.GetNames(typeof(PizzaNamesEnum)).ToList();
        //    string nameRandom = pizzaNames[new Random().Next(0, pizzaNames.Count())];
        //    pizza.Name = nameRandom;

        //    int idRandom = new Random().Next(1, 11);

        //    pizza.Id = idRandom;

        //    pizza.Toppings = new List<string>();
        //    List<string> toppings = new List<string>();
        //    toppings = Enum.GetNames(typeof(PizzaToppingsEnum)).ToList();
           

        //    for (int i = 0; i < 4; i++)
        //    {
        //        string randomTopping = toppings[new Random().Next(0, toppings.Count())];
        //        pizza.Toppings.Add(randomTopping);
        //    }


        //    return View(pizza);
        //}
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public List<PizzaModel> Pizzas()
        {
            var pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel pizza1 = new PizzaModel() { Name = "kinda Vesuvio", Id = 1 };
            pizza1.Image = pizzaImg.Result.Image;
            List<string> toppings = new List<string>() { "ham", "cheese", "tomatosauce" };
            pizza1.Toppings = toppings;

            pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel pizza2 = new PizzaModel() { Name = "almost Cappricciosa", Id = 2 };
            pizza2.Image = pizzaImg.Result.Image;
            toppings = new List<string>(){ "ham", "cheese", "tomatosauce", "mushrooms"};
            pizza2.Toppings = toppings;


            pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel pizza3 = new PizzaModel() { Name = "possibly Hawaii", Id = 3 };
            pizza3.Image = pizzaImg.Result.Image;
            toppings = new List<string>() { "ham", "cheese", "tomatosauce", "pineapple" };
            pizza3.Toppings = toppings;
            
            List<PizzaModel> pizzas = new List<PizzaModel>() { pizza1, pizza2, pizza3 };

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
