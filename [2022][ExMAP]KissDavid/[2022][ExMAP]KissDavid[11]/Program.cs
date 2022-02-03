using System;
using System.IO;

namespace _2022__ExMAP_KissDavid_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("../../../secventaincadrata.in");

            string[] values = reader.ReadToEnd().Split(' ');

            using StreamWriter writer = new StreamWriter("../../../secventaincadrata.out");

            int x = 0, mx = 0;
            int[] array = new int[10], maxLength = new int[10];

            for (int i = 0; i < values.Length; i++)
            {
                x = int.Parse(values[i]);

                maxLength[x] = Math.Max(i - array[x] + 1, maxLength[x]);

                if (array[x] == 0)
                {
                    array[x] = i;

                    maxLength[x] = 1;
                }

                mx = Math.Max(maxLength[x], mx);
            }

            writer.WriteLine(mx);

            for (int i = 0; i < 10; i++)
            {
                if (maxLength[i] == mx)
                {
                    writer.Write(i + " ");
                }
            }
        }
    }
}
