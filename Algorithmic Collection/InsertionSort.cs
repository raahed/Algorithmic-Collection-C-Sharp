namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
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
    }
}
