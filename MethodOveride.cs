using System;

namespace Learning
{
    public class Base
    {
        public virtual int add(int a, int b)
        {
            return a+b;
        }
    }

    public class Derive : Base
    {
        public override int add(int a,int b)
        {
            return a+b+5;
        }
    }

}