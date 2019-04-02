using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class DeepDishPizza : PizzaMaking
    {
        public override string CreateCheese()
        {
            return "Adding less cheese";
        }

        public override string CreateDough()
        {
            return "Make a thicker dough";
        }
    }
}
