using NUnit.Framework;

namespace Algos.Tests
{
    public class _0496_Next_Greater_Element_I_Tests
    {
        [Test]
        public void TestExample1()
        {
            // Arrange
            var nums1 = new int[] { 4, 1, 2 };
            var nums2 = new int[] { 1, 3, 4, 2 };
            var expected = new int[] { -1, 3, -1 };

            // Act
            var result = _0496_Next_Greater_Element_I.NextGreaterElement(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestExample2()
        {
            // Arrange
            var nums1 = new int[] { 2, 4 };
            var nums2 = new int[] { 1, 2, 3, 4 };
            var expected = new int[] { 3, -1 };

            // Act
            var result = _0496_Next_Greater_Element_I.NextGreaterElement(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestEmptyNums1()
        {
            // Arrange
            var nums1 = new int[] { };
            var nums2 = new int[] { 1, 3, 4, 2 };
            var expected = new int[] { };

            // Act
            var result = _0496_Next_Greater_Element_I.NextGreaterElement(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestNoNextGreaterElements()
        {
            // Arrange
            var nums1 = new int[] { 4, 2 };
            var nums2 = new int[] { 4, 3, 2, 1 };
            var expected = new int[] { -1, -1 };

            // Act
            var result = _0496_Next_Greater_Element_I.NextGreaterElement(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSingleElementInNums1()
        {
            // Arrange
            var nums1 = new int[] { 3 };
            var nums2 = new int[] { 1, 3, 4, 2 };
            var expected = new int[] { 4 };

            // Act
            var result = _0496_Next_Greater_Element_I.NextGreaterElement(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
