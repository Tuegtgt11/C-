﻿using System;

namespace Ex5
{
    class Ex5
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                n = 0;
                Console.WriteLine("Enter n: (1-20)");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 20);

            int a = 1;
            for (int i = 1; i < n; i++)
            {
                a *= i;
            }

            Console.WriteLine($"{n}! = {a}");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
