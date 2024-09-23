using NUnit.Framework;

namespace Algos.Tests
{
    [TestFixture]
    public class _3_Longest_Substring_Without_Repeating_Characters_Tests
    {
        private _3_Longest_Substring_Without_Repeating_Characters _logic;

        [SetUp]
        public void Setup()
        {
            _logic = new _3_Longest_Substring_Without_Repeating_Characters();
        }

        [Test]
        public void Test1()
        {
            var input = "abcabcbb";
            var expected = 3;

            var actual = _logic.LenghtOfLongestSubstring(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var input = "bbbbb";
            var expected = 1;

            var actual = _logic.LenghtOfLongestSubstring(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var input = "pwwkew";
            var expected = 3;

            var actual = _logic.LenghtOfLongestSubstring(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            var input = "a";
            var expected = 1;

            var actual = _logic.LenghtOfLongestSubstring(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        }
}