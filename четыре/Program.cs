using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int Sum = 0;    
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write(" {0} ", array[i]);
            }

            for (int i = 0; i < 20; i++)
            {
                if(array[i]%2!=0&&i%2==0)
                    Sum++;
                Console.WriteLine(Sum);
            }
            Console.ReadKey();
        }
    }
}