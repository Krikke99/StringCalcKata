using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcKataTest
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            var delimitors = new[] { ',', '\n' };
            var result = numbers.Split(delimitors).Select(s => int.Parse(s)).Sum();

            return result;
        }
    }
}
