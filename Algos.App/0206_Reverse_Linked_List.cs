using Algos.Data;

namespace Algos
{
    public class _206_Reverse_Linked_List
    {
        public ListNode ReverseList_Iteratively(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }

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

        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            // Recursive case: reverse the rest of the list
            ListNode newHead = ReverseList(head.next);

            // Adjust pointers: reverse the current node's next pointer
            head.next.next = head;
            head.next = null;

            return newHead;
        }
    }
}
