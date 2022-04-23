namespace Algorithmic_Collection
{
    partial class Algorithm
    {
        public static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = a.Length - 1; j >= i + 1; j--)
                    if (a[j] < a[j - 1])
                        (a[j], a[j - 1]) = (a[j - 1], a[j]);
        }
    }
}
