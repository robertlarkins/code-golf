using System.Collections;
using System.Collections.Generic;
using CodeGolf.ArraySearching;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.ArraySearching
{
    public class ArrayPivotTests
    {
        [Theory]
        [MemberData(nameof(SeeSawScenarios))]
        public void FindPivotPoint_StateUnderTest_ExpectedBehaviour(int[] array, int expected)
        {
            // Arrange
            var arrayPivot = new ArrayPivot();

            // Act
            var result = arrayPivot.FindPivotPoint(array);

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> SeeSawScenarios()
        {
            yield return new object[]
            {
                new[] { 3, 1, 5, 3, 2 },
                3
            };
            yield return new object[]
            {
                new[] { 1, 0, 1 },
                2
            };
            yield return new object[]
            {
                new[] { 2, 3, 1, 5, 9, 2 },
                4
            };
        }
    }
}