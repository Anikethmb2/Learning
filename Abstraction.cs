using System;

namespace Learning
{
    public abstract class shape
    {
        public abstract void area();
        
    }

    public class Square : shape
    {
        int length;

        public Square(int length)
        {
            this.length=length;
        }

        public override void area()
        {
            int area = length*length;
            Console.WriteLine("Area of Square is : " + area);
        }
    }

}