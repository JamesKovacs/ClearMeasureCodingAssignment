using System;
using CodingAssignment;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main()
        {
            for(var i = 1; i <= 100; i++)
            {
                Console.Write(FizzBuzzPrinter.Print(i));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
