using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Sorting
{
    public class QuickSort : ISort
    {
        private int[] data;
        public QuickSort(int[] _data)
        {
            data = _data;
        }
        public int[] Sort()
        {
            /// Step 1: find pivot

            QuickSorting(0, data.Length - 1);

            return data;
        }

        private void QuickSorting(int left, int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivotIndex = (left + right) / 2;
            int pivot = data[pivotIndex];

            int index = Partition(pivot, left, right);

            QuickSorting(left, index - 1);
            QuickSorting(index, right);
        }

        private int Partition(int pivot, int left, int right)
        {
            while (left <= right)
            {
                while (pivot > data[left])
                {
                    left++;
                }

                while (pivot < data[right])
                {
                    right--;
                }

                if (left <= right)
                {
                    int swap = data[right];
                    data[right] = data[left];
                    data[left] = swap;
                    left++;
                    right--;
                }
            }
            
            return left;
        }
    }
}
