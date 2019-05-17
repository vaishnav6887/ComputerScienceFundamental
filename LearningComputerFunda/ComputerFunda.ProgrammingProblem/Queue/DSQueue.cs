using System;

namespace ComputerFunda.ProgrammingProblem.Queue
{
    public class DSQueue<T>
    {
        private QueueNode<T> _head;

        private QueueNode<T> _tail;

        public int Count { get; set; }

        public void Enqueue(T value)
        {
            var newNode = new QueueNode<T>()
            {
                Data = value
            };

            if (_head == null)
            {
                _tail = newNode;

                _head = _tail;

                Count++;
                return;
            }

            _tail.Next = newNode;
            _tail = _tail.Next;

            Count++;
        }

        public T Dequeue()
        {
            if (_head == null)
            {
                throw new Exception("Empty Queue");
            }

            T returnValue = _head.Data;

            _head = _head.Next;
            Count--;

            if (_head == null)
            {
                _tail = null;
            }

            return returnValue;
        }
    }
}
