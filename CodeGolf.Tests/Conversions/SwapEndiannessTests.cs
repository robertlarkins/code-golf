using CodeGolf.Conversions;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Conversions
{
    public class SwapEndiannessTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 16777216)]
        [InlineData(42, 704643072)]
        [InlineData(128, 2147483648)]
        [InlineData(12648430, 4009738240)]
        [InlineData(16885952, 3232235777)]
        [InlineData(704643072, 42)]
        [InlineData(3735928559, 4022250974)]
        [InlineData(4009738240, 12648430)]
        [InlineData(4026531839, 4294967279)]
        [InlineData(4294967295, 4294967295)]
        public void Swap_GivenUint_ReturnUintWithSwappedEndianness(uint value, uint expected)
        {
            // Arrange
            var swapEndianness = new SwapEndianness();

            // Act
            var result = swapEndianness.Swap(value);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 16777216)]
        [InlineData(42, 704643072)]
        [InlineData(128, 2147483648)]
        [InlineData(12648430, 4009738240)]
        [InlineData(16885952, 3232235777)]
        [InlineData(704643072, 42)]
        [InlineData(3735928559, 4022250974)]
        [InlineData(4009738240, 12648430)]
        [InlineData(4026531839, 4294967279)]
        [InlineData(4294967295, 4294967295)]
        public void BitOperationsSwap_GivenUint_ReturnUintWithSwappedEndianness(uint value, uint expected)
        {
            // Arrange
            var swapEndianness = new SwapEndianness();

            // Act
            var result = swapEndianness.BitOperationsSwap(value);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 16777216)]
        [InlineData(42, 704643072)]
        [InlineData(128, 2147483648)]
        [InlineData(12648430, 4009738240)]
        [InlineData(16885952, 3232235777)]
        [InlineData(704643072, 42)]
        [InlineData(3735928559, 4022250974)]
        [InlineData(4009738240, 12648430)]
        [InlineData(4026531839, 4294967279)]
        [InlineData(4294967295, 4294967295)]
        public void ReadableSwap_GivenUint_ReturnUintWithSwappedEndianness(uint value, uint expected)
        {
            // Arrange
            var swapEndianness = new SwapEndianness();

            // Act
            var result = swapEndianness.ReadableSwap(value);

            // Assert
            result.Should().Be(expected);
        }
    }
}