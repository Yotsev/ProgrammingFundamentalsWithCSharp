﻿using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    // https://www.youtube.com/watch?v=N-AlTemCnMc&t=1495s
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] lis;
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }
                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
