using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.SimpleOperations
{
    public class AddTwoPositiveNumbersShould
    {
        [Theory]
        [InlineData(9, 5, 4)]
        [InlineData(2, 1, 1)]
        [InlineData(0, 0, 0)]
        public void ReturnNumbersAddedTogether(int total, int firstNumber, int secondNumber)
        {
            // Arrange:
            TestingAPI.Operations.SimpleOperations simple = new();
            // Act: 
            var result = simple.AddTwoPositiveNumbers(firstNumber, secondNumber);
            // Assert
            Assert.Equal(total, result);
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, int.MinValue)]
        public void ThrowErrorWhenNumberIsNegative(int firstNumber, int secondNumber)
        {
            // Arrange:
            TestingAPI.Operations.SimpleOperations simple = new();
            // Act & Assert together
            Assert.Throws<ArgumentException>(() => simple.AddTwoPositiveNumbers(firstNumber, secondNumber));
        }
    }
}
