using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic_Collection;
using System;

namespace Algorithmic_Tests
{
    [TestClass]
    public class SortProblemTests : AlgorithmicTester
    {
        [TestMethod]
        public void BubbleSort()
        {
            int[] test = Unsorted;

            Algorithm.BubbleSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void CountingSort()
        {
            int[] test = Unsorted;

            Algorithm.CountingSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void RadixSort()
        {
            int[] test = Unsorted;

            Algorithm.RadixSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void HeapSort()
        {
            int[] test = Unsorted;

            Algorithm.HeapSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void QuickSort()
        {
            int[] test = Unsorted;

            Algorithm.QuickSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void MergeSort()
        {
            int[] test = Unsorted;

            Algorithm.MergeSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void MergeSortWithoutSentinel()
        {
            int[] test = Unsorted;

            Algorithm.MergeSortWithoutSentinel(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void InsertionSort()
        {
            int[] test = Unsorted;

            Algorithm.InsertionSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void SelectionSort()
        {
            int[] test = Unsorted;

            Algorithm.SelectionSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }
    }
}