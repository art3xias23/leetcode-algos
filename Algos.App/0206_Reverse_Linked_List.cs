using Algos.Data;

namespace Algos
{
    public class _206_Reverse_Linked_List
    {
        public ListNode ReverseList(ListNode head)
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
    }
}
