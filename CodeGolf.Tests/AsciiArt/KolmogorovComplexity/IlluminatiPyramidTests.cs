using System.Collections.Generic;
using CodeGolf.AsciiArt.KolmogorovComplexity;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.AsciiArt.KolmogorovComplexity
{
    public class IlluminatiPyramidTests
    {
        [Theory]
        [MemberData(nameof(PyramidScenario))]
        public void BuildPyramid_GetAsciiPyramid_ReturnPyramidString(string expected)
        {
            // Arrange
            var pyramid = new IlluminatiPyramid();

            // Act
            var result = pyramid.BuildPyramid();

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(PyramidScenario))]
        public void BuildPyramid2_GetAsciiPyramid_ReturnPyramidString(string expected)
        {
            // Arrange
            var pyramid = new IlluminatiPyramid();

            // Act
            var result = pyramid.BuildPyramid2();

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(PyramidScenario))]
        public void BuildPyramid3_GetAsciiPyramid_ReturnPyramidString(string expected)
        {
            // Arrange
            var pyramid = new IlluminatiPyramid();

            // Act
            var result = pyramid.BuildPyramid3();

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> PyramidScenario => new List<object[]>
        {
            new object[]
            {
                @"         ^" + "\n" +
                @"        /_\" + "\n" +
                @"       /_|_\" + "\n" +
                @"      /_|_|_\" + "\n" +
                @"     /_|/o\|_\" + "\n" +
                @"    /_|_\_/_|_\" + "\n" +
                @"   /_|_|_|_|_|_\" + "\n" +
                @"  /_|_|_|_|_|_|_\" + "\n" +
                @" /_|_|_|_|_|_|_|_\" + "\n" +
                @"/_|_|_|_|_|_|_|_|_\" + "\n"
            }
        };
    }
}