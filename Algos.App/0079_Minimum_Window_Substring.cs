using System.ComponentModel;

namespace Algos.Array
{
    public class _79_Minimum_Window_Substring
    {
        [Id(76)]
        [Category("SlidingWindow")]
        [StatsAttribute("13/09/24", "01:07:05")]
        public string MinWindow(string s, string t)
        {
            if (s.Length == 0)
                return "";
            var minString = s + "c";
            var currentString = string.Empty;
            var left = 0;
            var stopped = false;
            for (var right = 0; right < s.Length; right++)
            {
                left = right;
                if (t.Contains(s[right]))
                {
                    var copy = t;
                    while (copy.Length > 0)
                    {
                        if (left >= s.Length)
                        {
                            stopped = true;
                            break;
                        }
                        currentString += s[left];
                        if (copy.Contains(s[left]))
                        {
                            var index = copy.IndexOf(s[left]);
                            copy = copy.Remove(index, 1);
                        }
                        left++;
                    }
                    if (stopped == false)
                        minString = minString.Length > currentString.Length ? currentString : minString;
                    currentString = string.Empty;
                    Console.WriteLine(minString);
                }
            }

            if (minString == s + "c") return "";
            var r = minString.Length < t.Length ? string.Empty : minString;
            return r;
        }
    }
}
