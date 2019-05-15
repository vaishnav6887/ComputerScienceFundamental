using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Stack
{
    public class MaxStackNode : StackNode 
    {
        public int Max { get; set; }

        public new MaxStackNode Next { get; set; }

        public MaxStackNode(int value) : base(value)
        { 
        }
    }

    public class MaxStack
    {
        private MaxStackNode _head;

        public int Count { get; set; }

        public void Push(int val)
        {
            var newNode = new MaxStackNode(val);
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
