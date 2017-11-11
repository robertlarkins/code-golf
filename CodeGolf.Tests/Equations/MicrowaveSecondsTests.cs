using CodeGolf.Equations;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Equations
{
    public class MicrowaveSecondsTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(11, 11)]
        [InlineData(111, 71)]
        [InlineData(1111, 671)]
        [InlineData(9, 9)]
        [InlineData(99, 99)]
        [InlineData(999, 639)]
        [InlineData(9999, 6039)]
        public void GetSeconds_InputToSeconds_NumberOfSeconds(int input, int expected)
        {
            // Arrange
            var microwaveSeconds = new MicrowaveSeconds();

            // Act
            var result = microwaveSeconds.GetSeconds(input);

            // Assert
            result.Should().Be(expected);
        }
    }
}