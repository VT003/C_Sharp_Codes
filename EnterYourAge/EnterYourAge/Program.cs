using System;

namespace EnterYourAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older than " + age);
        }
    }
}
