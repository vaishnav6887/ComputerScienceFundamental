using ComputerFunda.DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.LinkedList
{
    public class ReturnKthToLastElement
    {
        private DSNode<int> _head;

        public ReturnKthToLastElement(DSNode<int> head)
        {
            _head = head;
        }

        public int Execute(int kthIndex)
        {
            if(_head == null)
            {
                return -1;
            }

            int returnValue = -1;

            DSNode<int> runner = _head;
            DSNode<int> current = _head;
            int i = 0;
            while(i < kthIndex && runner.Next != null)
            {
                runner = runner.Next;
                i++;
            }

            while(runner != null)
            {
                runner = runner.Next;
                current = current.Next;
                returnValue = current.Data;
            }

            return returnValue;
        }
    }
}
