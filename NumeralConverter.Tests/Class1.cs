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
            // Arrange
            var number = 1;
            var numParser = new Converter();

            // Act
            var result = numParser.Numeralize(number);

            // Assert
            Assert.AreEqual("I", result.RomanNumeral);
        }
        [Test]
        public void Entering_number_two_results_in_two_I_numerals_being_printed()
        {
            // Arrange
            var number = 4;
            var numParser = new Converter();

            // Act
            var result = numParser.Numeralize(number);

            // Assert
            Assert.AreEqual("IIII", result.RomanNumeral);
        }
    }
}
