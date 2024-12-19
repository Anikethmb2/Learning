using System;

namespace Learning
{
    public class Vehicle
    {
        public void seatCapacity(int seat)
        {
            Console.WriteLine("The seat capacity is "+ seat);
        }

        public void noOfWheels(int noofwheels)
        {
            Console.WriteLine("Number of wheels "+ noofwheels);
        }
    }


    public class Cars: Vehicle
    {
        public void transmission()
        {
            Console.WriteLine("All car has automatic and manual transmission");
        }
    }

    public class Bus : Vehicle
    {
        public void fuelCapacity()
        {
            Console.WriteLine("Bus fuel capacity is 30 ltr ");
        }
    }
}