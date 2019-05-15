using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem
{
    public class StackNode
    {
        public int Data { get; set; }
        public int Max { get; set; }
        public StackNode Next { get; set; }

        public StackNode(int value)
        {
            this.Data = value;
        }
    }

    public class MaxStack
    {
        private StackNode _head;

        public int Count { get; set; }

        public void Push(int val)
        {
            var newNode = new StackNode(val);
            if(this._head == null)
            {
                newNode.Max = val;
                this._head = newNode;
                this.Count++;

                return;
            }

            int max = System.Math.Max(val, this._head.Max);

            newNode.Next = _head;
            newNode.Max = max;
            _head = newNode;
            this.Count++;
        }

        public int Pop()
        {
            if(this._head == null)
            {
                throw new Exception("Stack is empty");
            }

            int returnValue = this._head.Data;

            this._head = this._head.Next;
            this.Count--;

            return returnValue;
        }

        public int Top()
        {
            if (this._head == null)
            {
                throw new Exception("Stack is empty");
            }

            return this._head.Data;
        }

        public int Max()
        {
            if (this._head == null)
            {
                throw new Exception("Stack is empty");
            }

            return this._head.Max;
        }
    }
}
