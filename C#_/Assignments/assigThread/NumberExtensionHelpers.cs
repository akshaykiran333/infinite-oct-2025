using System.Collections.Generic;

namespace assigThread
{
    internal static class NumberExtensionHelpers
    {
        public static int SumOfSquares(this IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i * i;
            }
            return sum;
        }
    }
}