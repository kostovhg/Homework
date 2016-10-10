﻿using System;

namespace ex04_DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void PrintTopBottom(int n)
        {
            Console.WriteLine(new string('-', 2 * n));

        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopBottom(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintTopBottom(n);
        }
    }
}
