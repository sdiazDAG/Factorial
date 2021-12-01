using System;
using Xunit;

namespace FactorialSpecs
{
    public class FactorialSpecs
    {
        [Fact]
        public void When_number_is_0_then_factorial_is_1()
        {
            var expectedFactorial = 1;
            var number = 0;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_1_then_factorial_is_1()
        {
            var expectedFactorial = 1;
            var number = 1;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_2_then_factorial_is_1()
        {
            var expectedFactorial = 2;
            var number = 2;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_3_then_factorial_is_6()
        {
            var expectedFactorial = 6;
            var number = 3;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }

        [Fact]
        public void When_number_is_10_then_factorial_is_3628800()
        {
            var expectedFactorial = 3628800;
            var number = 10;

            var resultFactorial = Factorial.Calculate(number);
            Assert.Equal(expectedFactorial, resultFactorial);
        }
    }
}
