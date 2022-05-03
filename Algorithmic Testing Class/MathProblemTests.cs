using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic_Collection;
using System;

namespace Algorithmic_Tests
{
    [TestClass]
    public class MathProblemTests : AlgorithmicTester
    {
        private static readonly uint n = 40;
        private static readonly uint fn = 102334155;

        [TestMethod]
        public void Fibonacci()
        {
            Assert.IsTrue(fn == Algorithm.Fibonacci(n));
        }

        [TestMethod]
        public void FibonacciWithMemo()
        {
            Assert.IsTrue(fn == Algorithm.FibonacciWithMemo(n));
        }

        [TestMethod]
        public void FibonacciBottomUp()
        {
            Assert.IsTrue(fn == Algorithm.FibonacciBottomUp(n));
        }
    }
}
