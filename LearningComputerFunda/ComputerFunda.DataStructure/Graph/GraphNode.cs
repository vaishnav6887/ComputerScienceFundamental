using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Graph
{
    public class GraphNode
    {
        public string Value { get; set; }

        public bool IsVisited { get; set; }

        public GraphNode(string val)
        {
            Value = val;
            IsVisited = false;
        }
    }
}
