using PizzaWars.Models;
using System;
using System.Collections.Generic;

namespace PizzaWars.Data
{
    public class DummyData
    {
        public List<PizzaModel> ListOfPizzas()
        {
            PizzaModel vesuvio = new PizzaModel()
            { Id = 1, Name = "Vesuvio" };
            vesuvio.Toppings = new List<string> { "tomato sauce", "cheese", "ham" };
            PizzaModel cappricciosa = new PizzaModel()
            { Id = 2, Name = "Cappricciosa" };
            cappricciosa.Toppings = new List<string>() { "tomato sauce", "cheese", "ham", "mushrooms" };
            PizzaModel hawaii = new PizzaModel()
            { Id = 3, Name = "Hawaii" };
            hawaii.Toppings = new List<string>() { "tomato sauce", "cheese", "ham", "pineapple" };
            PizzaModel quattroStagioni = new PizzaModel()
            { Id = 4, Name = "Quattro stagioni" };
            quattroStagioni.Toppings = new List<string>() { "tomato sauce", "cheese", "ham", "shrimps", "mushrooms", "artichoke" };
            PizzaModel funghi = new PizzaModel()
            { Id = 5, Name = "Funghi" };
            funghi.Toppings = new List<string>() { "tomato sauce", "cheese", "mushrooms" };
            PizzaModel kebabpizza = new PizzaModel()
            { Id = 6, Name = "Kebabpizza" };
            kebabpizza.Toppings = new List<string>() { "tomato sauce", "cheese", "mushrooms", "gyros kebab" };
            PizzaModel HV71 = new PizzaModel()
            { Id = 7, Name = "HV71" };
            HV71.Toppings = new List<string>() { "tomato sauce", "cheese", "mushrooms", "gyros kebab", "shrimps", "pineapple" };
            PizzaModel pepperoni = new PizzaModel()
            { Id = 8, Name = "Pepperoni" };
            pepperoni.Toppings = new List<string>() { "tomato sauce", "cheese", "pepperoni salami" };
            PizzaModel margaretha = new PizzaModel()
            { Id = 9, Name = "Marghareta" };
            margaretha.Toppings = new List<string>() { "tomato sauce", "cheese" };
            PizzaModel tropicana = new PizzaModel()
            { Id = 10, Name = "Tropicana" };
            tropicana.Toppings = new List<string>() { "tomato sauce", "cheese", "pineapple", "banana" };

            List<PizzaModel> pizzas = new List<PizzaModel>()
            { vesuvio, cappricciosa, hawaii, quattroStagioni, funghi, kebabpizza, HV71, pepperoni, tropicana, margaretha };

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
