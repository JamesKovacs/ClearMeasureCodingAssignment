using CodingAssignment;
using Machine.Specifications;

namespace FizzBuzzSpecs
{
    public class FizzBuzzPrinterSpecs
    {
        public class when_asked_to_print_1 { It should_print_1 = () => FizzBuzzPrinter.Print(1).ShouldEqual("1"); }
        public class when_asked_to_print_2 { It should_print_2 = () => FizzBuzzPrinter.Print(2).ShouldEqual("2"); }
        public class when_asked_to_print_3 { It should_print_fizz = () => FizzBuzzPrinter.Print(3).ShouldEqual("fizz"); }
        public class when_asked_to_print_5 { It should_print_buzz = () => FizzBuzzPrinter.Print(5).ShouldEqual("buzz"); }
        public class when_asked_to_print_15 { It should_print_fizzbuzz = () => FizzBuzzPrinter.Print(15).ShouldEqual("fizzbuzz"); }
    }
}