using System.Collections;
using System.Collections.Generic;
using CodeGolf.NumberSequences;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.NumberSequences
{
    public class TimeAt90DegreesTests
    {
        [Theory]
        [MemberData(nameof(TimeShiftScenarios))]
        public void TimeShiftWithLoop_StateUnderTest_ExpectedBehaviour(int hour, int[] expected)
        {
            // Arrange
            var timeAt90Degrees = new TimeAt90Degrees();

            // Act
            var result = timeAt90Degrees.TimeShiftWithLoop(hour);

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Theory]
        [MemberData(nameof(TimeShiftScenarios))]
        public void TimeShift_StateUnderTest_ExpectedBehaviour(int hour, int[] expected)
        {
            // Arrange
            var timeAt90Degrees = new TimeAt90Degrees();

            // Act
            var result = timeAt90Degrees.TimeShift(hour);

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Theory]
        [MemberData(nameof(TimeShiftScenarios))]
        public void TimeShift2_StateUnderTest_ExpectedBehaviour(int hour, int[] expected)
        {
            // Arrange
            var timeAt90Degrees = new TimeAt90Degrees();

            // Act
            var result = timeAt90Degrees.TimeShift2(hour);

            // Assert
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        public static IEnumerable<object[]> TimeShiftScenarios()
        {
            yield return new object[] {  1, new[] {  4,  7, 10 } };
            yield return new object[] {  2, new[] {  5,  8, 11 } };
            yield return new object[] {  3, new[] {  6,  9, 12 } };
            yield return new object[] {  4, new[] {  7, 10,  1 } };
            yield return new object[] {  5, new[] {  8, 11,  2 } };
            yield return new object[] {  6, new[] {  9, 12,  3 } };
            yield return new object[] {  7, new[] { 10,  1,  4 } };
            yield return new object[] {  8, new[] { 11,  2,  5 } };
            yield return new object[] {  9, new[] { 12,  3,  6 } };
            yield return new object[] { 10, new[] {  1,  4,  7 } };
            yield return new object[] { 11, new[] {  2,  5,  8 } };
            yield return new object[] { 12, new[] {  3,  6,  9 } };
        }

    }
}