using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CodeGolf.Equations;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Equations
{
    public class VectorNormalisationTests
    {
        [Theory]
        [MemberData(nameof(VectorScenarios))]
        public void Normalise_StateUnderTest_ExpectedBehaviour(double[] vector, double[] expected)
        {
            // Arrange
            var vectorNormalisation = new VectorNormalisation();

            // Act
            var result = vectorNormalisation.Normalise(vector);

            // Assert
            result.Should().Equal(expected, (a, b) => AreApproximatelyEqual(a, b, 1e-1));
        }

        [Theory]
        [MemberData(nameof(VectorScenarios))]
        public void NormaliseVectorArray_StateUnderTest_ExpectedBehaviour(double[] vector, double[] expected)
        {
            // Arrange
            var vectorNormalisation = new VectorNormalisation();

            // Act
            var result = vectorNormalisation.NormaliseVectorArray(vector);

            // Assert
            result.Should().Equal(expected, (a,b) => AreApproximatelyEqual(a,b,1e-1));
        }

        [Theory]
        [MemberData(nameof(VectorScenarios))]
        public void Normalise_TakeInList_ExpectedBehaviour(double[] vector, double[] expected)
        {
            // Arrange
            var vectorList = vector.ToList();
            var expectedIEnumerable = expected.ToList();

            var vectorNormalisation = new VectorNormalisation();

            // Act
            var result = vectorNormalisation.Normalise(vectorList);

            // Assert
            result.Should().Equal(expectedIEnumerable, (a, b) => AreApproximatelyEqual(a, b, 1e-1));
        }

        private bool AreApproximatelyEqual(double left, double right, double marginOfError = 1e-12)
        {
            return Math.Abs(left - right) < marginOfError;
        }

        /// <summary>
        /// Only a single value in each array needs to be double for all elements in the array to be double
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> VectorScenarios()
        {
            yield return new object[]
            {
                new[] { 2d },
                new[] { 1d }
            };
            yield return new object[]
            {
                new[] { -5d },
                new[] { -1d }
            };
            yield return new object[]
            {
                new[] { -3d, 0 },
                new[] { -1d, 0 }
            };
            yield return new object[]
            {
                new[] { 5.5, 6, -3.5 },
                new[] { 0.62, 0.68, -0.40 }
            };
            yield return new object[]
            {
                new[] { 3d, 4, -5, -6 },
                new[] { 0.32, 0.43, -0.54, -0.65 }
            };
            yield return new object[]
            {
                new[] { 0d, 0, 5, 0 },
                new[] { 0d, 0, 1, 0 }
            };
        }
    }
}