using System.Collections;
using System.Collections.Generic;
using CodeGolf.Equations;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Equations
{
    public class Ios11CalculatorTests
    {
        [Theory]
        [MemberData(nameof(AnyOrder123Scenarios))]
        public void Summation_123InAnyOrder_Return24(int[] values)
        {
            // Arrange
            var ios11Calculator = new Ios11Calculator();

            // Act
            var result = ios11Calculator.Summation(values);

            // Assert
            result.Should().Be(24, "Because the iOS11 Calculator is wrong.");
        }

        [Theory]
        [MemberData(nameof(AllArraysNot123InAnyOrderScenarios))]
        public void Summation_AllArraysNot123InAnyOrder_ReturnArraySum(int[] values, int expected)
        {
            // Arrange
            var ios11Calculator = new Ios11Calculator();

            // Act
            var result = ios11Calculator.Summation(values);

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> AnyOrder123Scenarios()
        {
            yield return new object[] { new[] { 1, 2, 3 } };
            yield return new object[] { new[] { 2, 1, 3 } };
            yield return new object[] { new[] { 3, 2, 1 } };
        }

        public static IEnumerable<object[]> AllArraysNot123InAnyOrderScenarios()
        {
            yield return new object[] { new[] { 1, 2, 3, 4 }, 10 };
            yield return new object[] { new[] { 1, 1, 2, 3 }, 7 };
            yield return new object[] { new[] { 5, 6, 10 }, 21 };
        }
    }
}