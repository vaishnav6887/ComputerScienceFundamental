using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.LinkedList
{
    public class DSDoubleLinkedList<T>
    {
        public DSDoubleNode<T> Head { get; set; }

        public DSDoubleNode<T> Current { get; set; }

        public int Count { get; set; }

        public void Add(T data)
        {
            if(this.Head == null)
            {
                this.Head = new DSDoubleNode<T>()
                {
                    Data = data
                };

                this.Count++;
                this.Current = this.Head;
                return;
            }

            this.Current.Next = new DSDoubleNode<T>()
            {
                Data = data,
                Prev = this.Current
            };

            this.Current.Next.Prev = this.Current;
            this.Current = this.Current.Next;
            this.Count++;
        }

        public void AddNewHead(T data)
        {
            if(this.Head == null)
            {
                this.Head = new DSDoubleNode<T>()
                {
                    Data = data
                };

                this.Current = this.Head;
                this.Count++;
                return;
            }

            var newHead = new DSDoubleNode<T>()
            {
                Data = data,
                Next = this.Head
            };

            this.Head.Prev = newHead;
            this.Count++;
            this.Head = newHead;

            return;
        }

        public void DeleteHead()
        {
            if(this.Head == null)
            {
                return;
            }

            if (this.Head.Next != null)
            {
                this.Head.Next.Prev = null;
                this.Head = this.Head.Next;
                this.Count--;
            }
            else
            {
                this.Head = null;
                this.Count = 0;
            }
        }

        public void Delete()
        {
            if(this.Current == null)
            {
                return;
            }

            if(this.Current.Prev == null)
            {
                this.Current = null;
                this.Count = 0;
                this.Head = null;
                return;
            }
            
            this.Current = this.Current.Prev;
            this.Current.Next = null;
            this.Count--;
        }
    }
}
