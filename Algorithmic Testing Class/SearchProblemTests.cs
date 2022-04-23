using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic_Collection;
using System;

namespace Algorithmic_Tests
{
    [TestClass]
    public class SearchProblemTests : AlgorithmicTester
    {

        [TestMethod]
        public void BinarySearchRecursiv()
        {
            int[] test = Sorted;

            int subject = random.Next(ArrayMinValue, ArrayMaxValue);

            int result = Algorithm.BinarySearchRecursiv(test, subject);

            if (result == -1 && !Array.Exists(test, elm => elm == subject))
            {
                Assert.IsTrue(true);
                Console.WriteLine($"Value not found {subject}");
            }
            else
            {
                Assert.IsTrue(subject == test[result]);
                Console.WriteLine($"Value {subject} found at index {result}");
            }
        }

        [TestMethod]
        public void BinarySearch()
        {
            int[] test = Sorted;

            int subject = random.Next(ArrayMinValue, ArrayMaxValue);

            int result = Algorithm.BinarySearchRecursiv(test, subject);

            if (result == -1 && !Array.Exists(test, elm => elm == subject))
            {
                Assert.IsTrue(true);
                Console.WriteLine($"Value not found {subject}");
            }
            else
            {
                Assert.IsTrue(subject == test[result]);
                Console.WriteLine($"Value {subject} found at index {result}");
            }
        }
    }
}
