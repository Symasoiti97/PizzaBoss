using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoss.Pizzas
{
    class Chilli : PizzaDecorator
    {
        public Chilli(Pizza pizza) : base(pizza.name + ", с перцем чилли", pizza)
        {

        }

        public override double Price()
        {
            return pizza.Price() + 4.5;
        }
    }
}
