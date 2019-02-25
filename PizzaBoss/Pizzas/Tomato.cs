using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBoss.Pizzas
{
    class Tomato:PizzaDecorator
    {
        public Tomato(string name, Pizza pizza) :base(name)
        {
 
        }
    }
}
