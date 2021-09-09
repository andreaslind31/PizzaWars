using PizzaWars.Models;
using System;
using System.Collections.Generic;

namespace PizzaWars.Data
{
    public class DummyData
    {
        public List<PizzaModel> ListOfPizzas()
        {
            int hypeLvls = new Random().Next(1, 11);
            PizzaModel vesuvio = new PizzaModel()
            { Id = 1, Name = "Vesuvio", HypeLevel = hypeLvls, Toppings = { "tomato sauce", "cheese", "ham" } };
            PizzaModel cappricciosa = new PizzaModel()
            { Id = 2, Name = "Cappricciosa", HypeLevel = hypeLvls, Toppings = { "tomato sauce", "cheese", "ham", "mushrooms" } };
            PizzaModel hawaii = new PizzaModel()
            { Id = 3, Name = "Hawaii", HypeLevel = hypeLvls, Toppings = { "tomato sauce", "cheese", "ham", "pineapple" } };
            PizzaModel quattroStagioni = new PizzaModel()
            { Id = 4, Name = "Quattro stagioni", HypeLevel = hypeLvls, Toppings = { "tomato sauce", "cheese", "ham", "shrimps", "mushrooms", "artichoke" } };

            List<PizzaModel> pizzas = new List<PizzaModel>() { vesuvio, cappricciosa, hawaii, quattroStagioni };
            return pizzas;
        }
        public static PizzaModel Pizza()
        {
            
            PizzaModel pizza = new PizzaModel() { Name = "Vesuvio", Id = 1 };
            pizza.Toppings = new List<string>() { "ham", "cheese", "tomatoes" };

            return pizza;
        }
    }
}
