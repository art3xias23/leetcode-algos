namespace Algos.Tests.SearchAndSort
{
    internal class QuickSort_Tests
    {
        private QuickSort sorter;

        [SetUp]
        public void SetUp()
        {
            sorter = new QuickSort();
        }

        [Test]
        public void Test_AlreadySortedArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            sorter.Quicksort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Test_ReverseSortedArray()
        {
            int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            sorter.Quicksort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Test_ArrayWithDuplicates()
        {
            int[] array = { 4, 2, 7, 3, 7, 1, 4, 9, 4 };
            int[] expected = { 1, 2, 3, 4, 4, 4, 7, 7, 9 };

            sorter.Quicksort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Test_SingleElementArray()
        {
            int[] array = { 42 };
            int[] expected = { 42 };

            sorter.Quicksort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Test_EmptyArray()
        {
            int[] array = { };
            int[] expected = { };

            sorter.Quicksort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Test_UnsortedArray()
        {
            int[] array = { 5, 2, 9, 1, 5, 6 };
            int[] expected = { 1, 2, 5, 5, 6, 9 };

            sorter.Quicksort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }
    }
}
