namespace Algos.Array
{
    [Id(1)]
    public class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var l = 0; l < nums.Length; l++)
            {
                for (var r = l + 1; r < nums.Length; r++)
                {

                    if (nums[l] + nums[r] == target)
                        return [l, r];
                }
            }
            return [];
        }
    }
}
