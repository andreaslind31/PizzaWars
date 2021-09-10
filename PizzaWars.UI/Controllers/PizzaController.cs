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
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public List<PizzaModel> Pizzas()
        {
            List<PizzaModel> pizzas = new List<PizzaModel>();
            pizzas = PizzaData.Pizzas();
            return pizzas;
        }
        
    }
}
