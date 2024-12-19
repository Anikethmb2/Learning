using System;

namespace Learning
{
    public class ConstructorExample
    {
        public int id;
        public string name;

        public ConstructorExample()
        {
            Console.WriteLine("This is default constructor");
        }

        public ConstructorExample(int id, string name)
        {
            this.id=id;
            this.name=name;
        }

         static ConstructorExample()
         {
            Console.WriteLine("this is static constructor");
         }
    }
}