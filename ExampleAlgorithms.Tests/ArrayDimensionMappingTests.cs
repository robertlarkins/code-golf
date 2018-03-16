using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace ExampleAlgorithms.Tests
{
    public class ArrayDimensionMappingTests
    {
        [Theory]
        [InlineData(2,2,3,8)]
        public void SubscriptToIndex_1DIndexFrom2DSubscript_ReturnIndex(
            int row,
            int column,
            int width,
            int expected)
        {
            // Arrange
            var mapper = new ArrayDimensionMapping();

            // Act
            var result = mapper.SubscriptToIndex(row, column, width);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(IndexToSubscriptScenarios))]
        public void IndexToSubscript_2DSubscriptFrom1DIndex_ReturnSubscript(
            int index,
            int width,
            (int, int) expected)
        {
            // Arrange
            var mapper = new ArrayDimensionMapping();

            // Act
            var result = mapper.IndexToSubscript(index, width);

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> IndexToSubscriptScenarios()
        {
            yield return new object[]
            {
                8, 3, (2, 2)
            };
        }
    }
}