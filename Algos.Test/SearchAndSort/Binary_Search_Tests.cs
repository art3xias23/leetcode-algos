using Algos.SearchAndSort;
using NUnit.Framework;

namespace Algos.Tests.SearchAndSort
{
    [TestFixture]
    public class Binary_Search_Tests
    {

        private BinarySearch binarySearch;

        [SetUp]
        public void SetUp()
        {
            binarySearch = new BinarySearch();
        }

        [Test]
        public void Test_TargetInMiddle()
        {
            int[] nums = { 1, 3, 5, 7, 9 };
            int target = 5;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test_TargetIsFirstElement()
        {
            int[] nums = { 1, 3, 5, 7, 9 };
            int target = 1;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_TargetIsLastElement()
        {
            int[] nums = { 1, 3, 5, 7, 9 };
            int target = 9;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_TargetNotInArray()
        {
            int[] nums = { 1, 3, 5, 7, 9 };
            int target = 6;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test_EmptyArray()
        {
            int[] nums = { };
            int target = 3;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test_SingleElementArray_Found()
        {
            int[] nums = { 5 };
            int target = 5;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_SingleElementArray_NotFound()
        {
            int[] nums = { 5 };
            int target = 3;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test_ArrayWithDuplicates_Found()
        {
            int[] nums = { 1, 2, 4, 4, 4, 7, 9 };
            int target = 4;

            int result = binarySearch.Search(nums, target);

            Assert.IsTrue(result == 2 || result == 3 || result == 4);
        }

        [Test]
        public void Test_ArrayWithNegativeNumbers()
        {
            int[] nums = { -10, -5, 0, 5, 10 };
            int target = -5;

            int result = binarySearch.Search(nums, target);

            Assert.AreEqual(1, Math.Abs(result));
        }
    }
}
