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
                for (int i = 1; i <= number; i++)
                    result = result * i;
            }
            return result;
        }
    }
}