using System;

namespace Sample501
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[3];
            d[0] = 1;
            d[1] = 2;
            d[2] = 3;
            for (int i = 0; i < d.Length; i += 1)
            {
                Console.WriteLine(d[i]);
            }

            int[] n = { 4, 3, 2, 1 };
            for (int i = 0; i < n.Length; i += 1)
            {
                Console.WriteLine(n[i]);
            }

            foreach (int i in n)
            {
                Console.WriteLine(i);
            }

            int[,] a = new int[3, 4];
            for (int i = 0; i < 3; i += 1)
            {
                for (int j = 0; j < 4; j += 1)
                {
                    a[i, j] = i + j;
                }
            }

            int[][] b = new int[][] { new int[] { 0, 1 }, new int[] { 2 }, new int[] { 3, 4, 5, 6 } };
            for (int i = 0; i < b.Length; i += 1)
            {
                for (int j = 0; j < b[i].Length; j += 1)
                {
                    Console.WriteLine(b[i][j]);
                }
            }
        }
    }
}
