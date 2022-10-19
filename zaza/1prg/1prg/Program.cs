using System;

namespace _1prg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a) " + (double)(101 + 0) / 3);
            Console.WriteLine("b) " + 3.0e-6 * 10000000.1);
            Console.WriteLine("c) " + (true && true));
            Console.WriteLine("d) " + (false && true));
            Console.WriteLine("e) " + (false && false) + " " + (true && true));
            Console.WriteLine("f) " + ((false && false) && (true && true)));

            Console.ReadKey();
        }
    }
}
