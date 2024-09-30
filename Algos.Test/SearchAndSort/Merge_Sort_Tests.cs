using Algos.SearchAndSort;
using NUnit.Framework;

namespace Algos.Tests.SearchAndSort
{
    [TestFixture]
    internal class Merge_Sort_Tests
    {
        private MergeSort _solution;
        [SetUp]
        public void SetUp()
        {
            _solution = new MergeSort();
        }
        [Test]
        public void MergeSort_MixedNumbers_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 34, 7, 23, 32, 5, 62 };
            int[] expected = { 5, 7, 23, 32, 34, 62 };

            // Act
            int[] result = _solution.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MergeSort_AlreadySorted_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = _solution.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MergeSort_ReverseSorted_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 9, 8, 7, 6, 5 };
            int[] expected = { 5, 6, 7, 8, 9 };

            // Act
            int[] result = _solution.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MergeSort_ArrayWithDuplicates_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 10, 7, 7, 2, 5, 10, 5 };
            int[] expected = { 2, 5, 5, 7, 7, 10, 10 };

            // Act
            int[] result = _solution.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MergeSort_SingleElement_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            // Act
            int[] result = _solution.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MergeSort_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            int[] result = _solution.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // You will need to implement MergeSort here
    }

}
