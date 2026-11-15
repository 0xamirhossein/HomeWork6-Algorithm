using System;
using System.Collections.Generic;
using System.Text;

namespace CreateTriFromArray
{
    internal class Find
    {
        public static bool FindTri(int[] number)
        {
            int n = number.Length;


            foreach (int item in number)
            {
                if (item <= 0)
                    return false;
            }



            if (n < 3)
            {
                return false;
            }
            Array.Sort(number);

            bool found = false;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if ((long)number[i] + number[j] > number[k])
                        {
                            Console.WriteLine($"Triangle: {number[i]}, {number[j]}, {number[k]}");
                            
                            found = true;
                        }
                    }
                }
            }

            return found;
        }
    }
}