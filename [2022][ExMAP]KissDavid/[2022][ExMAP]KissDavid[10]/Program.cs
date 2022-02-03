using System;

namespace _2022__ExMAP_KissDavid_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduce m: ");
            int m = int.Parse(Console.ReadLine());

            int k = 0;

            Console.Write("Minim: ");

            if (m * 2 >= n)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(n - 2 * m);
            }

            while (k * (k - 1) / 2 < m)
            {
                k++;
            }

            Console.WriteLine("Maxim: " + (n - k));
        }
    }
}
