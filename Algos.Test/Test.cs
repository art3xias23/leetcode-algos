namespace Algos.Tests
{
    using Algos.Data;
    using NUnit.Framework;

    [TestFixture]
    public class Test
    {

        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void TwoSum_WhenNumsAre2_7_11_15_AndTargetIs9_Returns0_1()
        {
            var listNode = new ListNode();
            listNode.val = 5;

            var s = listNode;
            var f = listNode;
            s.val = 7;
            var q = f.val;
        }
    }
}

