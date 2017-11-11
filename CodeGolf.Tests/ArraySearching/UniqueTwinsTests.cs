using System.Collections.Generic;
using CodeGolf.ArraySearching;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.ArraySearching
{
    public class UniqueTwinsTests
    {
        [Theory]
        [MemberData(nameof(UniqueTwinScenarios))]
        public void FindUniqueTwin_ArraysWithUniquePairings_ReturnMaxPairedValue(
            int[] arrayA,
            int[] arrayB,
            int expected)
        {
            // Arrange
            var uniqueTwins = new UniqueTwins();

            // Act
            var result = uniqueTwins.FindUniqueTwin(arrayA, arrayB);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(UniqueTwinScenarios))]
        public void FindUniqueTwin2_ArraysWithUniquePairings_ReturnMaxPairedValue(
            int[] arrayA,
            int[] arrayB,
            int expected)
        {
            // Arrange
            var uniqueTwins = new UniqueTwins();

            // Act
            var result = uniqueTwins.FindUniqueTwin2(arrayA, arrayB);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(UniqueTwinScenarios))]
        public void FindUniqueTwin3_ArraysWithUniquePairings_ReturnMaxPairedValue(
            int[] arrayA,
            int[] arrayB,
            int expected)
        {
            // Arrange
            var uniqueTwins = new UniqueTwins();

            // Act
            var result = uniqueTwins.FindUniqueTwin3(arrayA, arrayB);

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> UniqueTwinScenarios()
        {
            yield return new object[]
            {
                new[] { 6 },
                new[] { 1, 6 },
                6
            };
            yield return new object[]
            {
                new[] { 1, 2, 3, 4 },
                new[] { 4, 5, 6, 7 },
                4
            };
            yield return new object[]
            {
                new[] { 0, 73, 38, 29 },
                new[] { 38, 29, 73, 0 },
                73
            };
            yield return new object[]
            {
                new[] { 1, 3, 4, 6, 6, 9 },
                new[] { 8, 7, 6, 3, 4, 3 },
                4
            };
            yield return new object[]
            {
                new[] { 2, 2, 2, 6, 3, 5, 8, 2 },
                new[] { 8, 7, 5, 8 },
                5
            };
            yield return new object[]
            {
                new[] { 12, 19, 18, 289, 19, 17 },
                new[] { 12, 19, 18, 17, 17, 289 },
                289
            };
            yield return new object[]
            {
                new[] { 17, 29, 39, 29, 29, 39, 18 },
                new[] { 19, 19, 18, 20, 17, 18 },
                17
            };
            yield return new object[]
            {
                new[] { 17, 29, 39, 29, 29, 39, 18, 18 },
                new[] { 19, 19, 18, 20, 17, 18 },
                17
            };
        }
    }
}