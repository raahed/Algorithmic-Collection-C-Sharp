using System;

namespace Algorithmic_Tests
{
    public class AlgorithmicTester
    {
        private static readonly int _arrayLength = 18000;

        private static readonly int _arrayMinValue = 1;
        private static readonly int _arrayMaxValue = 1000;

        private static int[] _sorted;
        private static int[] _unsorted;

        private static int[] _sortedDigitsLength;
        private static int[] _unsortedDigitsLength;

        protected static Random random = new Random(Guid.NewGuid().GetHashCode());

        protected static int[] Sorted
        {
            get
            {
                return (int[])_sorted.Clone();
            }
        }
        protected static int[] Unsorted
        {
            get
            {
                return (int[])_unsorted.Clone();
            }
        }

        protected static int ArrayMinValue
        {
            get { return _arrayMinValue; }
        }

        protected static int ArrayMaxValue
        {
            get { return _arrayMaxValue; }
        }

        protected static int[] SortedDigitsLength
        {
            get { return (int[])_sortedDigitsLength.Clone(); }
        }

        protected static int[] UnsortedDigitsLength
        {
            get { return (int[])_unsortedDigitsLength.Clone(); }
        }
        static AlgorithmicTester()
        {
            _unsorted = new int[_arrayLength];
            _unsortedDigitsLength = new int[_arrayLength];

            for (int i = 0; i < _unsorted.Length; i++)
                _unsorted[i] = random.Next(_arrayMinValue, _arrayMaxValue);

            for (int i = 0; i < _unsortedDigitsLength.Length; i++)
                _unsortedDigitsLength[i] = random.Next(100, 1000);

            _sorted = (int[])_unsorted.Clone();
            _sortedDigitsLength = (int[])_unsortedDigitsLength.Clone();

            Array.Sort(_sorted);
            Array.Sort(_sortedDigitsLength);
        }

        static protected bool IsEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            int counter = 0;

            for (int i = 0; i < array1.Length; i++)
                if (array1[i] != array2[i])
                    counter++;

            if (counter != 0)
                throw new FormatException($"Probably {counter} of {array1.Length} elements are not at the correct position!");

            return true;
        }
    }
}