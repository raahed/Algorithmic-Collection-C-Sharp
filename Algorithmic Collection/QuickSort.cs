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

            public static void QuickSortOptSameKeys(int[] a, int p, int r)
            {
                if (p < r)
                {
                    int q = PartitionOptSameKeys(a, p, r);
                    QuickSortOptSameKeys(a, p, q - 1);
                    QuickSortOptSameKeys(a, q + 1, r);
                }
            }

            public static int PartitionOptSameKeys(int[] a, int p, int r)
            {
                bool sameKeys = true;
                int x = a[r];
                int i = p - 1;
                for (int j = p; j <= r - 1; j++)
                    if (a[j] <= x)
                    {
                        i++;
                        if (a[j] != x)
                            sameKeys = false;
                        (a[j], a[i]) = (a[i], a[j]);
                    }

                (a[i + 1], a[r]) = (a[r], a[i + 1]);

                if (sameKeys)
                    return (p + r) / 2;
               else 
                return i + 1;
            }

            public static void QuickSortReverse(int[] a, int p, int r)
            {
                if (p < r)
                {
                    int q = PartitionReverse(a, p, r);
                    QuickSortReverse(a, p, q - 1);
                    QuickSortReverse(a, q + 1, r);
                }
            }

            public static int PartitionReverse(int[] a, int p, int r)
            {
                int x = a[r];
                int i = p - 1;
                for (int j = p; j <= r - 1; j++)
                    if (a[j] >= x)
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

        public static void QuickSortReverse(int[] a)
        {
            QuickSortFunctions.QuickSortReverse(a, 0, a.Length - 1);
        }

        public static void QuickSortOptSameKeys(int[] a)
        {
            QuickSortFunctions.QuickSortOptSameKeys(a, 0, a.Length - 1);
        }
    }
}
