namespace Algos.SearchAndSort
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;

            var left = 0;
            var right = nums.Length - 1;

            while(left <= right)
            {
               var midIndex = left + ((right-left)/2);
                Console.WriteLine(midIndex);
                if(nums[midIndex] == target) return midIndex;

                if(nums[midIndex] > target)
                    right = midIndex-1;
                else
                    left = midIndex+1;
            }

            return -1;

        }
    }
}
