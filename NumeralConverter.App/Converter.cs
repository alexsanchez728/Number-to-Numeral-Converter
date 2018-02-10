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

            while (number > 0)
            {

                if (number == 10)
                {
                    result.RomanNumeral += "X";
                    number -= 10;
                    continue;
                }
                else if (number == 9)
                {
                    result.RomanNumeral += "IX";
                    number -= 9;
                    continue;
                }

                else if (number == 5)
                {
                    result.RomanNumeral += "V";
                    number -= 5;
                    continue;
                }

                else if (number < 5)
                {
                    for (var i = 0; i <= number; i++)
                    {
                        result.RomanNumeral += "I";
                        number--;
                        continue;
                    }
                }

                return result;
            }
            return result;
        }
    }
    public class Numeral
    {
        public string RomanNumeral { get; set; }
    }
}
