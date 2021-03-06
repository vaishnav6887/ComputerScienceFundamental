﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Heap
{
    public class MinHeap : DSHeap
    {
        public MinHeap(int length)
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
            if(_count == 0)
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
            if(_count == _data.Length)
            {
                throw new OverflowException();
            }

            _data[_count] = value;
            
            ReOrderUp();

            _count++;
        }

        private void ReOrderUp()
        {
            int index = _count;
            while(!IsRoot(index) && _data[index] < GetParent(index))
            {
                int parentIndex = GetParentIndex(index);
                Swap(index, parentIndex);

                index = parentIndex;
            }
        }

        private void ReOrderDown(int index)
        {
            while(HasLeftChild(index))
            {
                int min = GetLeftChildIndex(index);
                if(HasRightChild(index) && GetRightChild(index) < _data[min])
                {
                    min = GetRightChildIndex(index);
                }

                if(_data[min] < _data[index])
                {
                    Swap(min, index);
                    index = min;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
