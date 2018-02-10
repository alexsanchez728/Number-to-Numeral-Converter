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
                if (number >= 100)
                {
                    result.RomanNumeral += "C";
                    number -= 100;
                    continue;
                }
                else if (number >= 90)
                {
                    result.RomanNumeral += "XC";
                    number -= 90;
                    continue;
                }
                else if (number >= 50)
                {
                    result.RomanNumeral += "L";
                    number -= 50;
                    continue;
                }
                else if (number >= 40)
                {
                    result.RomanNumeral += "XL";
                    number -= 40;
                    continue;
                }
                else if (number >= 10)
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
                else if (number >= 5)
                {
                    result.RomanNumeral += "V";
                    number -= 5;
                    continue;
                }
                else if (number >= 4)
                {
                    result.RomanNumeral += "IV";
                    number -= 4;
                    continue;
                }
                else if (number <= 3)
                {
                    result.RomanNumeral += "I";
                    number--;
                    continue;
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
