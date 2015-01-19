using System;
using System.Collections.Generic;
using FizzBuzz;

namespace FizzBuzzConsole
{
    static class Program
    {
        static void Main()
        {
            var rules = new Dictionary<int, string>{
                {3, "fizz"},
                {5, "buzz"},
                {7, "clear"},
                {10, "measure"},
            };
            var fizzBuzzPrinter = new FizzBuzzPrinter(rules);
            for(var i = 1; i <= 100; i++)
            {
                Console.Write(fizzBuzzPrinter.Print(i));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
