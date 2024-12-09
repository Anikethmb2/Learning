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

           // Creating constructor
           ConstructorExample constructorExample1 = new ConstructorExample();
           ConstructorExample constructorExample2 = new ConstructorExample(5,"Ram");
           Console.WriteLine("this is parameterized constructor id " + constructorExample2.id +" and name "+ constructorExample2.name);
            Console.WriteLine("--------------------Inhertance------------------------------");
            // single inhertance
            DerviedClass obj1 = new DerviedClass();

            //----------------hierarchical inhertance----------------------------
            Cars cars = new Cars();
            Bus bus = new Bus();
            cars.seatCapacity(5);
            cars.noOfWheels(4);
            cars.transmission();

            bus.seatCapacity(45);
            bus.noOfWheels(6);
            bus.fuelCapacity();


            //----------------Method overload -------------------
            MethodOverloading methodOverloading =   new MethodOverloading();
            methodOverloading.add(2,3);
            methodOverloading.add(3.5f,5.5f);
            methodOverloading.add(5,6,7);
            methodOverloading.displayNameId("Aniketh",25);
            methodOverloading.displayNameId(25,"Aniketh");
        }

    }
}
