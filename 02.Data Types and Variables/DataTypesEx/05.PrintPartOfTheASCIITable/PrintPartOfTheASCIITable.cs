﻿using System;

namespace _05.PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
