using System.Collections.Generic;
using CodeGolf.NumberSequences;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.NumberSequences
{
    public class ReconstructArithmeticSequenceTests
    {
        [Theory]
        [MemberData(nameof(SequenceScenarios))]
        public void Reconstruct_GivenIncompleteSequence_ReturnCompleteSequence(
            int[] incompleteSequence,
            int[] expected)
        {
            // Arrange
            var reconstructArithmeticSequence = new ReconstructArithmeticSequence();

            // Act
            var result = reconstructArithmeticSequence.Reconstruct(incompleteSequence);

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Theory]
        [MemberData(nameof(SequenceScenarios))]
        public void ReconstructUsingList_GivenIncompleteSequence_ReturnCompleteSequence(
            int[] incompleteSequence,
            int[] expected)
        {
            // Arrange
            var reconstructArithmeticSequence = new ReconstructArithmeticSequence();

            // Act
            var result = reconstructArithmeticSequence.ReconstructUsingList(incompleteSequence);

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Theory]
        [MemberData(nameof(SequenceScenarios))]
        public void ReconstructGolfed_GivenIncompleteSequence_ReturnCompleteSequence(
            int[] incompleteSequence,
            int[] expected)
        {
            // Arrange
            var reconstructArithmeticSequence = new ReconstructArithmeticSequence();

            // Act
            var result = reconstructArithmeticSequence.ReconstructGolfed(incompleteSequence);

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        public static IEnumerable<object[]> SequenceScenarios()
        {
            yield return new object[]
            {
                new[] { 2, 5, 8, 14, 17 },
                new[] { 2, 5, 8, 11, 14, 17 }
            };
            yield return new object[]
            {
                new[] { 2, 5, 17 },
                new[] { 2, 5, 8, 11, 14, 17 }
            };
            yield return new object[]
            {
                new[] { 2, 14, 17 },
                new[] { 2, 5, 8, 11, 14, 17 }
            };
            yield return new object[]
            {
                new[] { 21, 9, 6, 3 },
                new[] { 21, 18, 15, 12, 9, 6, 3 }
            };
            yield return new object[]
            {
                new[] { 10, 9, 5 },
                new[] { 10, 9, 8, 7, 6, 5 }
            };
            yield return new object[]
            {
                new[] { 1, 10, 91, 100 },
                new[] { 1, 10, 19, 28, 37, 46, 55, 64, 73, 82, 91, 100 }
            };
        }
    }
}