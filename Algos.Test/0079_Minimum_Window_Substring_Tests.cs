using NUnit.Framework;

namespace Algos.Tests
{
    [TestFixture]
    public class _79_Minimum_Window_Substring_Tests
    {
        private _79_Minimum_Window_Substring _logic;
        [SetUp]
        public void SetUp()
        {
            _logic = new _79_Minimum_Window_Substring();
        }

        [Test]
        public void Test1()
        {

            var input = "ADOBECODEBANC";
            var t = "ABC";
            var expected = "BANC";

            var actual = _logic.MinWindow(input, t);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {

             var input = "a";
            var t = "a";
            var expected = "a";

            var actual = _logic.MinWindow(input, t);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {

            var input = "a";
            var t = "aa";
            var expected = "";

            var actual = _logic.MinWindow(input, t);

            Assert.That(actual, Is.EqualTo(expected));
        }

         [Test]
        public void Test4()
        {

            var input = "a";
            var t = "b";
            var expected = "";

            var actual = _logic.MinWindow(input, t);

            Assert.That(actual, Is.EqualTo(expected));
        }

         [Test]
        public void Test5()
        {

            var input = "a";
            var t = "AB";
            var expected = "";

            var actual = _logic.MinWindow(input, t);

            Assert.That(actual, Is.EqualTo(expected));
        }

          [Test]
        public void Test6()
        {

            var input = "aa";
            var t = "aa";
            var expected = "aa";

            var actual = _logic.MinWindow(input, t);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
