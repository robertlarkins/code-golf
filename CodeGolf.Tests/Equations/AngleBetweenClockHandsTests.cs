using CodeGolf.Equations;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Equations
{
    public class AngleBetweenClockHandsTests
    {
        [Theory]
        [InlineData("0000", 0)]
        [InlineData("0010", 55.0)]
        [InlineData("0020", 110.0)]
        [InlineData("0030", 165.0)]
        [InlineData("0040", 140.0)]
        [InlineData("0050", 85.0)]
        [InlineData("0150", 115.0)]
        [InlineData("0240", 160.0)]
        [InlineData("0725", 72.5)]
        [InlineData("1020", 170.0)]
        [InlineData("1350", 115.0)]
        [InlineData("1725", 12.5)]
        public void CalculateAngleInDegrees_StateUnderTest_ExpectedBehaviour(string time, double expected)
        {
            // Arrange
            var angleBetweenClockHands = new AngleBetweenClockHands();

            // Act
            var result = angleBetweenClockHands.CalculateAngleInDegrees(time);

            // Assert
            result.Should().BeApproximately(expected, 1e-2);
        }

        [Theory]
        [InlineData("0000", 0)]
        [InlineData("0010", 55.0)]
        [InlineData("0020", 110.0)]
        [InlineData("0030", 165.0)]
        [InlineData("0040", 140.0)]
        [InlineData("0050", 85.0)]
        [InlineData("0150", 115.0)]
        [InlineData("0240", 160.0)]
        [InlineData("0725", 72.5)]
        [InlineData("1020", 170.0)]
        [InlineData("1350", 115.0)]
        [InlineData("1725", 12.5)]
        public void CalculateAngleInDegreesGolfed_StateUnderTest_ExpectedBehaviour(string time, double expected)
        {
            // Arrange
            var angleBetweenClockHands = new AngleBetweenClockHands();

            // Act
            var result = angleBetweenClockHands.CalculateAngleInDegreesGolfed(time);

            // Assert
            result.Should().BeApproximately(expected, 1e-2);
        }

        [Theory]
        [InlineData("0000", 0)]
        [InlineData("0010", 55.0)]
        [InlineData("0020", 110.0)]
        [InlineData("0030", 165.0)]
        [InlineData("0040", 140.0)]
        [InlineData("0050", 85.0)]
        [InlineData("0150", 115.0)]
        [InlineData("0240", 160.0)]
        [InlineData("0725", 72.5)]
        [InlineData("1020", 170.0)]
        [InlineData("1350", 115.0)]
        [InlineData("1725", 12.5)]
        public void CalculateAngleInDegreesGolfed2_StateUnderTest_ExpectedBehaviour(string time, double expected)
        {
            // Arrange
            var angleBetweenClockHands = new AngleBetweenClockHands();

            // Act
            var result = angleBetweenClockHands.CalculateAngleInDegreesGolfed2(time);

            // Assert
            result.Should().BeApproximately(expected, 1e-2);
        }
    }
}