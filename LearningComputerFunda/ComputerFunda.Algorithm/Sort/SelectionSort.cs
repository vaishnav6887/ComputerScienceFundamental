using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Sort
{
    public class SelectionSort : ISort<int>
    {
        public int[] Sort(int[] arr)
        {
            /// Selection sort repeatedly finds the minimum element and placing at the start of the array until array is sorted.
            /// Selection sort starts with zero index and finds the min number in subarr 0-n if it finds min is not at 0th position then it swaps the min element with the zeroth element.
            /// Repeates for 1-n, 2-n, ..., n-1 - n.

            for (int j = 0; j < arr.Length - 1; j++)
            {
                int min = j;
                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[min])
                    {
                        min = i;
                    }
                }

                if (min != j)
                {
                    int swap = arr[j];
                    arr[j] = arr[min];
                    arr[min] = swap;
                }
            }

            return arr;
        }

        public int[] SortDesc(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int max = j;
                for (int i = j + 1; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[max])
                    {
                        max = i;
                    }
                }

                if (max != j)
                {
                    int swap = arr[j];
                    arr[j] = arr[max];
                    arr[max] = swap;
                }
            }

            return arr;
        }
    }
}
