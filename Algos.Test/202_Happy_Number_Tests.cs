using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Tests
{
    internal class _202_Happy_Number_Tests
    {
        private _202_Happy_Number solution;

    [SetUp]
    public void Setup()
    {
        solution = new _202_Happy_Number();
    }

    [Test]
    public void TestHappyNumber19()
    {
        // Example 1
        int input = 19;
        bool result = solution.IsHappy(input);
        Assert.IsTrue(result);
    }

    [Test]
    public void TestUnhappyNumber2()
    {
        // Example 2
        int input = 2;
        bool result = solution.IsHappy(input);
        Assert.IsFalse(result);
    }

    [Test]
    public void TestHappyNumber1()
    {
        // Number 1 is a happy number
        int input = 1;
        bool result = solution.IsHappy(input);
        Assert.IsTrue(result);
    }

    [Test]
    public void TestUnhappyNumber4()
    {
        // 4 is part of the cycle in unhappy numbers
        int input = 4;
        bool result = solution.IsHappy(input);
        Assert.IsFalse(result);
    }

    [Test]
    public void TestHappyNumber7()
    {
        // 7 is a happy number
        int input = 7;
        bool result = solution.IsHappy(input);
        Assert.IsTrue(result);
    }

    [Test]
    public void TestZero()
    {
        // Special case for zero (unhappy)
        int input = 0;
        bool result = solution.IsHappy(input);
        Assert.IsFalse(result);
    }

    [Test]
    public void TestNegativeNumber()
    {
        // Negative numbers are not typical happy number inputs
        int input = -19;
        bool result = solution.IsHappy(input);
        Assert.IsFalse(result);
    }
    }
}
