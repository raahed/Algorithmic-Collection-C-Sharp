namespace Algorithmic_Collection
{
    public partial class Algorithem
    {
        public static void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length - 1 ; i++)
            {
                int key = a[i];
                int j = i - 1;
                while (j > 0 && a[i] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }
    }
}
