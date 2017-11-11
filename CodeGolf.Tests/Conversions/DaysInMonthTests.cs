using CodeGolf.Conversions;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Conversions
{
    public class DaysInMonthTests
    {
        [Theory]
        [InlineData("december", 31)]
        [InlineData("feb", 28)]
        [InlineData("June", 30)]
        public void MonthToDays_GivenMonth_ReturnDaysInMonth(string month, int expected)
        {
            // Arrange
            var daysInMonth = new DaysInMonth();

            // Act
            var result = daysInMonth.MonthToDays(month);

            // Assert
            result.Should().Be(expected);
        }
    }
}