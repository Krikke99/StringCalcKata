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

            return int.Parse(numbers);
        }
    }
}
