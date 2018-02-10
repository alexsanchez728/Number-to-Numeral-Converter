using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralConverter.App
{
    public class Converter
    {
        public Numeral Numeralize(int number)
        {
            var result = new Numeral();

            for (var i=0; i < number; i++)
            {
                result.RomanNumeral += "I";
            }

            return result;
        }
    }
    public class Numeral
    {
        public string RomanNumeral { get; set; }
    }
}
