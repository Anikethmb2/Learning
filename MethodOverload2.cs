using System;

namespace Learning
{
    class MethodOverloading2
    {
        public void add(int a,int b )
        {
            int sum = a + b;
            Console.WriteLine("Addition of two integer number: "+ sum);
        }

        public void add(float a,float b)
        {
            float sum = a+b;
            Console.WriteLine("Addition of two float number is:"+ sum);
        }

        public void add(int a,int b,int c)
        {
            int sum=a+b+c;
            Console.WriteLine("Addition of three integer number is:" +sum);
        }

        public void add(int a , float b)
        {
            float sum = a + b;
            Console.WriteLine("Addition of int and float number: "+sum);
        }

public void add(float a , int b)
        {
            float sum = a + b;
            Console.WriteLine("Addition of int and float number: "+sum);
        }
    

    }
}