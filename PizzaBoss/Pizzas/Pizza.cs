using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBoss.Pizzas
{
   abstract class Pizza
    {
       public string name;

       public Pizza(string name)
       {
           this.name = name;
       }

        public abstract double Price();

        public void PizzaStart()
        {
            Console.WriteLine("Пицца готовится");
        }
    }
}
