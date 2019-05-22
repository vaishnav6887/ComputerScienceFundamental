using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Sorting
{
    
    public class BubbleSort: ISort
    {
        private int[] arr;

        public BubbleSort(int[] _arr)
        {
            arr = _arr;
        }

        public int[] Sort()
        {
            if(arr == null || arr.Length == 0)
            {
                return arr;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }

            return arr;
        }

        private void Swap(int first, int second)
        {
            
         }
    }
}
