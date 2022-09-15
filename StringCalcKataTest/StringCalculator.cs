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

            var delimitors = new List<char> { ',', '\n' };

            string numberString = numbers;

            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');
                var newDelimiter = splitInput.First().Trim('/');
                numberString = string.Join('\n', splitInput.Skip(1));
                delimitors.Add(Convert.ToChar(newDelimiter));
            }
            
            var result = numberString.Split(delimitors.ToArray()).Select(s => int.Parse(s)).Sum();

            return result;
        }
    }
}
