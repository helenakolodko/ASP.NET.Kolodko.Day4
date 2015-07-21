using System;
using System.Linq;

namespace Task1.Library
{
    public static class IntMatrixSorter 
    {
        /// <summary>
        /// Sort matrix rows using specified compare method.
        /// </summary>
        /// <param name="array">Matrix to be sorted.</param>
        /// <param name="compareMethod">Method that compares two arrays and returns positive number if the first is greater, zero if equals and negative if smaller.</param>
        /// <param name="increasing">Specifies the order of sorting.</param>
        public static void SortRows(int[][] array, IArrayComparer comparer)
        {
            int i = 1;
            bool found = true;

            while (i < array.Length && found)
            {
                found = false;
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (comparer.Compare(array[j - 1], array[j]) > 0)
                    {
                        SwapElements(array, j, j - 1);
                    }
                    found = true;
                }
                i++;
            }
        }

        private static void SwapElements(int[][] array, int i, int j)
        {
            int[] temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
