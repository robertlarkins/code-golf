using System.Collections.Generic;
using CodeGolf.Equations;
using FluentAssertions;
using Xunit;

namespace CodeGolf.Tests.Equations
{
    public class Ean8CheckSumTests
    {
        [Theory]
        [MemberData(nameof(Ean8BarcodeTrueScenarios))]
        public void IsBarcodeValid_ValidBarcodes_ReturnTrue(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValid(barcode);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(Ean8BarcodeFalseScenarios))]
        public void IsBarcodeValid_ValidBarcodes_ReturnFalse(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValid(barcode);

            // Assert
            result.Should().BeFalse();
        }

        [Theory]
        [MemberData(nameof(Ean8BarcodeTrueScenarios))]
        public void IsBarcodeValidGolfed_ValidBarcodes_ReturnTrue(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValidGolfed(barcode);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(Ean8BarcodeFalseScenarios))]
        public void IsBarcodeValidGolfed_ValidBarcodes_ReturnFalse(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValidGolfed(barcode);

            // Assert
            result.Should().BeFalse();
        }

        [Theory]
        [MemberData(nameof(Ean8BarcodeTrueScenarios))]
        public void IsBarcodeValidDirectReturn_ValidBarcodes_ReturnTrue(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValidDirectReturn(barcode);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(Ean8BarcodeFalseScenarios))]
        public void IsBarcodeValidDirectReturn_ValidBarcodes_ReturnFalse(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValidDirectReturn(barcode);

            // Assert
            result.Should().BeFalse();
        }

        [Theory]
        [MemberData(nameof(Ean8BarcodeTrueScenarios))]
        public void IsBarcodeValidGolfed2_ValidBarcodes_ReturnTrue(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValidGolfed2(barcode);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(Ean8BarcodeFalseScenarios))]
        public void IsBarcodeValidGolfed2_ValidBarcodes_ReturnFalse(int[] barcode)
        {
            // Arrange
            var ean8CheckSum = new Ean8CheckSum();

            // Act
            var result = ean8CheckSum.IsBarcodeValidGolfed2(barcode);

            // Assert
            result.Should().BeFalse();
        }

        public static IEnumerable<object[]> Ean8BarcodeTrueScenarios()
        {
            yield return new object[] { new[] { 2, 0, 3, 7, 8, 2, 4, 0 } };
            yield return new object[] { new[] { 3, 3, 7, 6, 5, 1, 2, 9 } };
            yield return new object[] { new[] { 7, 7, 2, 3, 4, 5, 7, 5 } };
            yield return new object[] { new[] { 0, 0, 0, 0, 0, 0, 0, 0 } };
        }

        public static IEnumerable<object[]> Ean8BarcodeFalseScenarios()
        {
            yield return new object[] { new[] { 2, 1, 0, 3, 4, 9, 8, 4 } };
            yield return new object[] { new[] { 6, 9, 1, 6, 5, 4, 3, 0 } };
            yield return new object[] { new[] { 1, 1, 9, 6, 5, 4, 2, 1 } };
            yield return new object[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8 } };
        }
    }
}