using System.ComponentModel;

namespace Algos
{
    public class _209_Minimum_Size_Subarray_Sum
    {
        [Id(209)]
        [Category("SlidingWindow")]
        [Stats("21/09/24", "34:25")]
        public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Length == 0) return 0;

            var min = int.MaxValue;
            var currentSum = 0;
            var left = 0;

            for (var right = 0; right < nums.Length; right++)
            {
                currentSum += nums[right];

                while (currentSum >= target)
                {
                    min = Math.Min(min, right - left + 1);
                    currentSum -= nums[left];
                    left++;
                }

            }
            return min == int.MaxValue ? 0 : min;
        }
    }
}
