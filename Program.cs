﻿using System;

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
            // ----------------------------------single inhertance
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


            //-------------------method overide-------------
            Base obj3 = new Base();

            int sum=obj3.add(2,5);
            Console.WriteLine("invoke base class function "+ sum);

             obj3 = new Derive();                   // multiple way of creating object
            
            int total = obj3.add(2,5);
            Console.WriteLine("invoke derive class function "+ total);

            Derive obj4 = new Derive();
            total = obj4.add(2,5);
            Console.WriteLine("invoke derive class function "+ total);

            Base obj5 = new Derive();
            total = obj5.add(2,5);
            Console.WriteLine("invoke derive class function "+ total);

            //----------------abstract----------------
            Square sh = new Square(5);
            sh.area();


            //--------------------Encapsulation-------------------
            Encapsulate encapsulate = new Encapsulate();

            encapsulate.Name="Aniketh";
            encapsulate.Id =25;

            Console.WriteLine("This is Encapsulation Example printing name and id");
            Console.WriteLine("Name: "+encapsulate.Name + " | id: "+ encapsulate.Id);




            //---------------------- constructor example 2----------------------------
            Student student =new   Student();
            student.id=22;
            student.name="Aniketh";
            Console.WriteLine("constructor example id :"+student.id + " |name "+ student.name);
            Student student1 = new Student(student);
               Console.WriteLine("id :"+student1.id + " name: "+ student1.name);

               Student student2=student;
               student2.name="madesha";

               Console.WriteLine(student.name);

        }

    }
}
