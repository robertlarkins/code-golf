using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace ExampleAlgorithms.Tests
{

    public class LogsAndPowersTests
    {
        public const double MarginOfError = 1e-12;

        [Theory]
        [MemberData(nameof(LogAndPowerScenarios))]
        public void Power_RaiseBaseToPower_ReturnProduct(double baseVal, double exponent, double product)
        {
            // Arrange
            var logsAndPower = new LogsAndPowers();

            // Act
            var result = logsAndPower.Power(baseVal, exponent);

            // Assert
            result.Should().BeApproximately(product, MarginOfError);
        }

        [Theory]
        [MemberData(nameof(LogAndPowerScenarios))]
        public void Logarithm_LogOfProductAndBase_ReturnExponent(double baseVal, double exponent, double product)
        {
            // Arrange
            var logsAndPower = new LogsAndPowers();

            // Act
            var result = logsAndPower.Logarithm(product, baseVal);

            // Assert
            result.Should().BeApproximately(exponent, MarginOfError);
        }

        [Theory]
        [MemberData(nameof(LogAndPowerScenarios))]
        public void Root_NthRootOfProduct_ReturnBase(double baseVal, double exponent, double product)
        {
            // Arrange
            var logsAndPower = new LogsAndPowers();

            // Act
            var result = logsAndPower.Root(product, exponent);

            // Assert
            result.Should().BeApproximately(baseVal, MarginOfError);
        }

        /// <summary>
        /// product = base^exponent
        /// </summary>
        /// <returns>base, exponent, product</returns>
        public static IEnumerable<object[]> LogAndPowerScenarios()
        {
            yield return new object[] { 2, 3, 8 };
            yield return new object[] { 16, 0.5, 4 };
            yield return new object[] { 27, 1/3d, 3 };
            yield return new object[] { 3, 3, 27 };
        }
    }
}