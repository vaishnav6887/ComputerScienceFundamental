using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Queue
{
    public class DSQueue<T>
    {
        public int Count { get; set; }
        public DSQueueNode<T> Head { get; set; }
        public DSQueueNode<T> Current { get; set; }

        public void Enqueue(T data)
        {
            if (this.Head == null)
            {
                this.Head = new DSQueueNode<T>()
                {
                    Data = data
                };

                this.Count++;
                this.Current = this.Head;
                return;
            }

            this.Current.Next = new DSQueueNode<T>()
            {
                Data = data
            };

            this.Count++;
            this.Current = this.Current.Next;
        }

        public DSQueueNode<T> Dequeue()
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var head = this.Head;

            this.Head = this.Head.Next;

            this.Count--;

            return head;
        }
    }
}
