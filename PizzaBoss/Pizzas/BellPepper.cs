using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoss.Pizzas
{
    class BellPepper : PizzaDecorator
    {
        public BellPepper(Pizza pizza) : base(pizza.name + ", со сладким перцем", pizza)
        {

        }

        public override double Price()
        {
        return pizza.Price() + 4.5;
        }
    }
   
}
