﻿using System;

namespace _08.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        static double RaiseToPower (double number, int power)
        {
            double result = 0.0;

            result = Math.Pow(number, power);

            return result;
        }
    }
}
