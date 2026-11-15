using System;
using System.Collections.Generic;
using System.Text;

namespace FindChar
{
    internal class FindUniqueChar
    {
        public static int Find(string? text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return -1;

            int[] charCount = new int[26];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = char.ToLowerInvariant(text[i]);
                if (ch >= 'a' && ch <= 'z')
                {
                    charCount[ch - 'a']++;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                char ch = char.ToLowerInvariant(text[i]);
                if (ch >= 'a' && ch <= 'z' && charCount[ch - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}