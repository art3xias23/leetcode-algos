﻿using System.ComponentModel;

namespace Algos
{
    [Id(3)]
    [Category("SlidingWindow")]
    [Stats("11/09/24", "42:10")]

    public class _3_Longest_Substring_Without_Repeating_Characters
    {

        public int LenghtOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            var charSet = new HashSet<char>();
            var max = 0;
            var left = 0;

            for (var right = 0; right < s.Length; right++)
            {
                while (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }
                charSet.Add(s[right]);
                max = Math.Max(max, right - left + 1);
            }
            return max;
        }
    }
}
