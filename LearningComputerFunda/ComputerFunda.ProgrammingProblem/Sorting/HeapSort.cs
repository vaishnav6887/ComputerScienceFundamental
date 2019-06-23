using ComputerFunda.DataStructure.Heap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Sorting
{
    public class HeapSort : ISort
    {
        private MaxHeap _data;

        private int[] arr;

        public int[] Sort(int[] _arr)
        {
            _data = new MaxHeap(_arr.Length);
            arr = _arr;

            foreach (var item in arr)
            {
                _data.Add(item);
            }

            int[] returnValue = new int[_data._count];
            int i = _data._count - 1;
            foreach (var item in arr)
            {
                int currentRemoved = _data.Remove();
                returnValue[i] = currentRemoved;
                i--;
            }

            return returnValue;
        }
    }
}
