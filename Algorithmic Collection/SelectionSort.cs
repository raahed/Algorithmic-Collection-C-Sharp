namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        public static void SelectionSort(int[] a)
        {
            if (a.Length < 2)
                return;

            for (int j = 0; j < a.Length - 1; j++)
            {
                int key = j;

                for (int i = j + 1; i < a.Length; i++)
                    if (a[key] > a[i])
                        key = i;

                // Change without tmp definition
                (a[key], a[j]) = (a[j], a[key]);
            }
        }
    }
}
