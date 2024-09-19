using Algos.Data;
using Algos;
using NUnit.Framework;

internal class _206_Reverse_Linked_List_Tests
{
    private _206_Reverse_Linked_List _logic;

    [SetUp]
    public void Setup()
    {
        _logic = new _206_Reverse_Linked_List();
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

    // Test Case 1: head = [1,2,3,4,5]
    [Test]
    public void Test_ReverseLinkedList_Example1()
    {
        ListNode head = ArrayToList(new int[] { 1, 2, 3, 4, 5 });
        ListNode result = _logic.ReverseList(head);
        int[] resultArray = ListToArray(result);

        Assert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, resultArray);
    }

    // Test Case 2: head = [1,2]
    [Test]
    public void Test_ReverseLinkedList_Example2()
    {
        ListNode head = ArrayToList(new int[] { 1, 2 });
        ListNode result = _logic.ReverseList(head);
        int[] resultArray = ListToArray(result);

        Assert.AreEqual(new int[] { 2, 1 }, resultArray);
    }

    // Test Case 3: head = []
    [Test]
    public void Test_ReverseLinkedList_Example3()
    {
        ListNode head = ArrayToList(new int[] { });
        ListNode result = _logic.ReverseList(head);
        int[] resultArray = ListToArray(result);

        Assert.AreEqual(new int[] { }, resultArray);
    }
}
