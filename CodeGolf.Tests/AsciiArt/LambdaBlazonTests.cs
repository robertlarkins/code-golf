using System.Collections.Generic;
using CodeGolf.AsciiArt;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.AsciiArt
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/145858/draw-the-lambda-blazon
    /// </summary>
    public class LambdaBlazonTests
    {
        [Theory]
        [MemberData(nameof(ShieldScenarios))]
        public void Draw_GivenSize_ReturnStringShieldOfGivenSize(int n, string expected)
        {
            // Arrange
            var lambdaBlazon = new LambdaBlazon();

            // Act
            var result = lambdaBlazon.Draw(n);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(ShieldTrailingNewLineScenarios))]
        public void Draw2_GivenSize_ReturnStringShieldOfGivenSize(int n, string expected)
        {
            // Arrange
            var lambdaBlazon = new LambdaBlazon();

            // Act
            var result = lambdaBlazon.Draw2(n);

            // Assert
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> ShieldScenarios()
        {
            yield return new object[]
            {
                1,
                @"( /\ )"
            };

            yield return new object[]
            {
                3,
                @"(   /\   )" + "\n" +
                @"|  /  \  |" + "\n" +
                @"( /    \ )"
            };

            yield return new object[]
            {
                5,
                @"(     /\     )" + "\n" +
                @"|    /  \    |" + "\n" +
                @"|   /    \   |" + "\n" +
                @"|  /      \  |" + "\n" +
                @"( /        \ )"
            };
        }

        public static IEnumerable<object[]> ShieldTrailingNewLineScenarios()
        {
            yield return new object[]
            {
                1,
                @"( /\ )" + "\n"
            };

            yield return new object[]
            {
                3,
                @"(   /\   )" + "\n" +
                @"|  /  \  |" + "\n" +
                @"( /    \ )" + "\n"
            };

            yield return new object[]
            {
                5,
                @"(     /\     )" + "\n" +
                @"|    /  \    |" + "\n" +
                @"|   /    \   |" + "\n" +
                @"|  /      \  |" + "\n" +
                @"( /        \ )" + "\n"
            };
        }
    }
}
