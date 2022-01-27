using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int[] array = new int[7];
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write(" {0} ", array[i]);
            }
            Console.WriteLine();
            Console.Write(" {0:f2} ", S / 7);
        }
    }
}