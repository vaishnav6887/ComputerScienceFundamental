using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.LinkedList
{
    public class DSDoubleNode<T>
    {
        public T Data { get; set; }

        public DSDoubleNode<T> Prev { get; set; }

        public DSDoubleNode<T> Next { get; set; }
    }
}
