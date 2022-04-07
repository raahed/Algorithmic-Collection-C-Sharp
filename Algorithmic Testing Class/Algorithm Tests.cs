using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Algorithmic_Collection;

namespace Algorithmic_Testing_Class
{
    [TestClass]
    public class AlgorithmicTests
    {
        private int[] testingArray;

        private int[] expectedResult;

        AlgorithmicTests()
        {
            Random random = new Random();

            testingArray = new int[random.Next(100, 200)];

            for(int i = 0; i < testingArray.Length; i++)
                testingArray[i] = random.Next(1,100);

            expectedResult = new int[testingArray.Length];

            Array.Sort(expectedResult);
        }

        [TestMethod]
        public void MergeSort()
        {
            int[] array = Algorithem.MergeSort(testingArray);
            Assert.AreEqual(expectedResult, array);
        }
    }
}