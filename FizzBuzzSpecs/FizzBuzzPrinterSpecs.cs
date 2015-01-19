using System.Collections.Generic;
using FizzBuzz;
using Machine.Specifications;

namespace FizzBuzzSpecs
{
    public class FizzBuzzPrinterSpecs
    {
        public class when_using_the_default_substitution_rules 
        { 
            public class when_asked_to_print_1 { It should_print_1 = () => printer.Print(1).ShouldEqual("1"); }
            public class when_asked_to_print_2 { It should_print_2 = () => printer.Print(2).ShouldEqual("2"); }
            public class when_asked_to_print_3 { It should_print_fizz = () => printer.Print(3).ShouldEqual("fizz"); }
            public class when_asked_to_print_5 { It should_print_buzz = () => printer.Print(5).ShouldEqual("buzz"); }
            public class when_asked_to_print_15 { It should_print_fizzbuzz = () => printer.Print(15).ShouldEqual("fizzbuzz"); }

            Establish context = () => printer = new FizzBuzzPrinter();
        }

        public class when_using_a_set_of_custom_rules
        {
            public class when_asked_to_print_1 { It should_print_1 = () => printer.Print(1).ShouldEqual("1"); }
            public class when_asked_to_print_2 { It should_print_hello = () => printer.Print(2).ShouldEqual("hello"); }
            public class when_asked_to_print_3 { It should_print_3 = () => printer.Print(3).ShouldEqual("3"); }
            public class when_asked_to_print_4 { It should_print_helloworld = () => printer.Print(4).ShouldEqual("helloworld"); }
            public class when_asked_to_print_14 { It should_print_helloclearmeasure = () => printer.Print(14).ShouldEqual("helloclearmeasure"); }
            public class when_asked_to_print_28 { It should_print_helloworldclearmeasure = () => printer.Print(28).ShouldEqual("helloworldclearmeasure"); }

            Establish context = () =>
            {
                var rules = new Dictionary<int, string>
                {
                    {2, "hello"}, 
                    {4, "world"}, 
                    {7, "clearmeasure"}
                };
                printer = new FizzBuzzPrinter(rules);
            };
        }

        static FizzBuzzPrinter printer;
    }
}