﻿using System;

namespace _07.TheatrePromotions
{
    class TheatrePromotions
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (day.Equals("Weekday"))
            {
                if (age < 18)
                {
                    price = 12;
                }
                else if (age > 18 && age < 64)
                {
                    price = 18;
                }
                else if (age > 64)
                {
                    price = 12;
                }

            }

            if (day.Equals("Weekend"))
            {
                if (age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64)
                {
                    price = 15;
                }
            }

            if (day == "Holiday")
            {
                if (age <= 18)
                {
                    price = 5;
                }
                if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                if (age > 64)
                {
                    price = 10;
                }
            }

            Console.WriteLine($"{price}$");
        }
    }
}
