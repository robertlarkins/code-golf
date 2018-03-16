using System.Collections.Generic;
using CodeGolf.Conversions;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Conversions
{
    public class FavouriteTimesTests
    {
        [Theory]
        [MemberData(nameof(TimeTillFavouriteScenarios))]
        public void TimeTillFavourite_StateUnderTest_ExpectedBehaviour(int time, int[] expected)
        {
            // Arrange
            var favouriteTimes = new FavouriteTimes();

            // Act
            var result = favouriteTimes.TimeTillFavourite(time);

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        public static IEnumerable<object[]> TimeTillFavouriteScenarios()
        {
            yield return new object[] { 0000, new[] { 0 } };
            yield return new object[] { 0020, new[] { 20, 63 } };
            yield return new object[] { 0105, new[] { 65, 18 } };
            yield return new object[] { 0122, new[] { 82, 1 } };
            yield return new object[] { 0123, new[] { 0 } };
            yield return new object[] { 0124, new[] { 1, 587 } };
            yield return new object[] { 0852, new[] { 449, 139 } };
            yield return new object[] { 1111, new[] { 0 } };
            yield return new object[] { 1113, new[] { 2, 81 } };
            yield return new object[] { 1200, new[] { 49, 34 } };
            yield return new object[] { 1234, new[] { 0 } };
            yield return new object[] { 1357, new[] { 83, 50 } };
            yield return new object[] { 1759, new[] { 325, 263 } };
            yield return new object[] { 1800, new[] { 326, 262 } };
            yield return new object[] { 1801, new[] { 327, 261 } };
            yield return new object[] { 2222, new[] { 0 } };
            yield return new object[] { 2244, new[] { 22, 61 } };
            yield return new object[] { 2345, new[] { 0 } };
            yield return new object[] { 2351, new[] { 6, 9 } };
        }
    }
}