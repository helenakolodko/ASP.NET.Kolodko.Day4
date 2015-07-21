using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public class SortByMaxMagnitudeAscendingHelper : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            int firstMax = GetMaxMagnitude(a);
            int secondMax = GetMaxMagnitude(b);
            return firstMax.CompareTo(secondMax);
        }

        private int GetMaxMagnitude(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > max)
                {
                    max = Math.Abs(array[i]);
                }
            }
            return max;
        }
    }
}
