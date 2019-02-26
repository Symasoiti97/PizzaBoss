using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaBoss.Pizzas;

namespace PizzaBoss
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new PizzaPepperoni();
            Console.WriteLine($"{pizza.name} цена: {pizza.Price()}");
            pizza = new Tomato(pizza);
            Console.WriteLine($"{pizza.name} цена: {pizza.Price()}");
            pizza = new Chilli(pizza);
            Console.WriteLine($"{pizza.name} цена:{pizza.Price()}");
            Console.ReadKey();
        }
    }
}
