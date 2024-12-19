using System;

namespace Learning
{
    public class A
    {
         int a;

        public A()
        {
            Console.WriteLine("calling default");
        }
        public A(int a)
        {
            this.a =a;
           Console.WriteLine("a is : "+ a) ;
        }
    }

    public class B:A
    {
        //Base(2);
    }
}