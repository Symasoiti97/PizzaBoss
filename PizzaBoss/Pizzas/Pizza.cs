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

        public void Prepare()
        {
            Console.WriteLine("Пицца готовится");
        }

        public void Bake()
        {
            Console.WriteLine("Пицца печется");
        }

        public void Cut()
        {
            Console.WriteLine("Происходит нарезка пиццы");
        }

        public void Box()
        {
            Console.WriteLine("Происходит упаковка пиццы");
        }

    }
}
