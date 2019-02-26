using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoss.Pizzas
{
    class Olives : PizzaDecorator
    {
        public Olives(Pizza pizza) : base(pizza.name + ", с маслинами", pizza)
        {

        }

        public override double Price()
        {
            return pizza.Price() + 6;
        }
    }
}
