using Algos.Data;

namespace Algos
{
    public class _0092_Reverse_Linked_List_II
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {

            ListNode dummy = new ListNode(0, head);
            ListNode leftPrev = null;
            ListNode current = head;
            leftPrev = dummy;
            for (var i = 1; i < left; i++)
            {
                leftPrev = current;
                current = current.next;
            }

            // Reverse the order from right to start

            ListNode prev = null;
            for (var i = 0; i < (right - left + 1); i++){
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            leftPrev.next.next = current;
            leftPrev.next = prev;

            return dummy.next;

        }
    }
}
