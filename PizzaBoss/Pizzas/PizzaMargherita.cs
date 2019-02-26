using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoss.Pizzas
{
    class PizzaMargherita : Pizza
    {
        public PizzaMargherita() : base("Пицца Маргарита")
        {

        }

        public override double Price()
        {
            return 40;
        }
    }
}
