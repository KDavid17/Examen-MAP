using System.IO;

namespace _2022__ExMAP_KissDavid_2_
{
    internal class Program
    {
        private static int size;
        private static int[] values;

        private static bool Verify(int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                if (values[i] == values[pos])
                {
                    return false;
                }
            }
            return true;
        }
        private static void Backtrack(int pos, StreamWriter writer)
        {
            for (int i = 1; i <= size; i++)
            {
                values[pos] = i;

                if (Verify(pos))
                {
                    if (pos == size - 1)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            writer.Write(values[j] + " ");
                        }
                        writer.WriteLine();
                    }
                    else
                    {
                        Backtrack(pos + 1, writer);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("../../../permutari.in");

            size = int.Parse(reader.ReadToEnd());

            values = new int[size];

            using StreamWriter writer = new StreamWriter("../../../permutari.out");

            Backtrack(0, writer);
        }
    }
}
