using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class ChicagoStylePizza : PizzaMaking
    {
        public override string CreateCheese()
        {
            return "Add more cheese";
        }

        public override string CreateDough()
        {
            return "Adding thin dough";
        }
    }
}
