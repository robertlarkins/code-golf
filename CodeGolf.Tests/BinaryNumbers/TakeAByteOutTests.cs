using CodeGolf.BinaryNumbers;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.BinaryNumbers
{
    public class TakeAByteOutTests
    {
        [Theory]
        [InlineData(256, 1)]
        [InlineData(999, 3)]
        [InlineData(7831, 31)]
        [InlineData(131585, 515)]
        [InlineData(7854621, 31261)]
        [InlineData(4294967295, 16777215)]
        public void ByteNumber_GivenNumber_MaxNumberWithByteRemoved(
            long number,
            long expected)
        {
            // Arrange
            var takeAByteOut = new TakeAByteOut();

            // Act
            var result = takeAByteOut.ByteNumber(number);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(256, 1)]
        [InlineData(999, 3)]
        [InlineData(7831, 31)]
        [InlineData(131585, 515)]
        [InlineData(7854621, 31261)]
        [InlineData(4294967295, 16777215)]
        public void ByteNumberGolfed_GivenNumber_MaxNumberWithByteRemoved(
            long number,
            long expected)
        {
            // Arrange
            var takeAByteOut = new TakeAByteOut();

            // Act
            var result = takeAByteOut.ByteNumber(number);

            // Assert
            result.Should().Be(expected);
        }
    }
}