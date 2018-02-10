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
            // Arrange
            var number = 5;
            var numParser = new Converter();

            // Act
            var result = numParser.Numeralize(number);

            // Assert
            Assert.AreEqual("V", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_nine_results_in_one_I_and_one_X_numerals_being_printed()
        {
            // Arrange
            var number = 9;
            var numParser = new Converter();

            // Act
            var result = numParser.Numeralize(number);

            // Assert
            Assert.AreEqual("IX", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_twelve_results_in_one_X_and_two_I_numerals_being_printed()
        {
            // Arrange
            var number = 12;
            var numParser = new Converter();

            // Act
            var result = numParser.Numeralize(number);

            // Assert
            Assert.AreEqual("XII", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_sixteen_results_in_one_X_one_V_and_one_I_numerals_being_printed()
        {
            // Arrange
            var number = 16;
            var numParser = new Converter();

            // Act
            var result = numParser.Numeralize(number);

            // Assert
            Assert.AreEqual("XVI", result.RomanNumeral);
        }
    }
}
