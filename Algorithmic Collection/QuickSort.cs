namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        private class QuickSortFunctions
        {
            public static void QuickSort(int[] a, int p, int r)
            {
                if (p < r)
                {
                    int q = Partition(a, p, r);
                    QuickSort(a, p, q - 1);
                    QuickSort(a, q + 1, r);
                }
            }

            public static int Partition(int[] a, int p, int r)
            {
                int x = a[r];
                int i = p - 1;
                for (int j = p; j <= r - 1; j++)
                    if (a[j] <= x)
                    {
                        i++;
                        (a[j], a[i]) = (a[i], a[j]);
                    }
                (a[i + 1], a[r]) = (a[r], a[i + 1]);
                return i + 1;
            }
        }

        public static void QuickSort(int[] a)
        {
            QuickSortFunctions.QuickSort(a, 0, a.Length - 1);
        }
    }
}
