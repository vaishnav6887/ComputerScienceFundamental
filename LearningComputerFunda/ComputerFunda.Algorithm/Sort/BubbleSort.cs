using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Sort
{
    public class BubbleSort : ISort<int>
    {
        public int[] Sort(int[] arr)
        {
            /// What is bubble sort.
            /// Bubble sort is the simplest sorting algorithm to sort the list of similar items in array.
            /// Idea is to traverse each element one by one and then swap the element if the element at current index is greater than current index + 1.
            /// With every iteration complete, Last elements will be automatically placed in the sorted order.

            /// Dry run arr = (3, 4, 2, 1, 5, 6)
            /// iteration 

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }

            return arr;
        }

        public int[] SortDesc(int[] arr)
        {
            /// What is bubble sort in desc.
            /// Bubble sort is the simplest sorting algorithm to sort the list of similar items in array.
            /// Idea is to traverse each element one by one and then swap the element if the element at current index is less than current index + 1.
            /// With every iteration complete, Last elements will be automatically placed in the sorted order.

            /// Dry run arr = (3, 4, 2, 1, 5, 6)
            /// iteration 

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }

            return arr;
        }
    }
}
