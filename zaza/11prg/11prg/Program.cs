using System;

namespace _11prg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11, b = 32, c = 23;
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("эТО НЕ ТРЕУГОЛЬНИ");
            }
            else { Console.WriteLine("ЭТОЛ ТРЕУГОЛЬНИК"); }
            Console.ReadLine();
        }
    }
}
