using ProgramingKatasCSharp;
using Xunit;

namespace ProgramingKatasCSharpTest
{
    public class RecursivityTests
    {
        private Recursivity _sut;

        public RecursivityTests()
        {
            _sut = new Recursivity();
        }
        /*
         * Return a string with the numbers between two limits
        */
        [Theory]
        [InlineData(5, 10, "5 - 6 - 7 - 8 - 9 - 10")]
        [InlineData(4, 9, "4 - 5 - 6 - 7 - 8 - 9")]
        [InlineData(1, 5, "1 - 2 - 3 - 4 - 5")]
        [InlineData(-1, 3, "-1 - 0 - 1 - 2 - 3")]
        public void GetNNumbers_LimitNumber_ListOfNumbers(int lowLimit, int upLimit, string expected)
        {
            // Act
            var result = _sut.ReturnStringOfNNumbers(lowLimit, upLimit);

            // Assert
            Assert.Equal(expected, result);
        }

        /*
         * Return the sum of the n numbers
        */
        [Theory]
        [InlineData(4, 10)]
        [InlineData(3, 6)]
        [InlineData(10, 55)]

        public void CalcularSumOfNNumbers_Number_SumOfNumbers(int number, int expected)
        {
            // Act
            var result = _sut.CalcularSumOfNNumbers(number);

            // Assert
            Assert.Equal(expected, result);
        }

        /*
         * Return factorial of n
        */
        [Theory]
        [InlineData(4, 24)]
        [InlineData(3, 6)]
        [InlineData(10, 3628800)]
        public void FactorialOf_Number_SumOfNumbers(int number, int expected)
        {
            // Act
            var result = _sut.FactorialOf(number);

            // Assert
            Assert.Equal(expected, result);
        }

        /*
         * Return Fibonacci of n
        */
        [Theory]
        [InlineData(4, "0112")]
        [InlineData(8, "011235813")]
        [InlineData(10, "0112358132134")]
        public void Fibonacci_Number_FibonacciSerieOfTheN(int number, string expected)
        {
            // Act
            var result = _sut.FibonacciOf(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
