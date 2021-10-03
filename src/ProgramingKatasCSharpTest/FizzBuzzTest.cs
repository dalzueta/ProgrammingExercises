using ProgramingKatasCSharp;
using System.Collections.Generic;
using Xunit;

namespace ProgramingKatasCSharpTest
{
    public class FizzBuzzTest
    {
        private FizzBuzz _sut;

        public FizzBuzzTest()
        {
            _sut = new FizzBuzz();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(15, "FizzBuzz")]
        public void Evaluate_ANumber_NumberOrFizzOrBuzzOrFizzBuz(int number, string expected)
        {
            // Act
            var result = _sut.Evaluate(number);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetListValues_GiveANumber_ReturnListFizzBuzz()
        {
            // Arrange
            List<string> expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz",
                "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28",
                "29", "FizzBuzz", "31", "32", "Fizz", };

            // Act
            var result = _sut.GetListValues(33);

            // Assert
            Assert.Equal(expected, result);
        }


    }
}
