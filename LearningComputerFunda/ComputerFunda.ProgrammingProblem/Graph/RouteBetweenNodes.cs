using ComputerFunda.DataStructure.Graph;
using ComputerFunda.DataStructure.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Graph
{
    public static class RouteBetweenNodes
    {
        public static bool FindRoute(this DSGraph graph, string nodeA, string nodeB)
        {
            DSQueue<string> queue = new DSQueue<string>();
            Dictionary<string, bool> visible = new Dictionary<string, bool>();

            queue.Enqueue(nodeA);

            while (!queue.IsEmpty())
            {
                var current = queue.Dequeue().Data;
                if (!visible.ContainsKey(current))
                {
                    visible.Add(current, true);

                    if(current == nodeB)
                    {
                        return true;
                    }
                }

                foreach (var item in graph._node[current])
                {
                    if (!visible.ContainsKey(item))
                    {
                        queue.Enqueue(item);
                    }
                }
            }

            return visible.ContainsKey(nodeB);
        }
    }
}
