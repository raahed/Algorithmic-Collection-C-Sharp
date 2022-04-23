namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        private class InsertionSortFunctions
        {
            public static void InsertionSortRecursiv(int[] a, int j, int e)
            {
                if (j == e + 1)
                    return;

                int key = a[j];
                int i = j - 1;
                for (; i > -1 && a[i] > key; i--)
                    a[i + 1] = a[i];
                a[i + 1] = key;

                InsertionSortRecursiv(a, j + 1, e);

            }
        }

        public static void InsertionSort(int[] a)
        {
            for (int j = 1; j < a.Length; j++)
            {
                int key = a[j];
                int i = j - 1;
                for (; i > -1 && a[i] > key; i--)
                    a[i + 1] = a[i];
                a[i + 1] = key;
            }
        }

        public static void InsertionSortRecursiv(int[] a)
        {
            InsertionSortFunctions.InsertionSortRecursiv(a, 0, a.Length - 1);
        }

        public static void InsertionSortRecursivLastSeperated(int[] a)
        {
            InsertionSortFunctions.InsertionSortRecursiv(a, 0, a.Length - 2);
            InsertionSortFunctions.InsertionSortRecursiv(a, a.Length - 1, a.Length - 1);
        }
    }
}
