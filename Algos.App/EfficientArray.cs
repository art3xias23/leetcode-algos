using System.Diagnostics;
using System;


public class EfficientArrayCopy
{
    public void Action()
    {

        // Large array of sensor readings
        int[] sensorReadings = new int[1_000_000];

        // Fill the array with some data
        for (int i = 0; i < sensorReadings.Length; i++)
        {
            sensorReadings[i] = i;
        }

        // Define start and end indices
        int start = 100_000;
        int end = 500_000;

        CopyArrayInefficiently(sensorReadings, start, end);
        Console.WriteLine();
        CopyArrayEfficiently(sensorReadings, start, end);

        static void CopyArrayInefficiently(int[] originalArray, int start, int end)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] subArray = new int[end - start];
            Array.Copy(originalArray, start, subArray, 0, end - start);
            stopwatch.Stop();
            Console.WriteLine($"Time taken for slicing inefficiently {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Inefficient array. Length: {subArray.Length}, First: {subArray[0]}. Last: {subArray[subArray.Length - 1]}");
        }

        static void CopyArrayEfficiently(int[] originalArray, int start, int end)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] subArray = new int[end - start];
            for (int i = 0; i < end - start; i++)
            {
                subArray[i] = originalArray[start + i];
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken for slicing efficiently {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Efficient array. Length: {subArray.Length}, First: {subArray[0]}. Last: {subArray[subArray.Length - 1]}");
        }
    }
}
