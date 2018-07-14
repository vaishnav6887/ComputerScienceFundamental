﻿using ComputerFunda.DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Stack
{
    public class DSStack<T>
    {
        public DSDoubleNode<T> Head { get; set; }

        public DSDoubleNode<T> Mid { get; set; }

        public int Count { get; set; }

        public void Push(T data)
        {
            if (this.Head == null)
            {
                this.Head = new DSDoubleNode<T>()
                {
                    Data = data
                };

                this.Mid = this.Head;
                this.Count++;
                return;
            }

            var newNode = new DSDoubleNode<T>()
            {
                Data = data
            };

            this.Head.Prev = newNode;

            newNode.Next = this.Head;

            this.Head = newNode;

            this.Count++;
            
        }

        public void Pop()
        {
            if (this.Head == null)
            {
                return;
            }

            this.Head = this.Head.Next;
            this.Head.Prev = null;
            this.Count--;
        }

        public void findMiddle()
        {

        }
    }
}
