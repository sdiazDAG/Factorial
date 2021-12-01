using System;
using Xunit;

namespace FactorialSpecs
{
    public class FactorialSpecs
    {
        [Fact]
        public void When_number_is_0_then_factorial_is_1()
        {
            const int expectedFactorial = 1;
            const int number = 0;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_1_then_factorial_is_1()
        {
            const int expectedFactorial = 1;
            const int number = 1;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_2_then_factorial_is_1()
        {
            const int expectedFactorial = 2;
            const int number = 2;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_3_then_factorial_is_6()
        {
            const int expectedFactorial = 6;
            const int number = 3;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_10_then_factorial_is_3628800()
        {
            const int expectedFactorial = 3628800;
            const int number = 10;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }
    }
}
