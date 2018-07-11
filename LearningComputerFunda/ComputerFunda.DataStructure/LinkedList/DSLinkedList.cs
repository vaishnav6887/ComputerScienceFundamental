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

        public bool Delete(T Key, IEqualityComparer<T> equalityComparer)
        {
            if (this._head == null)
            {
                return false;
            }

            DSNode<T> current = this._head;
            DSNode<T> priv = null;
            if(current != null && equalityComparer.Equals(current.Data, Key))
            {
                this._head = current.Next;
                this.Count--;
                return true;
            }

            while(current != null && !equalityComparer.Equals(current.Data, Key))
            {
                priv = current;
                current = current.Next;
            }

            if(current != null)
            {
                priv.Next = current.Next;
                this.Count--;
                return true;
            }

            return false;
        }

        public bool Delete(int index)
        {
            if(this._head == null)
            {
                return false;
            }

            if(index > (Count - 1))
            {
                throw new IndexOutOfRangeException();
            }

            if(index == 0)
            {
                this._head = this._head.Next;
                this.Count--;
                return true;
            }

            int i = 1;
            DSNode<T> current = this._head.Next;
            DSNode<T> prev = this._head;
            while (i != index)
            {
                prev = current;
                current = current.Next;
                i++;
            }

            prev.Next = current.Next;
            Count--;
            return true;
        }
    }
}
