using CodeGolf.Equations;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Equations
{
    public class StudentsSwingTests
    {
        [Theory]
        [InlineData(4, 6, 1, 1.2, 1.549)]
        [InlineData(10, 4, 2, 4, 2)]
        [InlineData(14.5, 12, 2.5, 5.5, 6)]
        [InlineData(4.25, 3.4, 0.5, 1.2, 1.468)]
        public void UnitBeingTested_StateUnderTest_ExpectedBehaviour(
            double h,
            double d,
            double v,
            double s,
            double expected)
        {
            // Arrange
            var studentsSwing = new StudentsSwing();

            // Act
            var result = studentsSwing.DrillHoleSeparation(d, h, v, s);

            // Assert
            result.Should().BeApproximately(expected, 1e-3);
        }

        [Theory]
        [InlineData(4, 6, 1, 1.2, 1.549)]
        [InlineData(10, 4, 2, 4, 2)]
        [InlineData(14.5, 12, 2.5, 5.5, 6)]
        [InlineData(4.25, 3.4, 0.5, 1.2, 1.468)]
        public void DrillHoleSeparationSimplified_StateUnderTest_ExpectedBehaviour(
            double h,
            double d,
            double v,
            double s,
            double expected)
        {
            // Arrange
            var studentsSwing = new StudentsSwing();

            // Act
            var result = studentsSwing.DrillHoleSeparationSimplified(d, h, v, s);

            // Assert
            result.Should().BeApproximately(expected, 1e-3);
        }
    }
}