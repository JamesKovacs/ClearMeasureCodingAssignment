using System;

namespace CodingAssignment
{
    public class FizzBuzzPrinter
    {
        public static string Print(int number)
        {
            // print numbers 1 to 100
            // if divisible by 3 print fizz
            // if divisible by 5 print buzz
            var result = String.Empty;
            if(number % 3 == 0) result += "fizz";
            if(number % 5 == 0) result += "buzz";
            if(number%3 != 0 && number%5 != 0) result += number;
            return result;
        }
        // recruiting@clear-measure.com
        // pluggable number v. token e.g. 7 Hello 10 Goodbye
    }
}
