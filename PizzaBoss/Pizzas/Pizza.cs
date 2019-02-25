using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBoss.Pizzas
{
   abstract class Pizza
    {
       string name;

       public Pizza(string name)
       {
           this.name = name;
       }

       abstract public  double Price();
       
 
       
    }
}
