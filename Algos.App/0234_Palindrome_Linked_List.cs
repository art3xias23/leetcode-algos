using Algos.Data;

namespace Algos
{
    public class _234_Palindrome_Linked_List
    {
        //Using a hashmap
        public bool IsPalindrome_1(ListNode head)
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

        //Use stack
        public bool IsPalindrome_2(ListNode hed)
        {
            if (hed == null || hed.next == null)
            {
                return true;
            }
            var originalHead = hed;

            var stack = new Stack<int>();
            while (hed != null)
            {
                stack.Push(hed.val);
                hed = hed.next;
            }

            var middle = stack.Count() / 2;

            var head = originalHead;
            while (stack.Count() > middle)
            {
                var stackElement = stack.Pop();
                var headElement = head.val;
                if (stackElement != headElement)
                {
                    return false;
                }
                head = head.next;
            }
            return true;
        }

        //Use slow and fast pointers
        public bool IsPalindrome_3(ListNode head)
        {
            // use fast and slow pointers to find the first element of the second half
            if (head == null || head.next == null)
                return true;

            var s = head;
            var f = head;
            while (f != null)
            {
                s = s.next;
                f = f.next?.next;
            }

            // use a method to reverse the second half items starting from the last one
            var reversedSecondHalfHead = ReverseList(s);
            var reversedHead = reversedSecondHalfHead;

            // while( the second half head != null compare secondhalf value to head value
            while (reversedHead != null)
            {
                if (head.val != reversedHead.val)
                    return false;
                head = head.next;
                reversedHead = reversedHead.next;
            }
            return true;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

        public bool IsPalindrome(ListNode head)
        {
            // use fast and slow pointers to find the first element of the second half
            if (head == null || head.next == null)
                return true;

            var s = head;
            var f = head;
            ListNode prev = null;

            while (f?.next != null)
            {
                f = f.next?.next;
                var next = s.next; // 2 | 3
                s.next = prev; //null | 1
                prev = s; //1 | 2
                s = next; //2
            }

            if (f != null)
            {
                s = s.next;
            }


            // while( the second half head != null compare secondhalf value to head value
            while (prev != null)
            {
                if (prev.val != s.val)
                    return false;
                prev = prev.next;
                s = s.next;
            }
            return true;

        }

    }
}
