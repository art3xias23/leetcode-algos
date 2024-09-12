﻿using Algos.Array;
using NUnit.Framework;

namespace Algos.Tests
{
    [TestFixture]
    public class Minimum_Size_Subarray_Sum_Tests
    {
        private Minimum_Size_Subarray_Sum _logic;
        [SetUp]
        public void SetUp()
        {
            _logic = new Minimum_Size_Subarray_Sum();
        }

        [Test]
        public void Test1()
        {

            var target = 7;
            var nums = new int[] { 2, 3, 1, 2, 4, 3 };
            var expected = 2;

            var actual = _logic.MinSubArrayLen(target, nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {

            var target = 4;
            var nums = new int[] { 1, 4, 4 };
            var expected = 1;

            var actual = _logic.MinSubArrayLen(target, nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {

            var target = 11;
            var nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            var expected = 0;

            var actual = _logic.MinSubArrayLen(target, nums);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
