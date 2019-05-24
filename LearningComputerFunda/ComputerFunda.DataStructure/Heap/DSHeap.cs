using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Heap
{
    public class DSHeap
    {
        public int[] _data;

        public int _count;

        protected int GetParentIndex(int index) => (index - 1) / 2;

        protected int GetParent(int index) => _data[GetParentIndex(index)];

        protected int GetLeftChildIndex(int index) => (2 * index) + 1;

        protected int GetRightChildIndex(int index) => (2 * index) + 2;

        protected int GetLeftChild(int index) => _data[GetLeftChildIndex(index)];

        protected int GetRightChild(int index) => _data[GetRightChildIndex(index)];

        protected bool HasLeftChild(int index) => _count > GetLeftChildIndex(index);

        protected bool HasRightChild(int index) => _count > GetRightChildIndex(index);

        protected bool IsRoot(int index) => index == 0;
    }
}
