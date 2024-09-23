using Algos.Data;

namespace Algos
{
    public class _0024_Swap_Nodes_In_Pairs
    {
        public ListNode SwapPairs_Recursion(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            var f = head;
            var s = f.next;
            var next = s.next;
            s.next = f;
            f.next = SwapPairs_Recursion(next);
            return s;

        }

        public ListNode SwapPairs(ListNode head)
        {

            var dummy = new ListNode(0, head);

            var current = head;
            var prev = dummy;

            while (current != null && current?.next != null)
            {
                //save ptrs
                var second = current.next;
                var nextPair = second?.next;

                //reverse

                second.next = current;
                current.next = nextPair;
                prev.next = second; //0->2 -> 1 -> 3

                //reassign pointers
                prev = current;
                current = nextPair;

            }

            return dummy.next;

        }
    }
}
