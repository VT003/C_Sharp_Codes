﻿using System;

namespace FourNumberAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter four number: ");
            int d = int.Parse(Console.ReadLine());
            float avg = (a + b + c + d) / 4;
            Console.WriteLine("Average of given four number: " + avg);

        }
    }
}
