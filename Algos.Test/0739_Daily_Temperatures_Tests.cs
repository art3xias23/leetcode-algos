using NUnit.Framework;

namespace Algos.Tests
{
    [TestFixture]
    internal class _0739_Daily_Temperatures_Tests
    {
        [Test]
        public void TestExample1()
        {
            // Arrange
            var temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            var expected = new int[] { 1, 1, 4, 2, 1, 1, 0, 0 };

            // Act
            var result = _739_Daily_Temperatures.DailyTemperatures(temperatures);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestExample2()
        {
            // Arrange
            var temperatures = new int[] { 30, 40, 50, 60 };
            var expected = new int[] { 1, 1, 1, 0 };

            // Act
            var result = _739_Daily_Temperatures.DailyTemperatures(temperatures);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestExample3()
        {
            // Arrange
            var temperatures = new int[] { 30, 60, 90 };
            var expected = new int[] { 1, 1, 0 };

            // Act
            var result = _739_Daily_Temperatures.DailyTemperatures(temperatures);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDecreasingTemperatures()
        {
            // Arrange
            var temperatures = new int[] { 100, 90, 80, 70 };
            var expected = new int[] { 0, 0, 0, 0 }; // No higher temperatures ahead

            // Act
            var result = _739_Daily_Temperatures.DailyTemperatures(temperatures);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestAllSameTemperatures()
        {
            // Arrange
            var temperatures = new int[] { 50, 50, 50, 50 };
            var expected = new int[] { 0, 0, 0, 0 }; // No higher temperatures ahead

            // Act
            var result = _739_Daily_Temperatures.DailyTemperatures(temperatures);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSingleTemperature()
        {
            // Arrange
            var temperatures = new int[] { 70 };
            var expected = new int[] { 0 }; // Only one temperature, no future day

            // Act
            var result = _739_Daily_Temperatures.DailyTemperatures(temperatures);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
