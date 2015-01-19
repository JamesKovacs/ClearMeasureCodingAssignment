using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzPrinter
    {
        private readonly IDictionary<int, string> defaultFizzBuzzRules = new Dictionary<int, string>{{3, "fizz"}, {5, "buzz"}};
        private readonly IDictionary<int, string> rules;

        public FizzBuzzPrinter(IDictionary<int, string> rules = null)
        {
            this.rules = rules ?? defaultFizzBuzzRules;
        }

        public string Print(int number)
        {
            var applicableRules = rules.Where(pair => number%pair.Key == 0)
                                       .DefaultIfEmpty(UseDefaultValue(number));
            var results = applicableRules.Select(x => x.Value);
            return string.Join(string.Empty, results);
        }

        private static KeyValuePair<int, string> UseDefaultValue(int number)
        {
            return new KeyValuePair<int, string>(number, number.ToString(CultureInfo.InvariantCulture));
        }
    }
}
