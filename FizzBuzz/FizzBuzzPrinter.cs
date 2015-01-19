using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    // recruiting@clear-measure.com
    // pluggable number v. token e.g. 7 Hello 10 Goodbye
    public class FizzBuzzPrinter
    {
        private readonly IDictionary<int, string> defaultFizzBuzzSubstitutions = new Dictionary<int, string>{{3, "fizz"}, {5, "buzz"}};
        private readonly IDictionary<int, string> substitutions;

        public FizzBuzzPrinter(IDictionary<int, string> substitutions = null)
        {
            this.substitutions = substitutions ?? defaultFizzBuzzSubstitutions;
        }

        public string Print(int number)
        {
            var applicableRules = substitutions.Where(pair => number%pair.Key == 0).ToList();
            if(applicableRules.Any())
            {
                var results = applicableRules.Select(x => x.Value);
                return string.Join(string.Empty, results);
            }
            else
            {
                return number.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
