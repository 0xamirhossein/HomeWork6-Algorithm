using System;
using System.Collections.Generic;
using System.Text;

namespace MaxProductArray
{
    internal class FindMax
    {
        public static long Find(int[] numbers)
        {
            if (numbers == null || numbers.Length < 3)
                throw new ArgumentException("Array must contain at least 3 elements.");

            long max1 = long.MinValue;
            long max2 = long.MinValue;
            long max3 = long.MinValue;

            long min1 = long.MaxValue;
            long min2 = long.MaxValue;

            foreach (int number in numbers)
            {
                if (number >= max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = number;
                }
                else if (number >= max2)
                {
                    max3 = max2;
                    max2 = number;
                }
                else if (number > max3)
                {
                    max3 = number;
                }

                if (number <= min1)
                {
                    min2 = min1;
                    min1 = number;
                }
                else if (number < min2)
                {
                    min2 = number;
                }
            }

            long product1 = max1 * max2 * max3;
            long product2 = max1 * min1 * min2;

            return Math.Max(product1, product2);
        }
    }
}


