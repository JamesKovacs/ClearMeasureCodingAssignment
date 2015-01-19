using System;
using FizzBuzz;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main()
        {
            var fizzBuzzPrinter = new FizzBuzzPrinter();
            for(var i = 1; i <= 100; i++)
            {
                Console.Write(fizzBuzzPrinter.Print(i));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
