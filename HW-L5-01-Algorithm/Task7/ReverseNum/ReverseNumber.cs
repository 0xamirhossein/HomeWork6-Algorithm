using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseNum
{
    internal class ReverseNumber
    {
        public static  int Reverse(int number)
        {
            int reversed = 0;

            while (number != 0)
            {
                
                int digit = number % 10;
                number /= 10;

                if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && digit > 7))
                {
                    return 0;
                }

                if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && digit < -8))
                {
                    return 0;
                }

                reversed = reversed * 10 + digit;
            }
            return reversed;
        }
    }
}
