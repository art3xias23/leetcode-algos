using Algos.Data;
using NUnit.Framework;

namespace Algos.Tests
{
    [TestFixture]
    public class _0024_Swap_Nodes_In_Pairs_Tests
    {
        private ListNode ArrayToListNode(int[] arr)
        {
            if (arr == null || arr.Length == 0) return null;
            ListNode head = new ListNode(arr[0]);
            ListNode current = head;
            for (int i = 1; i < arr.Length; i++)
            {
                current.next = new ListNode(arr[i]);
                current = current.next;
            }
            return head;
        }

        // Helper method to convert ListNode to array
        private int[] ListNodeToArray(ListNode node)
        {
            var result = new List<int>();
            while (node != null)
            {
                result.Add(node.val);
                node = node.next;
            }
            return result.ToArray();
        }

        [Test]
        public void SwapPairs_WhenInputIsEmpty_ReturnsEmptyList()
        {
            // Arrange
            var solution = new _0024_Swap_Nodes_In_Pairs();
            ListNode head = null;

            // Act
            var result = solution.SwapPairs(head);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void SwapPairs_WhenInputHasOneNode_ReturnsSameList()
        {
            // Arrange
            var solution = new _0024_Swap_Nodes_In_Pairs();
            ListNode head = ArrayToListNode(new int[] { 1 });

            // Act
            var result = solution.SwapPairs(head);

            // Assert
            var expected = ArrayToListNode(new int[] { 1 });
            Assert.AreEqual(ListNodeToArray(expected), ListNodeToArray(result));
        }

        [Test]
        public void SwapPairs_WhenInputHasMultipleNodes_ReturnsSwappedList()
        {
            // Arrange
            var solution = new _0024_Swap_Nodes_In_Pairs();
            ListNode head = ArrayToListNode(new int[] { 1, 2, 3, 4 });

            // Act
            var result = solution.SwapPairs(head);

            // Assert
            var expected = ArrayToListNode(new int[] { 2, 1, 4, 3 });
            Assert.AreEqual(ListNodeToArray(expected), ListNodeToArray(result));
        }

        [Test]
        public void SwapPairs_WhenInputHasOddNodes_ReturnsPartiallySwappedList()
        {
            // Arrange
            var solution = new _0024_Swap_Nodes_In_Pairs();
            ListNode head = ArrayToListNode(new int[] { 1, 2, 3 });

            // Act
            var result = solution.SwapPairs(head);

            // Assert
            var expected = ArrayToListNode(new int[] { 2, 1, 3 });
            Assert.AreEqual(ListNodeToArray(expected), ListNodeToArray(result));
        }
    }
}
