using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Heap
{
    public class MaxHeap: DSHeap
    {
        public MaxHeap(int length)
        {
            _data = new int[length];
        }

        private void Swap(int firstIndex, int secondIndex)
        {
            int current = _data[firstIndex];
            _data[firstIndex] = _data[secondIndex];
            _data[secondIndex] = current;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public int Peek()
        {
            if (_count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            return _data[0];
        }

        public int Remove()
        {
            if(_count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            int returnValue = _data[0];

            _data[0] = _data[_count - 1];

            _count--;

            ReOrderDown(0);

            return returnValue;
        }

        public void Add(int value)
        {
            if (_count == _data.Length)
            {
                throw new OverflowException();
            }

            _data[_count] = value;
            ReOrderUp();
            _count++;
        }

        public void ReOrderUp()
        {
            int index = _count;
            while(!IsRoot(index) && GetParent(index) < _data[index])
            {
                int parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        public void ReOrderDown(int down)
        {
            while (HasLeftChild(down))
            {
                int max = GetLeftChildIndex(down);
                if(HasRightChild(down) && _data[max] < GetRightChild(down))
                {
                    max = GetRightChildIndex(down);
                }

                if(_data[max] > _data[down])
                {
                    Swap(max, down);
                    down = max;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
