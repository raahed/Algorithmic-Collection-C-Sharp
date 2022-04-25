namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        private class MergeSortFunctions
        {
            public static void MergeSort(int[] a, int p, int r)
            {
                if (p < r)
                {
                    int q = (p + r) / 2;
                    MergeSort(a, p, q);
                    MergeSort(a, q + 1, r);
                    Merge(a, p, q, r);
                }
            }
            public static void MergeSortWithoutSentinel(int[] a, int p, int r)
            {
                if (p < r)
                {
                    int q = (p + r) / 2;
                    MergeSort(a, p, q);
                    MergeSort(a, q + 1, r);
                    MergeWithoutSentinel(a, p, q, r);
                }
            }

            public static void Merge(int[] a, int p, int q, int r)
            {
                int n1 = q - p + 1;
                int n2 = r - q;

                int[] al = new int[n1 + 1];
                int[] ar = new int[n2 + 1];

                Array.Copy(a[p..(q + 1)], al, n1);
                Array.Copy(a[(q + 1)..(r + 1)], ar, n2);

                al[n1] = int.MaxValue;
                ar[n2] = int.MaxValue;

                int i = 0, j = 0;
                for (int k = p; k <= r; k++)
                {
                    if (al[i] <= ar[j])
                    {
                        a[k] = al[i];
                        i++;
                    }
                    else
                    {
                        a[k] = ar[j];
                        j++;
                    }
                }
            }

            public static void MergeWithoutSentinel(int[] a, int p, int q, int r)
            {
                int n1 = q - p + 1;
                int n2 = r - q;

                int[] al = new int[n1];
                int[] ar = new int[n2];

                Array.Copy(a[p..(q + 1)], al, n1);
                Array.Copy(a[(q + 1)..(r + 1)], ar, n2);

                int i = 0, j = 0, k = p;

                while (i < n1 && j < n2)
                {
                    if (al[i] <= ar[j])
                    {
                        a[k] = al[i];
                        i++;
                    }
                    else
                    {
                        a[k] = ar[j];
                        j++;
                    }
                    k++;

                }

                if (i < n1)
                    Array.Copy(al, i, a, k, n1 - i);
            }

        }

        public static void MergeSortWithoutSentinel(int[] a)
        {
            MergeSortFunctions.MergeSortWithoutSentinel(a, 0, a.Length - 1);
        }

        public static void MergeSort(int[] a)
        {
            MergeSortFunctions.MergeSort(a, 0, a.Length - 1);
        }
    }
}
