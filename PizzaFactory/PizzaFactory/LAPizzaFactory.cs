using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class LAPizzaFactory : Pizza
    {
        public override PizzaMaking PizzaMaker()
        {
            return new DeepDishPizza();
        }
    }
}
