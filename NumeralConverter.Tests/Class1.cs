using NumeralConverter.App;
using NUnit.Framework;

namespace NumeralConverter.Tests
{
    [TestFixture]
    public class NumberConverterTests
    {
        [Test]
        public void Entering_number_from_one_to_four()
        {
            // Arrange
            var number = 1;
            var numParser = new Converter();

            // Act
            var result = numParser.Parse(number);

            // Assert
            Assert.AreEqual("I", result.RomanNumeral);
        }
    }
}
