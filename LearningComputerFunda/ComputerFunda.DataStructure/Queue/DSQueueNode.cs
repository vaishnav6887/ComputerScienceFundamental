using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Queue
{
    public class DSQueueNode<T>
    {
        public T Data { get; set; }
        public DSQueueNode<T> Next { get; set; }
    }
}
