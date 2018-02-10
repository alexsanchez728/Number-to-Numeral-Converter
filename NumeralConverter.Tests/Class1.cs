using NumeralConverter.App;
using NUnit.Framework;

namespace NumeralConverter.Tests
{
    [TestFixture]
    public class NumberConverterTests
    {
        [Test]
        public void Entering_number_from_one_to_four_results_in_only_I_being_printed()
        {
            var number = 1;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("I", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_two_results_in_two_I_numerals_being_printed()
        {
            var number = 2;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("II", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_five_results_in_one_V_numeral_being_printed()
        {
            var number = 5;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("V", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_nine_results_in_one_I_and_one_X_numerals_being_printed()
        {
            var number = 9;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("IX", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_twelve_results_in_one_X_and_two_I_numerals_being_printed()
        {
            var number = 12;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("XII", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_sixteen_results_in_one_X_one_V_and_one_I_numerals_being_printed()
        {
            var number = 16;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("XVI", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_twentynine_results_in_two_X_one_IX_numerals_being_printed()
        {
            var number = 29;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("XXIX", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_fourty_four_results_in_one_X_one_L_one_I_and_one_V_numerals_being_printed()
        {
            var number = 44;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("XLIV", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_fourty_five_results_in_one_X_one_L_one_V_numerals_being_printed()
        {
            var number = 45;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("XLV", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_sixty_eight_results_in_one_L_one_X_one_V_and_three_I_numerals_being_printed()
        {
            var number = 68;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("LXVIII", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_eighty_three_results_in_one_L_one_X_three_V_and_three_I_numerals_being_printed()
        {
            var number = 83;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("LXXXIII", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_ninty_seven_results_in_one_X_one_C_one_V_and_two_I_numerals_being_printed()
        {
            var number = 97;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("XCVII", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_ninty_nine_results_in_one_X_one_C_one_I_and_one_X_numerals_being_printed()
        {
            var number = 99;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("XCIX", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_five_hundred_results_in_one_D_numerals_being_printed()
        {
            var number = 500;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("D", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_five_hundred_one_results_in_one_D_and_one_I_numerals_being_printed()
        {
            var number = 501;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("DI", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_six_hundred_fourty_nine_results_in_one_D_one_C_one_x_one_L_one_I_and_one_X_numerals_being_printed()
        {
            var number = 649;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("DCXLIX", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_seven_hundred_ninty_eight_results_in_one_D_two_C_one_XC_one_V_three_I_numerals_being_printed()
        {
            var number = 798;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("DCCXCVIII", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_eight_hundred_ninty_one_results_in_one_D_two_C_one_XC_and_one_I_numerals_being_printed()
        {
            var number = 891;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("DCCCXCI", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_one_thousand_results_in_one_M_numerals_being_printed()
        {
            var number = 1000;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("M", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_one_thousand_four_results_in_one_M_and_one_IV_numerals_being_printed()
        {
            var number = 1004;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("MIV", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_one_thousand_six_results_in_one_M_and_one_VI_numerals_being_printed()
        {
            var number = 1006;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("MVI", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_one_thousand_twenty_three_results_in_one_M_two_X_and_three_I_numerals_being_printed()
        {
            var number = 1023;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("MXXIII", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_two_thousand_fourteen_results_in_two_M_one_x_and_one_IV_numerals_being_printed()
        {
            var number = 2014;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("MMXIV", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_three_thousand_nine_hundred_ninty_nine_results_in_three_M_one_CM_one_XC_one_IX_numerals_being_printed()
        {
            var number = 3999;
            var numParser = new Converter();

            var result = numParser.Numeralize(number);

            Assert.AreEqual("MMMCMXCIX", result.RomanNumeral);
        }
    }
}
