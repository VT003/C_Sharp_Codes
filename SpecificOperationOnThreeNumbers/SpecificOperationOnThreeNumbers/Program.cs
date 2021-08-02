using System;

namespace SpecificOperationOnThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Output of (x + y) * z: " + (x + y) * z);
            Console.WriteLine("Output of (x * y) + (y * z): " + ((x + y) * (y * z)));
        }
    }
}
