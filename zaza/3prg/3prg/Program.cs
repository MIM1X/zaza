using System;
using System.Linq;
namespace _3prg
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = int.Parse(Console.ReadLine());
            Console.Clear();
            int[] k = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine(k.Max());
                k[Array.IndexOf(k, k.Max())] = k.Min() - 1;
            }
            Console.ReadLine();
        }
    }
}
