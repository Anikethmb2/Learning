using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object to ClassExample
           Car obj = new Car();
           obj.display();

           // Creating construcot
           ConstructorExample constructorExample1 = new ConstructorExample();
           ConstructorExample constructorExample2 = new ConstructorExample(5,"Ram");
           Console.WriteLine("this is parameterized constructor id " + constructorExample2.id +" and name "+ constructorExample2.name);

        }
        
    }
}
