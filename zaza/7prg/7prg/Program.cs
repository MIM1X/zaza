using System;

namespace _7prg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zaza = {1, 4 , 2, 3, 96 };
            int[] ZaVoynu = new int[5];
            for (int i = 0; i < zaza.Length; i++)
            {
                if (zaza[i]%2 == 0)
                {
                    Console.WriteLine(zaza[i]);
                }

            }
            for (int i = 0; i < zaza.Length; i++)
            {
                if (zaza[i] % 2 == 1)
                {
                    Console.WriteLine(zaza[i]);
                }

            }
            Console.ReadKey();
        }
    }
}
