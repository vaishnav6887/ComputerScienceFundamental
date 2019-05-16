using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Stack
{
    public class SortStack
    {
        private StackNode _head;
        private int _count;
        private StackNode _secondary;

        public SortStack(int[] arr)
        {
            int i = arr.Length - 1;
            while(i >= 0)
            {
                StackNode head = new StackNode(arr[i]);

                if(_head == null)
                {
                    _head = head;
                }
                else
                {
                    head.Next = _head;
                    _head = head;
                }

                _count++;
                i--;
            }
        }

        public void Push(int val)
        {
            var newNode = new StackNode(val);
            if (this._head == null)
            {
                this._head = newNode;
                this._count++;

                return;
            }

            newNode.Next = _head;
            _head = newNode;
            this._count++;
        }

        public int Pop()
        {
            if (this._head == null)
            {
                throw new Exception("Stack is empty");
            }

            int returnValue = this._head.Data;

            this._head = this._head.Next;
            this._count--;

            return returnValue;
        }

        public StackNode Sort()
        {
            if(_head == null)
            {
                return null;
            }

            while(_count > 0)
            {
                int currentNode = Pop();

                StackNode swap = new StackNode(currentNode);

                while (_secondary != null && _secondary.Data < currentNode)
                {
                    Push(_secondary.Data);
                    _secondary = _secondary.Next;
                }

                swap.Next = _secondary;
                _secondary = swap;
            }

            return _secondary;
        }
    }
}
