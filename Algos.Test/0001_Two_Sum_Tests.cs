namespace Algos.Tests
{
    using Algos;
    using NUnit.Framework;

    [TestFixture]
    public class _1_Two_Sum_Tests
    {
        private _1_Two_Sum _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new _1_Two_Sum();
        }

        [Test]
        public void TwoSum_WhenNumsAre2_7_11_15_AndTargetIs9_Returns0_1()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(new int[] { 0, 1 }, result);
        }

        [Test]
        public void TwoSum_WhenNumsAre3_2_4_AndTargetIs6_Returns1_2()
        {
            // Arrange
            int[] nums = { 3, 2, 4 };
            int target = 6;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(new int[] { 1, 2 }, result);
        }

        [Test]
        public void TwoSum_WhenNumsAre3_3_AndTargetIs6_Returns0_1()
        {
            // Arrange
            int[] nums = { 3, 3 };
            int target = 6;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(new int[] { 0, 1 }, result);
        }

         [Test]
        public void TwoSum_WhenTargetIs0_Returns0()
        {
            // Arrange
            int[] nums = { 0,4,3,0};
            int target = 0;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(new int[] { 0, 3 }, result);
        }
        
         [Test]
        public void TwoSum_5()
        {
            // Arrange
            int[] nums = {-3,4,3,90};
            int target = 0;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(new int[]{0, 2} , result);
        }
    }
}
