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
            GenerateTestArray(out int[] test, out int[] sorted);

            Algorithem.MergeSort(test);
            Assert.IsTrue(IsEqual(test, sorted));
        }

        [TestMethod]
        public void InsertionSort()
        {
            GenerateTestArray(out int[] test, out int[] sorted);

            Algorithem.InsertionSort(test);
            Assert.IsTrue(IsEqual(test, sorted));
        }

        [TestMethod]
        public void SelectionSort()
        {
            GenerateTestArray(out int[] test, out int[] sorted);

            Algorithem.SelectionSort(test);
            Assert.IsTrue(IsEqual(test, sorted));
        }


        static public void GenerateTestArray(out int[] unsorted, out int[] sorted)
        {
            Random random = new Random();

            unsorted = new int[999];

            for (int i = 0; i < unsorted.Length; i++)
                unsorted[i] = random.Next(1, 1000);

            sorted = (int[]) unsorted.Clone();

            Array.Sort(sorted);
        }

        static public bool IsEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for(int i = 0; i < array1.Length; i++)
                if (array1[i] != array2[i])
                    return false;

            return true;
        }
    }
}