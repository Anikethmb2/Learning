using System;


using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Learning
{
    public class Car
    {
            string color="red";

            int transmission=5;

            public void display()
            {
                Console.WriteLine("This car color is " + color + " and Transmission is "+ transmission );
            }

    } 
}