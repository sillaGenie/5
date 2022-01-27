using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write(" {0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
                Console.Write(" {0} ", array[i]);
            }
            for (int i = 5; i<10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }
                }
                Console.Write(" {0} ", array[i]);
            }
        }
    }   
}