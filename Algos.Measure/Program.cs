using ConsoleApp1.Array;
using System.Diagnostics;


var input = "ABCABCBB";
LengthOfLongestSubstring(input);







void LengthOfLongestSubstring(string s)
{
    var logic = new Longest_Substring_Without_Repeating_Characters();

    const int iterations = 10; // Number of runs to average
    double totalElapsedTime = 0;

    for (int i = 0; i < iterations; i++)
    {
        // Force garbage collection before each run to minimize GC influence
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        var stopWatch = new Stopwatch();
        stopWatch.Start();

        logic.LenghtOfLongestSubstring(s);

        stopWatch.Stop();
        totalElapsedTime += stopWatch.Elapsed.TotalMilliseconds;
    }

    double averageTime = totalElapsedTime / iterations;
    System.Diagnostics.Debug.WriteLine($"Average Execution Time: {averageTime} ms");
}
