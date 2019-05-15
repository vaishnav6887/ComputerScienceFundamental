using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Stack
{
    public class StackNode
    {
        public int Data { get; set; }

        public StackNode Next { get; set; }

        public int Index { get; set; }

        public StackNode(int value)
        {
            this.Data = value;
        }
    }
}
