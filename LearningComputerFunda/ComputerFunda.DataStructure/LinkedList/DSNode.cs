using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.LinkedList
{
    public class DSNode<T>
    {
        public T Data { get; set; }

        public DSNode<T> Next { get; set; }
    }
}
