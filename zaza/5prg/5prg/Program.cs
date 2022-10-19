using System;

namespace _5prg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] k = { 1,2,3,4,56,8,0,38,9575,69,228,1337,13,7,4,1488,304,8964};
            int numAll = 0;
            for (int i = 0; i < k.Length; i++) numAll += k[i];
            double sredChislo = numAll / k.Length;
            for (int i = 0; i < k.Length; i++) if (sredChislo < k[i]) { Console.WriteLine(k[i]); };
            Console.ReadKey();
        }
    }
}
