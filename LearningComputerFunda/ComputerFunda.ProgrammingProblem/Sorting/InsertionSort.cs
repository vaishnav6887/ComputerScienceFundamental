using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Sorting
{
    public class InsertionSort : ISort
    {
        private int[] arr;

        public int[] Sort(int[] _arr)
        {
            arr = _arr;
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;
                int cachedI = i;
                for (; j >= 0; j--)
                {
                    if(current < arr[j])
                    {
                        arr[cachedI] = arr[j];
                    }
                    else
                    {
                        break;
                    }
                    cachedI--;
                }

                arr[j + 1] = current;
            }

            return arr;
        }
    }
}
