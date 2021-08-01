using System;

namespace PrintResultOfSpecifiedOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = -1 + (4 * 6);
            Console.WriteLine("Specified Operation: -1 + 4 * 6: " + a);
            a = (35 + 5) % 7;
            Console.WriteLine("Specified Operation: ( 35+ 5 ) % 7: " + a);
            a = 14 + -4 * 6 / 11;
            Console.WriteLine("Specified Operation: 14 + -4 * 6 / 11: " + a);
            a = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("Specified Operation: 2 + 15 / 6 * 1 - 7 % 2: " + a);
        }
    }
}
