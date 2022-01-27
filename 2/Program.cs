using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int n = N;
            int m = N;
            int[,] t = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = ((i + j) % 2 == 0) ? 1 : 0;
                    Console.Write(" {0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}