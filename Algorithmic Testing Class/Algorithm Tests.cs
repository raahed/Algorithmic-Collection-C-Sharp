using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Algorithmic_Collection;

namespace Algorithmic_Testing_Class
{
    [TestClass]
    public class AlgorithmicTests
    {
        [TestMethod]
        public void MergeSort()
        {
            GenerateTestArray(out int[] a, out int[] b);

            int[] c = Algorithem.MergeSort(a);
            Assert.AreEqual(b, c);
        }

        [TestMethod]
        public void InsertionSort()
        {
            GenerateTestArray(out int[] a, out int[] b);

            int[] c = Algorithem.InsertionSort(a);
            Assert.AreEqual(b, c);
        }

        static public void GenerateTestArray(out int[] unsorted, out int[] sorted)
        {
            Random random = new Random();

            unsorted = new int[999];

            for (int i = 0; i < unsorted.Length; i++)
                unsorted[i] = random.Next(1, 1000);

            sorted = new int[unsorted.Length];

            Array.Sort(unsorted);
        }
    }
}