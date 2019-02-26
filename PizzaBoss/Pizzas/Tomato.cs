using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBoss.Pizzas
{
    class Tomato : PizzaDecorator
    {
        public Tomato(Pizza pizza) :base(pizza.name + ", c томатом", pizza)
        {

        }

        public override double Price()
        {
            return pizza.Price() + 5;
        }

    }
}
