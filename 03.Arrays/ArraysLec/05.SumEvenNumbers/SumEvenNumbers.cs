﻿using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 ==0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
