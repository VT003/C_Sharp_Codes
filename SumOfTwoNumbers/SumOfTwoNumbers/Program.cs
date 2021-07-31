using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + (a + b));
        }
    }
}
