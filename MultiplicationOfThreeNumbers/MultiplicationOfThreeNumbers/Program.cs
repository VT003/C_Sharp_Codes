using System;

namespace MultiplicationOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Product: " + a * b * c);
        }
    }
}
