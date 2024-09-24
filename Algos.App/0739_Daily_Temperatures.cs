namespace Algos
{
    public class _739_Daily_Temperatures
    {
        public static int[] DailyTemperatures_BruteForce(int[] temperatures)
        {
            var list = new List<int>();
            for (var i = 0; i < temperatures.Length; i++)
            {
                var counter = 1;
                for (var j = i + 1; j < temperatures.Length; j++)
                {
                    var next = temperatures[j];
                    var current = temperatures[i];
                    if (next > current)
                    {
                        list.Add(counter);
                        break;
                    }
                    counter++;
                }
                if (list.Count() == i) list.Add(0);
            }
            return list.ToArray();
        }

        public static int[] DailyTemperatures(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var stack = new Stack<(int, int)>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                var temp = temperatures[i];
                while (stack.Count() > 0 && temp > stack.Peek().Item1)
                {

                    var (stackTemp, stackIndex) = stack.Pop();
                    result[stackIndex] = i - stackIndex;
                }
                stack.Push((temp, i));
            }

            return result;

        }
    }
}
