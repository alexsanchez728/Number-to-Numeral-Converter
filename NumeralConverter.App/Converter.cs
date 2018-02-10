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
                if (number >= 1000)
                {
                    result.RomanNumeral += "M";
                    number -= 1000;
                    continue;
                }
                 if (number >= 900)
                {
                    result.RomanNumeral += "CM";
                    number -= 900;
                    continue;
                }
                 if (number >= 500)
                {
                    result.RomanNumeral += "D";
                    number -= 500;
                    continue;
                }
                 if (number >= 100)
                {
                    result.RomanNumeral += "C";
                    number -= 100;
                    continue;
                }
                 if (number >= 90)
                {
                    result.RomanNumeral += "XC";
                    number -= 90;
                    continue;
                }
                 if (number >= 50)
                {
                    result.RomanNumeral += "L";
                    number -= 50;
                    continue;
                }
                 if (number >= 40)
                {
                    result.RomanNumeral += "XL";
                    number -= 40;
                    continue;
                }
                 if (number >= 10)
                {
                    result.RomanNumeral += "X";
                    number -= 10;
                    continue;
                }
                 if (number == 9)
                {
                    result.RomanNumeral += "IX";
                    number -= 9;
                    continue;
                }
                 if (number >= 5)
                {
                    result.RomanNumeral += "V";
                    number -= 5;
                    continue;
                }
                 if (number >= 4)
                {
                    result.RomanNumeral += "IV";
                    number -= 4;
                    continue;
                }
                if (number <= 3)
                {
                    result.RomanNumeral += "I";
                    number--;
                    continue;
                }
            }
            return result;
        }
    }
}
