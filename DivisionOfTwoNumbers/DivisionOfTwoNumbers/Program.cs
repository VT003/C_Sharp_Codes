using System;

namespace DivisionOfTwoNumbers
{
    class Program
    {
        /// <summary>
        /// Division of two numbers.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("The Quotient is: " + a / b);
            Console.WriteLine("The Remainder is: " + a % b);
        }
    }
}
