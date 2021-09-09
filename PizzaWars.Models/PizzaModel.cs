using System;
using System.Collections.Generic;

namespace PizzaWars.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Toppings { get; set; }
        public int HypeLevel { get; set; } = new Random().Next(1, 11);
        public string Image { get; set; }
    }
}
