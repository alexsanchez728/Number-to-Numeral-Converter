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
    }
}
