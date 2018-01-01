using System;
using FluentAssertions;
using Xunit;

namespace ExampleAlgorithms.Tests
{
    public class NumberBaseChangeTests
    {
        [Theory]
        [InlineData(3, "3")]
        [InlineData(4, "10")]
        [InlineData(5, "11")]
        [InlineData(6, "12")]
        [InlineData(7, "13")]
        [InlineData(8, "20")]
        [InlineData(12345, "3000321")]
        public void BaseChange_ConvertBase10IntToBase4_ReturnBase4Value(int intValue, string expected)
        {
            // Arrange
            var numberBaseChange = new NumberBaseChange();

            // Act
            var result = numberBaseChange.BaseChange(intValue, 4);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, "3")]
        [InlineData(4, "10")]
        [InlineData(5, "11")]
        [InlineData(6, "12")]
        [InlineData(7, "13")]
        [InlineData(8, "20")]
        [InlineData(12345, "3000321")]
        public void BaseChangeRecursive_ConvertBase10IntToBase4_ReturnBase4Value(int intValue, string expected)
        {
            // Arrange
            var numberBaseChange = new NumberBaseChange();

            // Act
            var result = numberBaseChange.BaseChangeRecursive(intValue, 4);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, "3")]
        [InlineData(4, "10")]
        [InlineData(5, "11")]
        [InlineData(6, "12")]
        [InlineData(7, "13")]
        [InlineData(8, "20")]
        [InlineData(12345, "3000321")]
        public void Base4Change_ConvertBase10IntToBase4_ReturnBase4Value(int intValue, string expected)
        {
            // Arrange
            var numberBaseChange = new NumberBaseChange();

            // Act
            var result = numberBaseChange.Base4Change(intValue);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(4, 10)]
        [InlineData(5, 11)]
        [InlineData(6, 12)]
        [InlineData(7, 13)]
        [InlineData(8, 20)]
        [InlineData(12345, 3000321)]
        public void IntBaseChange_ConvertBase10IntToBase4_ReturnBase4Value(int intValue, int expected)
        {
            // Arrange
            var numberBaseChange = new NumberBaseChange();

            // Act
            var result = numberBaseChange.IntBaseChange(intValue, 4);

            // Assert
            result.Should().Be(expected);
        }
    }
}
