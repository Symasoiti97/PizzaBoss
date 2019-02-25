using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBoss.Pizzas
{
    abstract class PizzaDecorator
    {
        Pizza pizza;

        public PizzaDecorator(Pizza pizza)
        {
            this.pizza=pizza;
        }

        
    }
}
