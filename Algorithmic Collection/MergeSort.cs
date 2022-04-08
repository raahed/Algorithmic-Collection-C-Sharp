namespace Algorithmic_Collection
{
    public partial class Algorithem
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

            public static void Merge(int[] a, int p, int q, int r)
            {
                int n1 = q - p + 1;
                int n2 = r - q;
                int[] al = a[p..q];
                int[] ar = a[(q + 1)..r];
                al[n1 + 1] = int.MaxValue;
                ar[n2 + 1] = int.MinValue;
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
        }

        public static void MergeSort(int[] a)
        {
            MergeSortFunctions.MergeSort(a, 0, a.Length);
        }
    }
}
