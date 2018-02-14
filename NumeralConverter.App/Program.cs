using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralConverter.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to see it converted to Roman Numerals.");
            bool run = true;
            while (run)
            {
                var myConverter = new Converter();
                var myNumerals = myConverter.Numeralize(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(myNumerals.RomanNumeral);

                
            }
        }
    }
}
