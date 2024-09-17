namespace Algos.Tests
{
    using Algos.HashTable;
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
            var node1 = new LinkedListNode<int>(2);
            var node2 = new LinkedListNode<int>(2);

            Assert.That(node1, Is.EqualTo(node2));
        }
    }
}

