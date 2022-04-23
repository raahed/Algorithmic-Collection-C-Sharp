namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        private class BinarySearchFunctions
        {
            public static int BinarySearchRecursiv(int[] a, int value, int p, int q)
            {
                int i = p + ((q - p) / 2);

                if (a[i] == value)
                    return i;

                if (value < a[i])
                    q = i;
                else
                    p = i;
                
                if (q - p <= 1)
                    return -1;

                return BinarySearchRecursiv(a, value, p, q);
            }
        }

        public static int BinarySearch(int[] a, int value)
        {
            int p = 0, q = a.Length - 1, i = q / 2;

            while (a[i] != value)
            {
                if (value < a[i])
                    q = i;
                else
                    p = i;

                if (q - p <= 1)
                    return -1;
                
                i = p + ((q - p) / 2);
            }

            return i;
        }

        public static int BinarySearchRecursiv(int[] a, int value)
        {
            return BinarySearchFunctions.BinarySearchRecursiv(a, value, 0, a.Length - 1);
        }
    }
}
