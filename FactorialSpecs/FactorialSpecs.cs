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
    }

    public class Factorial
    {
        public static int Calculate(int number)
        {
            return 1;
        }
    }
}