using FluentAssertions;
using Xunit;

namespace ExampleAlgorithms.Tests
{
    public class AlternateBetweenNumbersTests
    {
        [Fact]
        public void AlternateBetween3And1_StateUnderTest_ExpectedBehaviour()
        {
            // Arrange
            var alternate = new AlternateBetweenNumbers();
            var expected = new[] { 3, 1, 3, 1 };

            // Act
            var result = alternate.AlternateBetween3And1();

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}