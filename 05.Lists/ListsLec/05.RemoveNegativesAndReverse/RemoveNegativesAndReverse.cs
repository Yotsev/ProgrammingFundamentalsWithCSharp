﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            numbers.Reverse();

            if (numbers.Count ==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
