using Algos;
using System.ComponentModel;
using System.Diagnostics;

namespace ConsoleApp1.Array
{
    [Category("SlidingWindow")]
    [StatsAttribute("11/09/24", "42:10")]

    public class Longest_Substring_Without_Repeating_Characters
    {

        public int LenghtOfLongestSubstring(string s)
        {

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            if (s.Length == 0) return 0;
            if (s.Length == 1) return 1;

            var nonRepeatingList = new List<char>();
            var max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!IsRepeating(nonRepeatingList, s[i]))
                {
                    nonRepeatingList.Add(s[i]);
                }
                else
                {
                    max = Math.Max(nonRepeatingList.Count, max);
                    Console.WriteLine(string.Join("", nonRepeatingList));
                    var str = s[i];
                    var nonRepeatingListIndexOf = nonRepeatingList.IndexOf(str);
                    nonRepeatingList.RemoveRange(0, nonRepeatingListIndexOf);
                }
            }

            max = Math.Max(nonRepeatingList.Count, max);
            stopWatch.Stop();
            var time = stopWatch.Elapsed.TotalMilliseconds;
            System.Diagnostics.Debug.WriteLine(time);
            return max;
        }

        public bool IsRepeating(List<char> arr, char a)
        {
            foreach (char s in arr)
            {
                if (s == a)
                {
                    return true;
                };
            }
            return false;
        }
    }
}
