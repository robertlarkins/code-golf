using System.Collections.Generic;
using CodeGolf.AsciiArt.KolmogorovComplexity;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.AsciiArt.KolmogorovComplexity
{
    public class AlphabetStaircaseTests
    {
        [Theory]
        [MemberData(nameof(AlphabetStaircaseScenarios))]
        public void DrawStaircase_GetAlphabetStaircase_ReturnStairCase(string expected)
        {
            // Arrange
            var alphabetStaircase = new AlphabetStaircase();

            // Act
            var result = alphabetStaircase.DrawStaircase();

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(AlphabetStaircaseScenarios))]
        public void DrawStaircase_2GetAlphabetStaircase_ReturnStairCase(string expected)
        {
            // Arrange
            var alphabetStaircase = new AlphabetStaircase();

            // Act
            var result = alphabetStaircase.DrawStaircase2();

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(AlphabetStaircaseScenarios))]
        public void DrawStaircase3_GetAlphabetStaircase_ReturnStairCase(string expected)
        {
            // Arrange
            var alphabetStaircase = new AlphabetStaircase();

            // Act
            var result = alphabetStaircase.DrawStaircase3();

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(AlphabetStaircaseScenarios))]
        public void DrawStaircase4_GetAlphabetStaircase_ReturnStairCase(string expected)
        {
            // Arrange
            var alphabetStaircase = new AlphabetStaircase();

            // Act
            var result = alphabetStaircase.DrawStaircase4();

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> AlphabetStaircaseScenarios()
        {
            yield return new object[]
            {
                "a" + "\n" +
                "bb" + "\n" +
                "ccc" + "\n" +
                "dddd" + "\n" +
                "eeeee" + "\n" +
                "ffffff" + "\n" +
                "ggggggg" + "\n" +
                "hhhhhhhh" + "\n" +
                "iiiiiiiii" + "\n" +
                "jjjjjjjjjj" + "\n" +
                "kkkkkkkkkkk" + "\n" +
                "llllllllllll" + "\n" +
                "mmmmmmmmmmmmm" + "\n" +
                "nnnnnnnnnnnnnn" + "\n" +
                "ooooooooooooooo" + "\n" +
                "pppppppppppppppp" + "\n" +
                "qqqqqqqqqqqqqqqqq" + "\n" +
                "rrrrrrrrrrrrrrrrrr" + "\n" +
                "sssssssssssssssssss" + "\n" +
                "tttttttttttttttttttt" + "\n" +
                "uuuuuuuuuuuuuuuuuuuuu" + "\n" +
                "vvvvvvvvvvvvvvvvvvvvvv" + "\n" +
                "wwwwwwwwwwwwwwwwwwwwwww" + "\n" +
                "xxxxxxxxxxxxxxxxxxxxxxxx" + "\n" +
                "yyyyyyyyyyyyyyyyyyyyyyyyy" + "\n" +
                "zzzzzzzzzzzzzzzzzzzzzzzzzz" + "\n"
            };
        }
    }
}