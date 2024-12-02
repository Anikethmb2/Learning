using System;
using System.Reflection;
using Microsoft.VisualBasic;

namespace Learning
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("this is base class");
        }
    }

    public class DerviedClass : BaseClass
    {
        public DerviedClass()
        {
            Console.WriteLine("this is derive class ");
        }
    }

}