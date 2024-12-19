using System;

namespace Learning
{
    class MethodOverloading
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

        public void displayNameId(string name, int id)
        {
            Console.WriteLine("Name: "+name + " | id: "+ id);
        }

        public void displayNameId(int id,string name)
        {
            Console.WriteLine("Name: "+name + " | id: "+ id);
        }
    }
}