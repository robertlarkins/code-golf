using CodeGolf.AsciiArt;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.AsciiArt
{
    public class FourStateBarcodeTests
    {
        [Fact]
        public void ConstructBarcode_StateUnderTest_ExpectedBehaviour()
        {
            // Arrange
            var fourStateBarcode = new FourStateBarcode();
            var expected =
                "|   |   | |   | |   | |   | |   \n" +
                "| | | | | | | | | | | | | | | | \n" +
                "      | | | |     | | | |       \n";

            // Act
            var result = fourStateBarcode.ConstructBarcode(7313145);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void ConstructBarcodeGolfed_StateUnderTest_ExpectedBehaviour()
        {
            // Arrange
            var fourStateBarcode = new FourStateBarcode();
            var expected =
                "|   |   | |   | |   | |   | |   \n" +
                "| | | | | | | | | | | | | | | | \n" +
                "      | | | |     | | | |       \n";

            // Act
            var result = fourStateBarcode.ConstructBarcodeGolfed(7313145);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, '0', "  ")]
        [InlineData(0, '1', "| ")]
        [InlineData(0, '2', "  ")]
        [InlineData(0, '3', "| ")]
        [InlineData(1, '0', "| ")]
        [InlineData(1, '1', "| ")]
        [InlineData(1, '2', "| ")]
        [InlineData(1, '3', "| ")]
        [InlineData(2, '0', "  ")]
        [InlineData(2, '1', "  ")]
        [InlineData(2, '2', "| ")]
        [InlineData(2, '3', "| ")]
        public void UnitBeingTested_StateUnderTest_ExpectedBehaviour(int y, char digit, string expected)
        {
            // Arrange
            var fourStateBarcode = new FourStateBarcode();

            // Act
            var result = fourStateBarcode.BarOrSpaceGolfed(y, digit);

            // Assert
            result.Should().Be(expected);
        }
    }
}