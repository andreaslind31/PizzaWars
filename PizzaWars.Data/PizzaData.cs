using PizzaWars.API;
using PizzaWars.Models;
using System;
using System.Collections.Generic;

namespace PizzaWars.Data
{
    public class PizzaData
    {
        public static List<PizzaModel> Pizzas()
        {
            var pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel pizza1 = new PizzaModel() { Name = "kinda Vesuvio", Id = 1 };
            pizza1.Image = pizzaImg.Result.Image;
            List<string> toppings = new List<string>() { "ham", "cheese", "tomatosauce" };
            pizza1.Toppings = toppings;

            pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel pizza2 = new PizzaModel() { Name = "almost Cappricciosa", Id = 2 };
            pizza2.Image = pizzaImg.Result.Image;
            toppings = new List<string>() { "ham", "cheese", "tomatosauce", "mushrooms" };
            pizza2.Toppings = toppings;


            pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel pizza3 = new PizzaModel() { Name = "possibly Hawaii", Id = 3 };
            pizza3.Image = pizzaImg.Result.Image;
            toppings = new List<string>() { "ham", "cheese", "tomatosauce", "pineapple" };
            pizza3.Toppings = toppings;

            pizzaImg = PizzaProcessor.LoadPizza();
            PizzaModel pizza4 = new PizzaModel() { Name = "Funghi-like", Id = 4 };
            pizza4.Image = pizzaImg.Result.Image;
            toppings = new List<string>() { "mushrooms", "cheese", "tomatosauce" };
            pizza4.Toppings = toppings;

            List<PizzaModel> pizzas = new List<PizzaModel>() { pizza1, pizza2 };
            return pizzas;
        }
        public static PizzaModel Pizza()
        {
            //this method is not used
            PizzaModel pizza = new PizzaModel() { Name = "Vesuvio", Id = 1 };
            pizza.Toppings = new List<string>() { "ham", "cheese", "tomatoes" };

            return pizza;
        }
    }
}
