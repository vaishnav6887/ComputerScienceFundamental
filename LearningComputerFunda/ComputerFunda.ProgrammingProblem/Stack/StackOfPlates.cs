using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Stack
{
    public class StackOfPlates
    {
        private List<StackNode> _heads;

        private int _count;

        private int _maxPerStack;

        public int HeadLength
        {
            get
            {
                return _heads == null ? 0 : _heads.Count;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public StackOfPlates(int maxPerStack)
        {
            this._heads = new List<StackNode>();

            this._maxPerStack = maxPerStack;
        }

        public void Push(int value)
        {
            int len = this._heads.Count;

            StackNode newNode = new StackNode(value);
            StackNode newHeadNode = null;
            StackNode _head = len == 0 ? newHeadNode : this._heads[len - 1];
            
            if (_head == null)
            {
                _head = newNode;
                this._count++;
                if(len == 0)
                {
                    this._heads.Add(_head);
                }
                else
                {
                    this._heads[len - 1] = _head;
                }
                return;
            }

            newNode.Index = _head.Index + 1;
            if (newNode.Index % 10 == 0)
            {
                newNode.Index = 0;
                this._heads.Add(newNode);
            }
            else
            {
                newNode.Next = _head;
                newNode.Index = _head.Index + 1;
                _head = newNode;
                this._heads[len - 1] = _head;
            }

            this._count++;
        }

        public int Pop(int index)
        {
            int len = _heads.Count - 1;
            if(index > len)
            {
                throw new IndexOutOfRangeException();
            }

            StackNode _head = _heads.ElementAtOrDefault(index);

            if(_head == null)
            {
                throw new InvalidOperationException();
            }

            int returnValue = _head.Data;

            if(_head.Index == 0 || _head.Next == null)
            {
                _heads.RemoveAt(index);
            }
            else
            {
                _heads[index] = _head.Next;
            }

            this._count--;

            return returnValue;
        }

        public int Pop()
        {
            int len = _heads.Count - 1;
            if (len < 0)
            {
                throw new IndexOutOfRangeException();
            }

            StackNode _head = _heads.ElementAtOrDefault(len);

            int returnValue = _head.Data;

            if (_head.Index == 0 || _head.Next == null)
            {
                _heads.RemoveAt(len);
            }
            else
            {
                _heads[len] = _head.Next;
            }

            this._count--;

            return returnValue;
        }
    }
}
