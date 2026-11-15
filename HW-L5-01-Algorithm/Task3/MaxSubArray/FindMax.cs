using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSubArray
{
    internal class FindMax
    {
        public static int FindLength(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int maxLength = 1;
            int currentLength = 1;


            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }
            maxLength = Math.Max(maxLength, currentLength);
            return maxLength;
        }
    }
}
