namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        private class HeapSortFunctions
        {

            public static int heapSize;

            public static int Parent(int i)
            {

                return (i - 1) / 2;
            }

            public static int Left(int i)
            {
                return (2 * i) + 1;
            }

            public static int Right(int i)
            {
                return (2 * i) + 2;
            }

            public static void MaxHeapify(int[] a, int i)
            {
                int l = Left(i), r = Right(i), max;

                if (l < heapSize && a[l] > a[i])
                    max = l;
                else
                    max = i;

                if (r < heapSize && a[r] > a[max])
                    max = r;

                if (max != i)
                {
                    (a[max], a[i]) = (a[i], a[max]);
                    MaxHeapify(a, max);
                }
            }

            public static void BuildMaxHeap(int[] a)
            {
                heapSize = a.Length;
                for (int i = (a.Length / 2) - 1; i >= 0; i--)
                    MaxHeapify(a, i);
            }
        }

        public static void HeapSort(int[] a)
        {
            if (a.Length < 2)
                return;

            HeapSortFunctions.BuildMaxHeap(a);

            for (int i = a.Length - 1; i > 0; i--)
            {
                (a[0], a[i]) = (a[i], a[0]);
                HeapSortFunctions.heapSize--;
                HeapSortFunctions.MaxHeapify(a, 0);
            }
        }
    }
}
