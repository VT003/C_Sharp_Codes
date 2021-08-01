using System;

namespace OutputOfArthemeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Sum: " + (a + b));
            Console.WriteLine("Difference: " + (a - b));
            Console.WriteLine("Product: " + a * b);
            Console.WriteLine("Quotient: " + a / b);
            Console.WriteLine("Modulus: " + a % b);
        }
    }
}
