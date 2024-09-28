using Algos.SearchAndSort;
using NUnit.Framework;


namespace Algos.Tests.SearchAndSort
{
    [TestFixture]
    public class SelectionSortTests
    {
        private SelectionSort sorter;

        [SetUp]
        public void SetUp()
        {
            sorter = new SelectionSort();
        }

        [Test]
        public void Test_AlreadySortedArray()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            sorter.Sort(nums);

            Assert.AreEqual(expected, nums);
        }

        [Test]
        public void Test_UnsortedArray()
        {
            int[] nums = { 5, 2, 9, 1, 5, 6 };
            int[] expected = { 1, 2, 5, 5, 6, 9 };

            sorter.Sort(nums);

            Assert.AreEqual(expected, nums);
        }

        [Test]
        public void Test_ReverseSortedArray()
        {
            int[] nums = { 9, 7, 5, 3, 1 };
            int[] expected = { 1, 3, 5, 7, 9 };

            sorter.Sort(nums);

            Assert.AreEqual(expected, nums);
        }

        [Test]
        public void Test_ArrayWithDuplicates()
        {
            int[] nums = { 4, 2, 4, 1, 3 };
            int[] expected = { 1, 2, 3, 4, 4 };

            sorter.Sort(nums);

            Assert.AreEqual(expected, nums);
        }

        [Test]
        public void Test_EmptyArray()
        {
            int[] nums = { };
            int[] expected = { };

            sorter.Sort(nums);

            Assert.AreEqual(expected, nums);
        }

        [Test]
        public void Test_SingleElementArray()
        {
            int[] nums = { 1 };
            int[] expected = { 1 };

            sorter.Sort(nums);

            Assert.AreEqual(expected, nums);
        }

        [Test]
        public void Test_LargeArray()
        {
            int[] nums = { 100, 23, 54, 67, 89, 1, 99 };
            int[] expected = { 1, 23, 54, 67, 89, 99, 100 };

            sorter.Sort(nums);

            Assert.AreEqual(expected, nums);
        }
    }
}