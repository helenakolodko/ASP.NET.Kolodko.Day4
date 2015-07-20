using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public class sortBySumAscendingHelper : IArrayComparer
    {
        public bool Compare(int[] a, int[] b)
        {
            int firstSum = GetSumOfElements(a);
            int secondSum = GetSumOfElements(b);
            return firstSum > secondSum;
        }

        private int GetSumOfElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
