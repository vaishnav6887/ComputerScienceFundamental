using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Sorting
{
    public class SelectionSort : ISort
    {
        private int[] arr;

        public SelectionSort(int[] _arr)
        {
            arr = _arr;
        }

        public int[] Sort()
        {
            if (arr == null || arr.Length == 0)
            {
                return arr;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                
                for (int j = i; j < arr.Length - i - 1; j++)
                {
                    if(arr[min] > arr[j + 1])
                    {
                        min = j + 1;
                    }
                }

                if(min != i)
                {
                    int swap = arr[min];
                    arr[min] = arr[i];
                    arr[i] = swap;
                }
            }

            return arr;
        }
    }
}
