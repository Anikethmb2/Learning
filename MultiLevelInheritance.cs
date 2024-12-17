using System;

namespace Learning

{
    public class Aniketh
    {
        public Aniketh()
        {
            Console.WriteLine("Deafult Aniketh");
        }
        public Aniketh(int a):this()
        {
            Console.WriteLine("from Aniketh");
        }

    }

    public class Mahesha:Aniketh
    {
        public Mahesha(int c):base(2)
        {
            
            Console.WriteLine("from mahesha");
        }
    }

    public class Ravi:Mahesha
    {
        public Ravi():base(2)
        {
            Console.WriteLine("from Ravi");
        }
    }
}