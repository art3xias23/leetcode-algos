namespace Algos
{
    public class _0496_Next_Greater_Element_I
    {
        public int[] NextGreaterElement_BruteForce(int[] nums1, int[] nums2)
        {
            var map = new Dictionary<int, int>();
            var result = Enumerable.Repeat(-1, nums1.Length).ToArray();

            for (int i = 0; i < nums1.Length; i++)
            {
                map.Add(nums1[i], i);
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                var left = nums2[i];

                if (map.ContainsKey(left))
                {
                    for (int j = i + 1; j < nums2.Length; j++)
                    {
                        var right = nums2[j];
                        if (left < right)
                        {
                            result[map[left]] = nums2[j];
                            break;

                        }
                    }
                }
            }

            return result;

        }

        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var map = new Dictionary<int, int>();
            var result = Enumerable.Repeat(-1, nums1.Length).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                map.Add(nums1[i], i);
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                var currentVal = nums2[i]; //3 
                //stack - 1
                while (stack.Count > 0 && currentVal > stack.Peek())
                {
                    var previousVal = stack.Pop();
                    result[map[previousVal]] = currentVal;
                }
                if(map.ContainsKey(currentVal)) stack.Push(currentVal);
            }

            return result;

        }
    }
}
