using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;

namespace FactorialSpecs
{
    public class Factorial
    {
        public static long Calculate(int number)
        {
            var result = 1;
            if (number >= 2)
            {
                for (var i = 1; i <= number; i++)
                    result *= i;
            }
            return result;
        }
    }
}