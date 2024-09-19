namespace Algos.Tests
{
    using Algos.Data;
    using NUnit.Framework;
    [TestFixture]
    public class _234_Palindrome_Linked_List_Tests
    {
        private _234_Palindrome_Linked_List solution;

        [SetUp]
        public void Setup()
        {
            solution = new _234_Palindrome_Linked_List();
        }

        [Test]
        public void TestPalindromeList1()
        {
            // Creating a palindrome linked list: 1 -> 2 -> 2 -> 1
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
            bool result = solution.IsPalindrome(head);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestPalindromeList2()
        {
            // Creating a single-node linked list: 1
            ListNode head = new ListNode(1);
            bool result = solution.IsPalindrome(head);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestNonPalindromeList()
        {
            // Creating a non-palindrome linked list: 1 -> 2 -> 3
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3)));
            bool result = solution.IsPalindrome(head);
            Assert.IsFalse(result);
        }


        [Test]
        public void TestPalindromeList3()
        {
            // Creating a palindrome linked list: 1 -> 2 -> 3 -> 2 -> 1
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(2, new ListNode(1)))));
            bool result = solution.IsPalindrome(head);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestEmptyList()
        {
            // Creating an empty linked list: (null)
            ListNode head = null;
            bool result = solution.IsPalindrome(head);
            Assert.IsTrue(result);
        }
    }

}
