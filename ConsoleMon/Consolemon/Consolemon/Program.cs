using System;

namespace Consolemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Consolemon dragon = new Consolemon();
            Consolemon pidgeon = new Consolemon(100,"rat",1);
            Console.ReadLine();
        }
    }
}
