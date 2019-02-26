using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBoss.Pizzas
{
    class PizzaPepperoni : Pizza
    {
        public PizzaPepperoni() : base("Пицца паперони") 
        {

        }

        public override double Price()
        {
            return 60;
        }
    }
}
