using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithmic_Collection;

namespace Algorithmic_Tests
{
    [TestClass]
    public class AlgorithmicTests : AlgorithmicTester
    {
        [TestMethod]
        public void HeapSort()
        {
            int[] test = Unsorted;

            Algorithem.HeapSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void MergeSort()
        {
            int[] test = Unsorted;

            Algorithem.MergeSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void InsertionSort()
        {
            int[] test = Unsorted;

            Algorithem.InsertionSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }

        [TestMethod]
        public void SelectionSort()
        {
            int[] test = Unsorted;

            Algorithem.SelectionSort(test);
            Assert.IsTrue(IsEqual(test, Sorted));
        }
    }
}