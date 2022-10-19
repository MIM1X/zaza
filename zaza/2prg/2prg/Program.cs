using System;

namespace _2prg
{
    class Program
    {
        static void Main(string[] args)
        {
        zaza:
            Console.Clear();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a == b && b == c && c == d)
            {
                Console.WriteLine("все числа равны между собой");
            }
            else { Console.WriteLine("числа не равны"); }
            Console.ReadLine();
            goto zaza;
        }
    }
}
