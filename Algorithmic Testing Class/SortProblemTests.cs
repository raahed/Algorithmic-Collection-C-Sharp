using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic_Collection;

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
        public void RadixSort()
        {
            int[] test = UnsortedDigitsLength;

            Algorithm.RadixSort(test);
            Assert.IsTrue(IsEqual(test, SortedDigitsLength));
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
        public void InsertionSortRecursiv()
        {
            int[] test = Unsorted;

            Algorithm.InsertionSortRecursiv(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void InsertionSortRecursivLastSeperated()
        {
            int[] test = Unsorted;

            Algorithm.InsertionSortRecursivLastSeperated(test);
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