using System.ComponentModel;

namespace Algos.HashTable
{
    [Id(1)]
    [Category("HashTable")]
    public class _1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (map.ContainsKey(diff)) return [map[diff], i];
                map.Add(nums[i], i);
            }
            throw new Exception();
        }
    }
}
