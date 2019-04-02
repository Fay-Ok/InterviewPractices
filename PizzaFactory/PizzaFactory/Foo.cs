using System;

namespace PizzaFactory
{
    internal class Foo
    {
        public static implicit operator Foo(Bar v)
        {
            throw new NotImplementedException();
        }

        public void hello()
        {
            Console.WriteLine("Hello");
        }
    }
}