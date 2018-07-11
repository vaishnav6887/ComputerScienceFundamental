using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.LinkedList
{
    public class DSLinkedList<T>
    {
        private DSNode<T> _head;

        private DSNode<T> _current;

        public int Count { get; set; }

        public void Add(T node)
        {
            if (this._head == null)
            {
                this._head = new DSNode<T>()
                {
                    Data = node
                };

                this._current = this._head;
                this.Count++;
                return;
            }

            this._current.Next = new DSNode<T>()
            {
                Data = node
            };

            this._current = this._current.Next;

            this.Count++;
        }

        public T ValueAtIndex(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index value should be greater than zero");
            }

            if (index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            if(index == 0)
            {
                return this._head.Data;
            }

            if(index == (Count - 1))
            {
                return this._current.Data;
            }

            DSNode<T> returnValue = this._head;
            int curr = 0;
            while(curr < index)
            {
                returnValue = returnValue.Next;
                curr++;
            }

            return returnValue.Data;
        }

        //public T Delete(T Key, IEqualityComparer<T> equalityComparer)
        //{
            
        //}
    }
}
