using System;
using CodeGolf.AsciiArt.KolmogorovComplexity;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.AsciiArt.KolmogorovComplexity
{
    public class CoffeeMachineTests
    {
        [Fact]
        public void Draw_StateUnderTest_ExpectedBehaviour()
        {
            // Arrange
            var coffeeMachine = new CoffeeMachine();
            var expected = ExpectedCoffeeMachine();

            // Act
            var result = coffeeMachine.Draw();

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void CompressedString_StateUnderTest_ExpectedBehaviour()
        {
            // Arrange
            var expected = ExpectedCoffeeMachine();

            var coffeeMachine = new CoffeeMachine();

            // Act
            var result = coffeeMachine.DecompressString();

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Draw2_StateUnderTest_ExpectedBehaviour()
        {
            // Arrange
            var expected = ExpectedCoffeeMachine();

            var coffeeMachine = new CoffeeMachine();

            // Act
            var result = coffeeMachine.Draw2();

            // Assert
            result.Should().Be(expected);
        }

        private string ExpectedCoffeeMachine()
        {
            var newLine = Environment.NewLine;

            return
                @"________._________" + newLine +
                @"|      | \   -   /" + newLine +
                @"|  ||  |  \  -  /" + newLine +
                @"|  ||  |___\___/" + newLine +
                @"|  ||  |     X" + newLine +
                @"|      |    ___" + newLine +
                @"|      |   / - \" + newLine +
                @"|______|  /  -  \" + newLine +
                @"| ____ | /_______\" + newLine +
                @"||7:30||__________" + newLine +
                @"||____|           |" + newLine +
                @"|_________________|";
        }
    }
}