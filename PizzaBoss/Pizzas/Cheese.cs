using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoss.Pizzas
{
    class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza.name + ", с сыром", pizza)
        {
              
        }

        public override double Price()
        {
            return pizza.Price() + 7;
        }
    }
}
