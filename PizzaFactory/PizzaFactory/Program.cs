using System;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new Pizza();

            Foo foo = new Bar();
            foo.hello();
        }
    }
}
