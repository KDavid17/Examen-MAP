using System;

namespace _2022__ExMAP_KissDavid_17_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduce m: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n * m; i++)
            {
                Console.Write((2 * (i - 1) + 1) * (2 * (i - 1) + 1) + " ");

                if (i % m == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
