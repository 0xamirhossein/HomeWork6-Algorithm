using System;
using System.Collections.Generic;
using System.Text;

namespace TargetOfSumInArray
{
    internal class BinarySearch
    {
        public static bool TargetOfSum(int[] array, int target)
        {
            if (array == null || array.Length < 2)
                return false;

            Array.Sort(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                int complement = target - array[i];
                    
                int foundIndex = Array.BinarySearch(array, i + 1, array.Length - (i + 1), complement);

                if (foundIndex >= 0)
                    return true;
            }

            return false;
        }

    }
}
