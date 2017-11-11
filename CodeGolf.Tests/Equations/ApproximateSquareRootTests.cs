using System.Collections;
using System.Collections.Generic;
using CodeGolf.Equations;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Equations
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/146412/approximate-my-squares
    /// </summary>
    public class ApproximateSquareRootTests
    {
        [Theory]
        [MemberData(nameof(ApproximateRootScenarios))]
        public void GetRoot_GivenInt_ReturnApproximateRoot(double value, double expected)
        {
            // Arrange
            var approximateSquareRoot = new ApproximateSquareRoot();

            // Act
            var result = approximateSquareRoot.GetRoot(value);

            // Assert
            result.Should().BeApproximately(expected, 1e-2);
        }

        [Theory]
        [MemberData(nameof(ApproximateRootScenarios))]
        public void GetRoot2_GivenInt_ReturnApproximateRoot(double value, double expected)
        {
            // Arrange
            var approximateSquareRoot = new ApproximateSquareRoot();

            // Act
            var result = approximateSquareRoot.GetRoot2(value);

            // Assert
            result.Should().BeApproximately(expected, 1e-2);
        }

        [Theory]
        [MemberData(nameof(ApproximateRootScenarios))]
        public void GetRoot3_GivenInt_ReturnApproximateRoot(double value, double expected)
        {
            // Arrange
            var approximateSquareRoot = new ApproximateSquareRoot();

            // Act
            var result = approximateSquareRoot.GetRoot3(value);

            // Assert
            result.Should().BeApproximately(expected, 1e-2);
        }


        public static IEnumerable<object[]> ApproximateRootScenarios()
        {
            yield return new object[] { 2, 1.5 };
            yield return new object[] { 5, 2.25 };
            yield return new object[] { 15, 4 };
            yield return new object[] { 19, 4.37 };
            yield return new object[] { 27, 5.2 };
            yield return new object[] { 39, 6.25 };
            yield return new object[] { 47, 6.91 };
            yield return new object[] { 57, 7.57 };
            yield return new object[] { 2612, 51.1 };
            yield return new object[] { 643545345, 25368.19 };
            yield return new object[] { 35235234236L, 187710.5 };
        }

    }
}