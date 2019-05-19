using ComputerFunda.DataStructure.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.DataStructure.Graph
{
    public class DSGraph
    {
        public int Length { get; set; }

        private Dictionary<string, List<string>> _node = new Dictionary<string, List<string>>();

        public void AddVertex(string data)
        {
            _node.Add(data, new List<string>());

            Length++;
        }

        public void AddEdge(string data, string target)
        {
            if (!_node.ContainsKey(data) && !_node.ContainsKey(target))
            {
                throw new InvalidOperationException();
            }
            _node[data].Add(target);
            _node[target].Add(data);
        }

        public void AddUndirectedEdge(string data, string target)
        {
            if (!_node.ContainsKey(data) && !_node.ContainsKey(target))
            {
                throw new InvalidOperationException();
            }
            _node[data].Add(target);
        }

        public List<string> DFS(string node)
        {
            Dictionary<string, bool> Visible = new Dictionary<string, bool>();
            List<string> s = new List<string>();
            DFS_Helper(node, Visible, s);

            return s;
        }

        public List<string> BFS(string node)
        {
            DSQueue<string> dSQueue = new DSQueue<string>();

            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            dSQueue.Enqueue(node);

            while (!dSQueue.IsEmpty())
            {
                string current = dSQueue.Dequeue().Data;

                if (!visited.ContainsKey(current))
                {
                    visited.Add(current, true);
                }

                foreach (var item in _node[current])
                {
                    if(!visited.ContainsKey(item))
                    {
                        dSQueue.Enqueue(item);
                    }
                }
            }

            return visited.Select(s => s.Key).ToList();
        }

        private void DFS_Helper(string node, Dictionary<string, bool> Visible, List<string> print)
        {
            if (node == null)
            {
                return;
            }

            Visible.Add(node, true);

            print.Add(node);

            foreach (var item in _node[node])
            {
                if (!Visible.ContainsKey(item))
                {
                    DFS_Helper(item, Visible, print);
                }
            }
        }
    }
}
