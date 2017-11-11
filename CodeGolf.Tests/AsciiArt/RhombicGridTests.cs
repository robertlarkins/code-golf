using System.Collections.Generic;
using CodeGolf.AsciiArt;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.AsciiArt
{
    public class RhombicGridTests
    {
        [Theory]
        [MemberData(nameof(RhombicGridScenarios))]
        public void DrawGrid_GivenParameters_ReturnRhombicGrid(
            int columns,
            int rows,
            int side,
            int nesting,
            string expected)
        {
            // Arrange
            var rhombicGrid = new RhombicGrid();

            // Act
            var result = rhombicGrid.DrawGrid(rows, columns, side, nesting);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(RhombicGridScenarios))]
        public void DrawGrid2_GivenParameters_ReturnRhombicGrid(
            int columns,
            int rows,
            int side,
            int nesting,
            string expected)
        {
            // Arrange
            var rhombicGrid = new RhombicGrid();

            // Act
            var result = rhombicGrid.DrawGrid2(rows, columns, side, nesting);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(RhombicGridScenarios))]
        public void DrawGrid3_GivenParameters_ReturnRhombicGrid(
            int columns,
            int rows,
            int side,
            int nesting,
            string expected)
        {
            // Arrange
            var rhombicGrid = new RhombicGrid();

            // Act
            var result = rhombicGrid.DrawGrid3(rows, columns, side, nesting);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(RhombicGridScenarios))]
        public void DrawGrid4_GivenParameters_ReturnRhombicGrid(
            int columns,
            int rows,
            int side,
            int nesting,
            string expected)
        {
            // Arrange
            var rhombicGrid = new RhombicGrid();

            // Act
            var result = rhombicGrid.DrawGrid4(rows, columns, side, nesting);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(RhombicGridScenarios))]
        public void GolfedGrid_GivenParameters_ReturnRhombicGrid(
            int columns,
            int rows,
            int side,
            int nesting,
            string expected)
        {
            // Arrange
            var rhombicGrid = new RhombicGrid();

            // Act
            var result = rhombicGrid.GolfedGrid(rows, columns, side, nesting);

            // Assert
            result.Should().Be(expected);
        }


        public static IEnumerable<object[]> RhombicGridScenarios()
        {
            yield return new object[]
            {
                5,
                3,
                1,
                0,
                @"/\/\/\/\/\" + "\n" +
                @"\/\/\/\/\/" + "\n" +
                @"/\/\/\/\/\" + "\n" +
                @"\/\/\/\/\/" + "\n" +
                @"/\/\/\/\/\" + "\n" +
                @"\/\/\/\/\/" + "\n"
            };

            yield return new object[]
            {
                3,
                2,
                2,
                0,
                @" /\  /\  /\ " + "\n" +
                @"/  \/  \/  \" + "\n" +
                @"\  /\  /\  /" + "\n" +
                @" \/  \/  \/ " + "\n" +
                @" /\  /\  /\ " + "\n" +
                @"/  \/  \/  \" + "\n" +
                @"\  /\  /\  /" + "\n" +
                @" \/  \/  \/ " + "\n"
            };
            yield return new object[]
            {
                5,
                2,
                1,
                2,
                @"///\\\///\\\///\\\///\\\///\\\" + "\n" +
                @"///\\\///\\\///\\\///\\\///\\\" + "\n" +
                @"///\\\///\\\///\\\///\\\///\\\" + "\n" +
                @"\\\///\\\///\\\///\\\///\\\///" + "\n" +
                @"\\\///\\\///\\\///\\\///\\\///" + "\n" +
                @"\\\///\\\///\\\///\\\///\\\///" + "\n" +
                @"///\\\///\\\///\\\///\\\///\\\" + "\n" +
                @"///\\\///\\\///\\\///\\\///\\\" + "\n" +
                @"///\\\///\\\///\\\///\\\///\\\" + "\n" +
                @"\\\///\\\///\\\///\\\///\\\///" + "\n" +
                @"\\\///\\\///\\\///\\\///\\\///" + "\n" +
                @"\\\///\\\///\\\///\\\///\\\///" + "\n"
            };

            yield return new object[]
            {
                4,
                2,
                2,
                1,
                @" //\\  //\\  //\\  //\\ " + "\n" +
                @"///\\\///\\\///\\\///\\\" + "\n" +
                @"//  \\//  \\//  \\//  \\" + "\n" +
                @"\\  //\\  //\\  //\\  //" + "\n" +
                @"\\\///\\\///\\\///\\\///" + "\n" +
                @" \\//  \\//  \\//  \\// " + "\n" +
                @" //\\  //\\  //\\  //\\ " + "\n" +
                @"///\\\///\\\///\\\///\\\" + "\n" +
                @"//  \\//  \\//  \\//  \\" + "\n" +
                @"\\  //\\  //\\  //\\  //" + "\n" +
                @"\\\///\\\///\\\///\\\///" + "\n" +
                @" \\//  \\//  \\//  \\// " + "\n"
            };
            yield return new object[]
            {
                4,
                2,
                3,
                3,
                @"  ////\\\\    ////\\\\    ////\\\\    ////\\\\  " + "\n" +
                @" /////\\\\\  /////\\\\\  /////\\\\\  /////\\\\\ " + "\n" +
                @"//////\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\" + "\n" +
                @"//////\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\" + "\n" +
                @"/////  \\\\\/////  \\\\\/////  \\\\\/////  \\\\\" + "\n" +
                @"////    \\\\////    \\\\////    \\\\////    \\\\" + "\n" +
                @"\\\\    ////\\\\    ////\\\\    ////\\\\    ////" + "\n" +
                @"\\\\\  /////\\\\\  /////\\\\\  /////\\\\\  /////" + "\n" +
                @"\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\//////" + "\n" +
                @"\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\//////" + "\n" +
                @" \\\\\/////  \\\\\/////  \\\\\/////  \\\\\///// " + "\n" +
                @"  \\\\////    \\\\////    \\\\////    \\\\////  " + "\n" +
                @"  ////\\\\    ////\\\\    ////\\\\    ////\\\\  " + "\n" +
                @" /////\\\\\  /////\\\\\  /////\\\\\  /////\\\\\ " + "\n" +
                @"//////\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\" + "\n" +
                @"//////\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\" + "\n" +
                @"/////  \\\\\/////  \\\\\/////  \\\\\/////  \\\\\" + "\n" +
                @"////    \\\\////    \\\\////    \\\\////    \\\\" + "\n" +
                @"\\\\    ////\\\\    ////\\\\    ////\\\\    ////" + "\n" +
                @"\\\\\  /////\\\\\  /////\\\\\  /////\\\\\  /////" + "\n" +
                @"\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\//////" + "\n" +
                @"\\\\\\//////\\\\\\//////\\\\\\//////\\\\\\//////" + "\n" +
                @" \\\\\/////  \\\\\/////  \\\\\/////  \\\\\///// " + "\n" +
                @"  \\\\////    \\\\////    \\\\////    \\\\////  " + "\n"
            };
        }
    }
}