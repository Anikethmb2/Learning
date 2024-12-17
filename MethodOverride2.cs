using System;

namespace Learning
{
    public class Parent
    {
        internal virtual void print()
        {
            Console.WriteLine("p");
        }

        public void DoSomething()
        {
            Console.WriteLine("Method Hiding");
        }
    }

    public class Child:Parent
    {
        internal override void print()
        {
            //base.print();
            Console.WriteLine("c");
        }

        public new void DoSomething()
        {
            Console.WriteLine("Method Hidden");
        }

    }
}