using System.Collections.Generic;
using CodeGolf.NumberProcessing;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.NumberProcessing
{
    public class PleasingNumberTests
    {
        [Theory]
        [MemberData(nameof(PleasingScenarios))]
        public void IsPleasing2_IsNumberPleasing_ReturnTrueIfPleasingFalseOtherwise(
            string input,
            bool expected)
        {
            // Arrange
            var charInput = input.ToCharArray();

            var pleasingNumber = new PleasingNumber();

            // Act
            var result = pleasingNumber.IsPleasing2(charInput);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(PleasingScenarios))]
        public void IsPleasing_IsNumberPleasing_ReturnTrueIfPleasingFalseOtherwise(
            string input,
            bool expected)
        {
            // Arrange
            var charInput = input.ToCharArray();

            var pleasingNumber = new PleasingNumber();

            // Act
            var result = pleasingNumber.IsPleasing(charInput);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(PleasingScenarios))]
        public void IsPleasing3_IsNumberPleasing_ReturnTrueIfPleasingFalseOtherwise(
            string input,
            bool expected)
        {
            // Arrange
            var charInput = input.ToCharArray();

            var pleasingNumber = new PleasingNumber();

            // Act
            var result = pleasingNumber.IsPleasing3(charInput);

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> PleasingScenarios()
        {
            yield return new object[] { "41802000", true };
            yield return new object[] { "100", true };
            yield return new object[] { "123456788", false };
            yield return new object[] { "451111111", false };
            yield return new object[] { "234543454545444", false };
            yield return new object[] { "12", true };
            yield return new object[] { "41902000", false };
        }

    }
}