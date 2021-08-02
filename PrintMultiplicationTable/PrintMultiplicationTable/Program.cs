using System;

namespace PrintMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("The Multiplication table of " + a + " is");
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(a + " x " + i + " = " + a * i);
                i++;
            }
        }
    }
}
