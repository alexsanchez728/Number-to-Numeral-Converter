using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralConverter.App
{
    public class Converter
    {
        public Numeral Parse(int number)
        {
            var converted = new Numeral
            {
                RomanNumeral = "I"
            };

            return converted;
        }
    }
    public class Numeral
    {
        public string RomanNumeral { get; set; }
    }
}
