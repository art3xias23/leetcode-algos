using Algos.Data;

namespace Algos
{
    public class _234_Palindrome_Linked_List
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;
            var counter = 0;
            var map = new Dictionary<int, int>();
            while (head != null)
            {
                map.Add(counter, head.val);
                counter++;
                head = head.next;
            }

            var l = 0;
            var r = map.Keys.Count() - 1;

            while (r > l)
            {
                if (map[r] != map[l])
                    return false;
                l++;
                r--;
            }
            return true;
        }
    }
}
