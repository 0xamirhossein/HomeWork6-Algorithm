using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertNumToWords
{
    internal class NumToWords
    {
        private static readonly string[] Units = {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"
        };

        private static readonly string[] Teens = {
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private static readonly string[] Tens = {
            "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };


        public static string Convert(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Number must be non-negative.");
            }
            if (number < 10)
            {
                return Units[number];
            }

            if (number < 20)
            {
                return Teens[number - 10];
            }
            if (number < 100)
            {
                int remainder = number % 100;

                return Units[number / 100] + " Hundred" +
                       (remainder != 0 ? " and " + Convert(remainder) : "");

            }

            if (number < 1000)
            {
                int remainder = number % 100;

                return Units[number / 100] + " Hundred" +
                       (remainder != 0 ? " and " + Convert(remainder) : "");
            }

            int remaining = number % 1000;

            return Convert(number / 1000) + " Thousand" +
                   (remaining != 0 ? " " + Convert(remaining) : "");
        }
    }
}