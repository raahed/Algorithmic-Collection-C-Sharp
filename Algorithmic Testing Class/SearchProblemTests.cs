using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic_Collection;
using System;

namespace Algorithmic_Tests
{
    [TestClass]
    public class SearchProblemTests : AlgorithmicTester
    {
        [TestMethod]
        public void BinarySearchRekursiv()
        {
            int[] test = Sorted;

            Random r = new Random();

            int ci = r.Next(0, test.Length);
            int cv = test[ci];

            int result = Algorithm.BinarySearchRecursiv(test, cv);
            Assert.IsTrue(cv == test[result]);
        }

        [TestMethod]
        public void BinarySearch()
        {
            int[] test = Sorted;

            Random r = new Random();

            int ci = r.Next(0, test.Length);
            int cv = test[ci];

            int result = Algorithm.BinarySeach(test, cv);
            Assert.IsTrue(cv == test[result]);
        }
    }
}
