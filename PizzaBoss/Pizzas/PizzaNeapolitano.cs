using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoss.Pizzas
{
    class PizzaNeapolitano : Pizza
    {
        public PizzaNeapolitano() : base("Пицца Неаполитана")
        {

        }

        public override double Price()
        {
            return 50;
        }
    }
}
