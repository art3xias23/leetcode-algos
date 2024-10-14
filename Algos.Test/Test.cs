using Algos.SearchAndSort;
using NUnit.Framework;

namespace Algos
{
    [TestFixture]
    internal class Test
    {
        [Test]
        public void Sort()
        {
            var test = new TestSort();

            var arr = new []{3, 8, 9, 1, 5, 3, 7, 9, 2};
            var actual = test.Sort(arr);

            var expected = new[]{1, 2, 3, 3, 5, 7, 8, 9, 9};

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
