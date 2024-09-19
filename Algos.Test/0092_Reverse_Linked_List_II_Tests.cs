namespace Algos.Tests
{
    using Algos.Data;
    using NUnit.Framework;
    [TestFixture]
    public class _92_Reverse_Linked_List_II_Tests
    {
        private _0092_Reverse_Linked_List_II _logic;

        [SetUp]
        public void Setup()
        {
            _logic = new _0092_Reverse_Linked_List_II();
        }

        // Helper method to convert an array to a linked list
        private ListNode ArrayToList(int[] values)
        {
            if (values == null || values.Length == 0) return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        // Helper method to convert a linked list to an array
        private int[] ListToArray(ListNode head)
        {
            var result = new List<int>();
            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }
            return result.ToArray();
        }

        // Test Case 1: Reverse from position 2 to 4 in 1->2->3->4->5
        [Test]
        public void Test_ReverseLinkedListII_Example1()
        {
            ListNode head = ArrayToList(new int[] { 1, 2, 3, 4, 5 });
            ListNode result = _logic.ReverseBetween(head, 2, 4);
            int[] resultArray = ListToArray(result);

            Assert.AreEqual(new int[] { 1, 4, 3, 2, 5 }, resultArray);
        }

        // Test Case 2: Reverse from position 1 to 1 in 1->2->3->4->5 (no change)
        [Test]
        public void Test_ReverseLinkedListII_Example2()
        {
            ListNode head = ArrayToList(new int[] { 1, 2, 3, 4, 5 });
            ListNode result = _logic.ReverseBetween(head, 1, 1);
            int[] resultArray = ListToArray(result);

            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, resultArray);
        }

        // Test Case 3: Reverse the entire list 1->2->3->4->5
        [Test]
        public void Test_ReverseLinkedListII_Example3()
        {
            ListNode head = ArrayToList(new int[] { 1, 2, 3, 4, 5 });
            ListNode result = _logic.ReverseBetween(head, 1, 5);
            int[] resultArray = ListToArray(result);

            Assert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, resultArray);
        }

        // Test Case 4: Reverse a single element list (no change)
        [Test]
        public void Test_ReverseLinkedListII_Example4()
        {
            ListNode head = ArrayToList(new int[] { 1 });
            ListNode result = _logic.ReverseBetween(head, 1, 1);
            int[] resultArray = ListToArray(result);

            Assert.AreEqual(new int[] { 1 }, resultArray);
        }

        // Test Case 5: Reverse a part of the list 1->2->3->4->5, m = 3, n = 5
        [Test]
        public void Test_ReverseLinkedListII_Example5()
        {
            ListNode head = ArrayToList(new int[] { 1, 2, 3, 4, 5 });
            ListNode result = _logic.ReverseBetween(head, 3, 5);
            int[] resultArray = ListToArray(result);

            Assert.AreEqual(new int[] { 1, 2, 5, 4, 3 }, resultArray);
        }
    }

}
