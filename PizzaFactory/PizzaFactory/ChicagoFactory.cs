using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    class ChicagoFactory : Pizza
    {
        public override PizzaMaking PizzaMaker()
        {
            return new ChicagoStylePizza();
        }
    }
}
