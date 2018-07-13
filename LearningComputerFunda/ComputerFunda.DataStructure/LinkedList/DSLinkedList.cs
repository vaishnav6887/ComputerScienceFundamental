using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.LinkedList
{
    public class DSLinkedList<T>
    {
        public DSNode<T> _head { get; set; }

        public DSNode<T> _current { get; set; }

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

            if (index == 0)
            {
                return this._head.Data;
            }

            if (index == (Count - 1))
            {
                return this._current.Data;
            }

            DSNode<T> returnValue = this._head;
            int curr = 0;
            while (curr < index)
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
            if (current != null && equalityComparer.Equals(current.Data, Key))
            {
                this._head = current.Next;
                this.Count--;
                return true;
            }

            while (current != null && !equalityComparer.Equals(current.Data, Key))
            {
                priv = current;
                current = current.Next;
            }

            if (current != null)
            {
                priv.Next = current.Next;
                this.Count--;
                return true;
            }

            return false;
        }

        public bool Delete(int index)
        {
            if (this._head == null)
            {
                return false;
            }

            if (index > (Count - 1))
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
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

        public void Reverse()
        {
            DSNode<T> prev = null;
            DSNode<T> next;
            var current = this._head;
            this._current = this._head;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            this._head = prev;
        }

        public bool DetectLoop()
        {
            bool returnValue = false;
            Dictionary<T, int> map = new Dictionary<T, int>();
            int i = 0;
            DSNode<T> current = this._head;
            while (current != null)
            {
                if (!map.ContainsKey(current.Data))
                {
                    map.Add(current.Data, i);
                }
                else
                {
                    returnValue = true;
                    break;
                }

                current = current.Next;

                i++;
            }

            return returnValue;
        }

        public bool FloydLoopDetect(IEqualityComparer<T> comparer)
        {
            bool returnValue = false;
            var fast = this._head;
            var slow = this._head;

            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (comparer.Equals(slow.Data, fast.Data))
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }

        public T FindMiddle()
        {
            DSNode<T> slow = this._head;
            DSNode<T> fast = this._head;

            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow.Data;
        }

        public int CountOfRepetationOfElement(T item, IEqualityComparer<T> comparer)
        {
            int count = 0;
            DSNode<T> current = this._head;
            while(current != null)
            {
                if(comparer.Equals(current.Data, item))
                {
                    count++;
                }

                current = current.Next;
            }

            return count;
        }
    }
}
