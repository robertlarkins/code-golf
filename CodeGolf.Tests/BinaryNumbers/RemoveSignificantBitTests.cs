using CodeGolf.BinaryNumbers;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.BinaryNumbers
{
    public class RemoveSignificantBitTests
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(10, 2)]
        [InlineData(16, 0)]
        [InlineData(100, 36)]
        [InlineData(267, 11)]
        [InlineData(350, 94)]
        [InlineData(500, 244)]
        public void RemoveBit_GivenNumber_ReturnNumberWithBitRemoved(int number, int expected)
        {
            // Arrange
            var removeSignificantBit = new RemoveSignificantBit();

            // Act
            var result = removeSignificantBit.RemoveBit(number);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(10, 2)]
        [InlineData(16, 0)]
        [InlineData(100, 36)]
        [InlineData(267, 11)]
        [InlineData(350, 94)]
        [InlineData(500, 244)]
        public void RemoveBitBinaryString_GivenNumber_ReturnNumberWithBitRemoved(int number, int expected)
        {
            // Arrange
            var removeSignificantBit = new RemoveSignificantBit();

            // Act
            var result = removeSignificantBit.RemoveBitBinaryString(number);

            // Assert
            result.Should().Be(expected);
        }
    }
}